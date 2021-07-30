using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage.Watercrafts
{
    class Raft : Watercraft
    {
        public int NumberOfLogUser { get; set; }

        public string Name { get; set; }

        public Raft(string name)
        {
            Name = name;
        }

        public void RiverRafting()
        {
            Console.WriteLine("Let's go to River Rafting!");
        }

        public override void Refueling()
        {
            Console.WriteLine($"Luckily, {Name} does not need refueling");
        }

        public override void Driving()
        {
            RiverRafting();
            Console.WriteLine($"This {Name} gives you the best driving experience");
        }

    }
}
