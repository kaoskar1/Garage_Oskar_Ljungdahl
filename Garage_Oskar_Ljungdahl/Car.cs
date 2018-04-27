using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Oskar_Ljungdahl
{
    class Car : Vehicle

        {
        public string TypeOfCar { get; set; }
        public string CarBrand { get; set; }
      



        public Car(int wheels, int seats, int horsePower, int gasTank, string typeOfGas, string numberPlate, string typeOfCar, string carBrand) : base(wheels, seats, horsePower, gasTank, typeOfGas, numberPlate)
        {
            TypeOfCar = typeOfCar;
            CarBrand = carBrand;
            NumberPlate = numberPlate;
        }

    }
}
