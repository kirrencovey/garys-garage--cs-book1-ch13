// Move all common properties in your vehicles to a new Vehicle class.
// Create an instance of each vehicle.
// Define a different value for each vehicle's properties.
// Create a Drive() method in the Vehicle class.
// Override the Drive() method in all the other vehicle classes. Include the vehicle's color in the message (i.e. "The blue Ram drives past. RRrrrrrummbbble!").
// Create a Turn(string direction) mathod, and a Stop() method on Vehicle. Define a basic implementation of each.
// Override all three of those methods on some of the vehicles. For example, the Stop() method for a plane would be to output the message "The white Cessna rolls to a stop after rolling a mile down the runway."
// Make your vehicle instances perform all three behaviors.

using System;

namespace garys_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero () {
                MainColor = "blue",
                MaximumOccupancy = 2,
                BatteryKWh = 65
            };
            Cessna mx410 = new Cessna () {
                MainColor = "white",
                MaximumOccupancy = 3,
                FuelCapacity = 40
            };
            Tesla modelS = new Tesla () {
                MainColor = "silver",
                MaximumOccupancy = 4,
                BatteryKWh = 120
            };
            Ram big4x4 = new Ram () {
                MainColor = "red",
                MaximumOccupancy = 5,
                FuelCapacity = 18
            };

            fxs.Drive();
            fxs.Turn("left");
            fxs.Stop();
            mx410.Drive();
            mx410.Turn("right");
            mx410.Stop();
            modelS.Drive();
            modelS.Turn("around");
            modelS.Stop();
            big4x4.Drive();
            big4x4.Turn("right");
            big4x4.Stop();

        }
    }
}
