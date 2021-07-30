using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage
{
    class Watercraft : Vehicle
    {
        public int FuelCapacity { get; set; }
        
        public int PassengerOccupancy { get; set; }

        public override void Refueling()
        {
            Console.WriteLine("Let's refill my watercraft.");
        }
        
        public override void Driving()
        {
            Console.WriteLine("Let's drive this watercraft");
        }
    }
}
