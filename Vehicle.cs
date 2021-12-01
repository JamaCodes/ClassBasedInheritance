using System; 

namespace Garage
{
    public class Vehicle
    {
        public virtual string MainColor { get; set; }
        public virtual int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
    }
}
