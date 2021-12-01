

namespace Garage
{
    public interface IElectricVehicle
    {
    int CurrentChargePercentage { get; set; }
      public void ChargeBattery(){} 

    }

    public interface IGasVeicle
    {
        void RefuelTank();
    }

    public interface IFlying
    {
        void Fly();
    }
}
