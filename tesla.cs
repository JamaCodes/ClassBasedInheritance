using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {

        public int CurrentChargePercentage { get; set; } = 80;
          public void ChargeBattery()
            {
            CurrentChargePercentage = 100;
            }

        public override void  Drive(){
            Console.WriteLine("nosound bc it's electric!");
        }

     
    }
}
