using System;
using System.Collections.Generic;
namespace Garage
{
    class Program
    {
        static void Main (string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

        }
    }
}