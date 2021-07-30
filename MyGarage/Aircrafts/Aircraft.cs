using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage
{
    class Aircraft : Vehicle
    {
        public int FuelCapacity { get; set; }
        public int PassengerOccupancy { get; set; }

        public override void Refueling()
        {
            Console.WriteLine($"This aircraft needs refueling.");
        }

        public virtual void Flying()
        {
            Console.WriteLine($"I am flying!");
        }

        public virtual void Landing()
        {
            Console.WriteLine("The plane is ready for landing.");
        }


    }
}
