using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_15_07_19
{
    class Bus : Vehicle, ITaxable
    {
        private int _numOfPassangers;


        public Bus(string vehicleNumber, int maxSpeed, int vehicleValue, int numOfPassangers) : base(vehicleNumber, maxSpeed, vehicleValue)
        {
            _numOfPassangers = numOfPassangers;

        }
        public int NumOfPassangers
        {
            get { return _numOfPassangers; }
            set { _numOfPassangers = value; }
        }

        public double CalculateTax()
        {
            return VehicleValue * (- NumOfPassangers * 0.02 + MaxSpeed * 0.15);

        }
        public override string ToString()
        {
            return $"The number of vihicle : {VehicleNumber} The Value of vehicle {VehicleValue} Tax for Vehicle :";
        }
           
}
}
