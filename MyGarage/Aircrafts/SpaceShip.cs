using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Aircrafts
{
    class SpaceShip : Aircraft
    {
        public string Name { get; set; }
        public SpaceShip(string name)
        {
            Name = name;
        }

        public override void Flying()
        {
            base.Flying();
            Console.WriteLine($"I am flying {Name}");
        }

        public override void Landing()
        {
            Console.WriteLine($"This {Name} is about to land on Mars");
        }
    }
}
