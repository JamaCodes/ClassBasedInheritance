
namespace Garage
{
 public class Ram : Vehicle, IGasVeicle// Gas powered truck
{
    public int CurrentTankPercentage { get; set; } = 50;

    public void RefuelTank()
    {
        CurrentTankPercentage = 100;
    }
}

}
