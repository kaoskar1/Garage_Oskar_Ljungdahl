using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Oskar_Ljungdahl
{

     class Bus : Vehicle 
    {
        public int Length { get; set; }
        public bool Articulated { get; set; }

        public Bus(int wheels, int seats, int horsePower, int gasTank, string typeOfGas, string numberPlate, int length, bool articulated) : base(wheels, seats, horsePower, gasTank, typeOfGas, numberPlate)
        {
            Length = length;
            Articulated = articulated;
        }
    }

}
