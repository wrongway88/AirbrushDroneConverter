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
    public partial class FormFilter : Form
    {
        private Filter _filter;
        private MainForm _mainForm;
        private bool _minDateChanged = false;
        private bool _maxDateChanged = false;

        public FormFilter(Filter filter, MainForm mainForm)
        {
            InitializeComponent();

            propertyGridFilter.SelectedObject = filter;

            if (filter.MinDate == null)
            {
                propertyGridMinDate.SelectedObject = new Flight.Date();
            }
            else
            {
                propertyGridMinDate.SelectedObject = filter.MinDate;
            }

            if (filter.MaxDate == null)
            {
                propertyGridMaxDate.SelectedObject = new Flight.Date();
            }
            else
            {
                propertyGridMaxDate.SelectedObject = filter.MaxDate;
            }

            _minDateChanged = false;
            _maxDateChanged = false;

            _filter = filter;
            _mainForm = mainForm;
        }

        private void FormFilter_Close(object sender, EventArgs e)
        {
            if (_minDateChanged)
            {
                _filter.MinDate = (Flight.Date)propertyGridMinDate.SelectedObject;
            }

            if (_maxDateChanged)
            {
                _filter.MaxDate = (Flight.Date)propertyGridMaxDate.SelectedObject;
            }

            _mainForm.filterChanged();
        }

        private void propertyGridFilter_Click(object sender, EventArgs e)
        {
        }

        private void FormFilter_Load(object sender, EventArgs e)
        {

        }

        private void propertyGridMinDate_SelectedObjectsChanged(object sender, EventArgs e)
        {
            //_minDateChanged = true;
        }

        private void propertyGridMaxDate_SelectedObjectsChanged(object sender, EventArgs e)
        {
            //_maxDateChanged = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void propertyGridMinDate_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            _minDateChanged = true;
        }

        private void propertyGridMaxDate_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            _maxDateChanged = true;
        }
    }
}
