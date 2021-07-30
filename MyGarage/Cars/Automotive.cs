using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage
{
    class Automotive : Vehicle
    {
        public int FuelCapacity { get; set; }
        public double BatteryCapacity { get; set; }
        public int PassengerOccupancy { get; set; }

        public override void Refueling()
        {
            Console.WriteLine($"Your car's Fuel Capacity is {FuelCapacity}. Let's fill it to the max");
        }

        public override void Driving()
        {
            Console.WriteLine($"Let's go for a drive with my car");
        }

        public virtual void Braking()
        {
            Console.WriteLine(" gotta stop!!!!!");
        }
    }
}
