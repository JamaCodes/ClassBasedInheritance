

namespace Garage
{
    public class Cessna : Vehicle , IGasVeicle
    {
  public int CurrentTankPercentage { get; set; } = 50;

    public void RefuelTank()
    {
        CurrentTankPercentage = 100;
    }
    }
}

