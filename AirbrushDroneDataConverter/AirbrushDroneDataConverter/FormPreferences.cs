using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AirbrushDroneDataConverter.Utility;

namespace AirbrushDroneDataConverter
{
    public partial class FormPreferences : Form
    {
        public FormPreferences()
        {
            InitializeComponent();

            propertyGridLoginData.SelectedObject = Preferences.LoadPreferences();
        }

        private void FormLoginData_Close(object sender, EventArgs e)
        {
            Preferences loginData = propertyGridLoginData.SelectedObject as Preferences;

            if (loginData != null)
            {
                Preferences.SavePreferences(loginData);
            }
        }

        private void propertyGridLoginData_Click(object sender, EventArgs e)
        {

        }
    }
}
