using MyGarage.Aircrafts;
using MyGarage.Cars;
using MyGarage.Watercrafts;
using System;
using System.Collections.Generic;

namespace MyGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is what driving and braking methods of automotive give back.");
            var automotives = new List<Automotive>() { new SubaruBrz("Subaru BRZ"), new ToyotaCamry("Toyota Camry") };
            foreach (var automotive in automotives)
            {
                automotive.Driving();
                automotive.Braking();
            }
            Console.WriteLine();

            Console.WriteLine("This is what refueling and driving methods of watercraft give back.");
            var watercrafts = new List<Watercraft>() { new Raft("Raft"), new LuxuaryBoat("Lucuary Boat", 350) };
            foreach (var watercraft in watercrafts)
            {
                watercraft.Refueling();
                watercraft.Driving();
            }
            Console.WriteLine();

            Console.WriteLine("This is what flying and landing methods of aircraft give back.");
            var aircrafts = new List<Aircraft>() { new RescueHelicopter("RescueHelicopter", 5), new SpaceShip("Spaceship") };
            foreach (var aircraft in aircrafts)
            {
                aircraft.Flying();
                aircraft.Landing();
            }
            Console.WriteLine();
        }
    }
}
