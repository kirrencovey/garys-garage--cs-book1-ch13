using System;

namespace garys_garage
{
    public class Cessna : Vehicle {  // Propellor light aircraft
        public double FuelCapacity { get; set; }
        public void RefuelTank () {
            Console.WriteLine("Time to refuel this lil plane.");
        }
        public override void Drive () {
            Console.WriteLine($"The {MainColor} Cessna flies past. ZZZOOOOOM!");
        }
        public override void Turn (string direction) {
            Console.WriteLine($"The {MainColor} Cessna banks {direction}.");
        }
        public override void Stop () {
            Console.WriteLine($"The {MainColor} Cessna comes to a stop after rolling a mile down the runway.");
        }
    }
}