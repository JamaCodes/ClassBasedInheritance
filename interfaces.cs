

namespace Garage
{
    public interface IElectricVehicle
    {    
        int CurrentChargePercentage { get; set; }
        void ChargeBattery(){} 
    }

    public interface IGasVeicle
    {
        int CurrentTankPercentage {get; set;}
        void RefuelTank();
    }

    // public interface IFlying
    // {
    //     void Fly();
    // }
}
