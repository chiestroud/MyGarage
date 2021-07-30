using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGarage
{
    abstract class Vehicle
    {

        public VehicleColor Color { get; set; }
        public virtual void Driving()
        {
            Console.WriteLine("Let's Drive!");
        }

        public abstract void Refueling();
    }
}
