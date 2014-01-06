using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirbrushDroneDataConverter.Flight;

namespace AirbrushDroneDataConverter.Utility
{
    public class Filter
    {
        private int _minWaypointsCount = -1;
        private int _maxWaypointsCount = -1;

        private Date _minDate = null;
        private Date _maxDate = null;

        public Filter()
        { }

        public int MinWaypointsCount
        {
            get { return _minWaypointsCount; }
            set
            {
                _minWaypointsCount = value;
                if (_minWaypointsCount > _maxWaypointsCount)
                {
                    _maxWaypointsCount = _minWaypointsCount;
                }
            }
        }

        public int MaxWaypointsCount
        {
            get { return _maxWaypointsCount; }
            set
            {
                _maxWaypointsCount = value;
                if (_maxWaypointsCount < _minWaypointsCount)
                {
                    _minWaypointsCount = _maxWaypointsCount;
                }
            }
        }

        public Date MinDate
        {
            get { return _minDate; }
            set
            {
                _minDate = value;
                if (_minDate != null && _maxDate != null && _minDate > _maxDate)
                {
                    _maxDate = _minDate;
                }
            }
        }

        public Date MaxDate
        {
            get { return _maxDate; }
            set
            {
                _maxDate = value;
                if (_maxDate != null && _minDate != null && _maxDate < _minDate)
                {
                    _minDate = _maxDate;
                }
            }
        }
    }
}
