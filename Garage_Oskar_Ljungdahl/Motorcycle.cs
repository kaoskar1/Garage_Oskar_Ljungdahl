using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Oskar_Ljungdahl
{
    class Bikes : Vehicle
    {

        public bool MotorDriven { get; set; }
        public bool Rack { get; set; }


        public Bikes(int wheels, int seats, int horsePower, int gasTank, string typeOfGas, string numberPlate, bool motorDriven, bool rack) : base(wheels, seats, horsePower, gasTank, typeOfGas, numberPlate)
            
        {
            MotorDriven = motorDriven;
            Rack = rack;
        }
    }
}
