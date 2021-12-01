
namespace Garage
{
public class Zero : Vehicle , IElectricVehicle
{
    public int CurrentChargePercentage { get; set; } = 59;

    public void ChargeBattery()
    {
        CurrentChargePercentage = 100;
    }
}
}

