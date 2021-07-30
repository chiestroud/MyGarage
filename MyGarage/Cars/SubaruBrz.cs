using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Cars
{
    class SubaruBrz : Automotive
    {
        public bool IsRearWheelDrive { get; set; }
        public bool IsBoxerEngine { get; set; }
        public string Name { get; set; }

        public SubaruBrz(string name)
        {
            Name = name;
        }
        
        public void Race()
        {
            Console.WriteLine("Let's race");
        }

        public override void Driving()
        {
            base.Driving();
            Console.WriteLine($"You are driving {Name}");
        }

        public override void Braking()
        {
            Console.Write($"{Name}");
            base.Braking();
        }
    }
}
