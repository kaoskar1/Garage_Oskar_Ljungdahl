    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Oskar_Ljungdahl
{
    class Vehicle
    {


        private int wheels;

        public int Wheels
        {
            get { return wheels; }
            set { wheels = value; }
        }

        private int seats;

        public int Seats
        {
            get { return seats; }
            set { seats = value; }
        }

        private int horsePower;

        public int HorsePower
        {
            get { return horsePower; }
            set { horsePower = value; }
        }

        private int gasTank;

        public int GasTank
        {
            get { return gasTank; }
            set { gasTank = value; }
        }


        private string typeOfGas;

        public string TypeOfGas
        {
            get { return typeOfGas; }
            set { typeOfGas = value; }
        }

        private string numberPlate;

        public string NumberPlate
        {
            get { return numberPlate; }
            set { numberPlate = value; }
        }



        public Vehicle(int wheels, int seats, int horsePower, int gasTank, string typeOfGas, string numberPlate)
        {

            // propertys
            Wheels = wheels;
            Seats = seats;
            HorsePower = horsePower;
            GasTank = gasTank;
            TypeOfGas = typeOfGas;
            NumberPlate = numberPlate;
        }
    }
}