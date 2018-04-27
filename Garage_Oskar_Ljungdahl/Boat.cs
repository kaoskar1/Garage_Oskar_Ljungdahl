using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Oskar_Ljungdahl
{
    class Boat : Vehicle
    {
        public string MadeOf { get; set; }
        public bool Sailing { get; set; }


        public Boat(int wheels, int seats, int horsePower, int gasTank, string typeOfGas, string madeOf, bool sailing):  base(wheels, seats, horsePower, gasTank, typeOfGas)
        {
            MadeOf = madeOf;
            Sailing = sailing;
        }
    }
}
