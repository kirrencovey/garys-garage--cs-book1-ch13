using System;
using System.Collections.Generic;

namespace garys_garage
{
    public class BatteryStation : IFuelingStation<IElectric>
    {
        public int Capacity { get; set; }
        public void Refuel(List<IElectric> vehicles){
            vehicles.ForEach(v => v.ChargeBattery());
        }
    }
}