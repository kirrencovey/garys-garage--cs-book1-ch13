using System;

namespace garys_garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public virtual void Drive () {
            Console.WriteLine("Vrooom!");
        }
        public virtual void Turn (string direction) {
            Console.WriteLine($"The vehicle turns {direction}");
        }
        public virtual void Stop () {
            Console.WriteLine("The vehicle stops.");
        }
    }
}