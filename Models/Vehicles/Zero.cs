using System;

namespace garys_garage
{
    public class Zero : Vehicle, IElectric {  // Electric motorcycle
        public double BatteryKWh { get; set; }
        public void ChargeBattery () {
            Console.WriteLine($"Charge up this {MainColor} Zero so we can get back to zooming!");
        }
        public override void Drive () {
            Console.WriteLine($"The {MainColor} Zero speeds past. Vroom vroom!");
        }
        public override void Stop () {
            Console.WriteLine($"The {MainColor} Zero screeches to a halt.");
        }
    }
}