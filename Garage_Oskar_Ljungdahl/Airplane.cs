using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Oskar_Ljungdahl
{
    class Airplane : Vehicle
    {
        public string PlaneType { get; set; }
        public bool WeaponMode { get; set; }
        public int MiselCount { get; set; }
        public int MachineGun { get; set; }



        public Airplane(int wheels, int seats, int horsePower, int gasTank, string typeOfGas, string planeType, bool weaponMode, int miselCount, int machineGun) : base(wheels, seats, horsePower, gasTank, typeOfGas)
        {
            PlaneType = planeType;
            WeaponMode = weaponMode;
            MiselCount = miselCount;
            MachineGun = machineGun;
        }

    }
}
