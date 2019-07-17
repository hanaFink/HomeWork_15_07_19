using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_15_07_19
{
    class House : Property, ITaxable
    {
        private int _housesquere;
        private int _gardensquere;

        public House(string street, string city, int propertyValue, int housesquere, int gardensquere) : base(street, city, propertyValue)
        {
            _housesquere = housesquere;
            _gardensquere = gardensquere;
        }
        public int Housesquere
        {
            get { return _housesquere; }
            set { _housesquere = value; }
        }
        public int Gardensquere
        {
            get { return _gardensquere; }
            set { _gardensquere = value; }


        }
        public double CalculateTax()
        {
            return (_housesquere * 0.08 + _housesquere * 0.04) * PropertyValue;
        }
        public override string ToString()
        {
            return $"The adress of house is : {Street},{City} The Value of property is {PropertyValue} Tax for House :";
        }
    }
}
