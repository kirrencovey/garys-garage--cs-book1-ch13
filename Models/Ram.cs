using System;

namespace garys_garage
{
    public class Ram : Vehicle {  // Gas powered truck
        public double FuelCapacity { get; set; }
        public void RefuelTank () {
            Console.WriteLine("Time for more fuel! Screw the planet!!");
        }
        public override void Drive () {
            Console.WriteLine($"The {MainColor} Ram drives past. Rrrrumble!");
        }
        public override void Turn (string direction) {
            Console.WriteLine($"The {MainColor} Ram veers {direction}");
        }
    }
}