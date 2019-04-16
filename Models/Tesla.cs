using System;

namespace garys_garage
{
    public class Tesla : Vehicle {  // Electric car
        public double BatteryKWh { get; set; }
        public void ChargeBattery () {
            Console.WriteLine("Charging that battery. Saving the world. NBD");
        }
        public override void Drive () {
            Console.WriteLine($"The {MainColor} Tesla glides silently past!");
        }
        public override void Stop () {
            Console.WriteLine($"The {MainColor} Tesla stops soundlessly.");
        }
    }
}