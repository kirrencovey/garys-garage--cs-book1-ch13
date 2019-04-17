using System;
using System.Collections.Generic;

namespace garys_garage
{
    public class GasStation : IFuelingStation<IGasPowered>
    {
        public int Capacity { get; set; }
        public void Refuel(List<IGasPowered> vehicles){
            vehicles.ForEach(v => v.RefuelTank());
        }
    }
}