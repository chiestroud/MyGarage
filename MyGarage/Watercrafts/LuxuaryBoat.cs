using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Watercrafts
{
    class LuxuaryBoat : Watercraft
    {
        public int NumberOfBeerItCanHold { get; set; }
        public string Name { get; set; }

        public LuxuaryBoat(string name, int beer)
        {
            Name = name;
            NumberOfBeerItCanHold = beer;
        }
        public void LuxuryRide()
        {
            Console.WriteLine($"This {Name} can hold {NumberOfBeerItCanHold} cans of beer.");
        }

        public override void Refueling()
        {
            Console.WriteLine("It's almost out of gas. Please refill");
        }

        public override void Driving()
        {
            LuxuryRide();
            Console.WriteLine($"Let's go to the other side of sea with this {Name}");
        }
    }
}
