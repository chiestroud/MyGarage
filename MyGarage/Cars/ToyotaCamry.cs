using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Cars
{
    class ToyotaCamry : Automotive
    {
        public string IsPopular { get; set; }
        public string Name { get; set; }
        public VehicleColor VehicleColor { get; set; }

        public ToyotaCamry(string name)
        {
            Name = name;
        }

        public override void Driving()
        {
            base.Driving();
            VehicleColor = VehicleColor.PearlWhite;
            Console.WriteLine($"You are driving {Name} and the color is {VehicleColor}");
        }

        public override void Braking()
        {
            Console.Write($"{Name}");
            base.Braking();
        }
    }
}
