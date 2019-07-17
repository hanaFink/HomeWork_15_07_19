using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_15_07_19
{
    class Property
    {
        private string _street;
        private string _city;
        private int _propertyValue;

        public Property(string street, string city, int propertyValue)
        {
            _street = street;
            _city = city;
            _propertyValue = propertyValue;

        }

        public string Street
        {
            get { return _street; }
            set { _street = value; }

        }
        public string City
        {
            get { return _city; }
            set { _city = value; }

        }
        public int PropertyValue
        {
            get { return _propertyValue; }
            set { _propertyValue = value; }

        }

    }


    }
