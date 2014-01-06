using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using AirbrushDroneDataConverter.DroneData;
using AirbrushDroneDataConverter.Utility;

namespace AirbrushDroneDataConverter
{
    public partial class MainForm : Form
    {
        private List<Flight.Flight> _flights = new List<Flight.Flight>();
        private Filter _filter = new Filter();
        private String _filePath = "";

        public MainForm()
        {
            InitializeComponent();

            Preferences preferences = Preferences.LoadPreferences();
            _filePath = preferences.LastUsedFilePath;
        }

        private void openFiles(string[] filePaths)
        {
            foreach (string filePath in filePaths)
            {
                string ending = filePath.Substring(filePath.Length - 3, 3);

                if(ending == "log")
                {
                    StreamReader file = new StreamReader(filePath);

                    String fileName = filePath.Substring(filePath.LastIndexOf("\\")+1);
                    _flights.AddRange(DroneDataConverter.ConvertFile(file, fileName));
                }
            }

            listViewFlights.Items.Clear();
            fillFlightList(_flights);
        }

        private void fillFlightList(List<Flight.Flight> flights)
        {
            int idx = 0;
            foreach(Flight.Flight flight in flights)
            {
                if(filterFlight(flight))
                {
                    ListViewItem item = this.listViewFlights.Items.Add(new ListViewItem(idx.ToString()));
                    item.SubItems.Add(flight.AirplaneRegistration);
                    item.SubItems.Add(flight.Date.ToJSON());
                    item.SubItems.Add(flight.GetWaypointCount().ToString());
                    idx++;
                }
            }
        }

        private bool filterFlight(Flight.Flight flight)
        {
            if (_filter.MinWaypointsCount > -1 && flight.GetWaypointCount() < _filter.MinWaypointsCount)
            {
                return false;
            }
            if (_filter.MaxWaypointsCount > -1 && flight.GetWaypointCount() > _filter.MaxWaypointsCount)
            {
                return false;
            }

            if (_filter.MinDate != null && flight.Date < _filter.MinDate)
            {
                return false;
            }
            if (_filter.MaxDate != null && flight.Date > _filter.MaxDate)
            {
                return false;
            }

            return true;
        }

        private void listViewFlights_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show("selected " + listViewFlights.SelectedItems[0].SubItems[0].Text);
            int selectedIndex = listViewFlights.SelectedItems[0].Index;

            DialogResult result = MessageBox.Show("Do you want to upload the selected flight?", "Upload", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Preferences loginData = Preferences.LoadPreferences();
                if (loginData.MailAddress.Length > 0 && loginData.Password.Length > 0)
                {
                    int userId = WebInterface.WebInterface.GetUserID(loginData.MailAddress);
                    if (userId > -1)
                    {
                        loginData.UserId = userId;
                        WebInterface.WebInterface.Login(userId, Utility.Utility.SaltPassword(loginData.Password, loginData.MailAddress));
                        Preferences.SavePreferences(loginData);
                    }
                    else
                    {
                        MessageBox.Show("Login failed, invalid login data!");
                        FormPreferences loginDataForm = new FormPreferences();
                        loginDataForm.Show();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Set Login Data first");
                    FormPreferences loginDataForm = new FormPreferences();
                    loginDataForm.Show();
                    return;
                }

                if (selectedIndex >= 0 && selectedIndex < _flights.Count)
                {
                    Flight.Flight flight = _flights[selectedIndex];
                    WebInterface.WebInterface.PostFlight(flight);
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = _filePath;
            
            DialogResult result = fbd.ShowDialog();
         
            if (fbd.SelectedPath.Length > 0 && result == System.Windows.Forms.DialogResult.OK)
            {
                _filePath = fbd.SelectedPath;
                Preferences preferences = Preferences.LoadPreferences();
                preferences.LastUsedFilePath = _filePath;
                Preferences.SavePreferences(preferences);
                string[] files = Directory.GetFiles(fbd.SelectedPath);
                openFiles(files);
            }
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //WebInterface.WebInterface.GetUserID("test@test.com");

            FormPreferences loginDataForm = new FormPreferences();
            loginDataForm.Show();
        }

        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFilter form = new FormFilter(_filter, this);
            form.Show();
        }

        public void filterChanged()
        {
            listViewFlights.Items.Clear();

            fillFlightList(_flights);
        }
    }
}
