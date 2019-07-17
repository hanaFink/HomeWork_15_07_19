using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_15_07_19
{
    class Vehicle
    {
        private string _vehicleNumber;
        private int _maxSpeed;
        private int _vehicleValue;

        public Vehicle(string vehicleNumber, int maxSpeed, int vehicleValue)
        {
        _vehicleNumber = vehicleNumber;
         _maxSpeed = maxSpeed;
         _vehicleValue = vehicleValue;
    }

        public string VehicleNumber
        {
            get { return _vehicleNumber; }
            set { _vehicleNumber = value; }

        }
        public int MaxSpeed
        {
            get { return _maxSpeed; }
            set { _maxSpeed = value; }

        }
        public int VehicleValue
        {
            get { return _vehicleValue; }
            set { _vehicleValue = value; }

        }

    }


}
