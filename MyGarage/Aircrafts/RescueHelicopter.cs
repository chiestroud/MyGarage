using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Aircrafts
{
    class RescueHelicopter : Aircraft
    {
        public int NumberOfRescueForTheDay { get; set; }
        public string Name { get; set; }
        public RescueHelicopter(string name, int rescue)
        {
            Name = name;
            NumberOfRescueForTheDay = rescue;
        }

        public void EmergencyCall()
        {
            Console.WriteLine($"I am going to save {NumberOfRescueForTheDay} people");
        }

        public override void Flying()
        {
            Console.WriteLine($"I am fyling {Name}");
            EmergencyCall();
        }
    }
}
