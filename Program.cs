// Move all common properties in your vehicles to a new Vehicle class.
// Create an instance of each vehicle.
// Define a different value for each vehicle's properties.
// Create a Drive() method in the Vehicle class.
// Override the Drive() method in all the other vehicle classes. Include the vehicle's color in the message (i.e. "The blue Ram drives past. RRrrrrrummbbble!").
// Create a Turn(string direction) mathod, and a Stop() method on Vehicle. Define a basic implementation of each.
// Override all three of those methods on some of the vehicles. For example, the Stop() method for a plane would be to output the message "The white Cessna rolls to a stop after rolling a mile down the runway."
// Make your vehicle instances perform all three behaviors.

// Generic Types Practice: Refueling Stations for Gary's Wholesale Garage
// Create a GasStation type for gas-powered vehicles.
// Create a BatteryStation type for eletric-powered vehicles.
// Create an inteface that both types of stations must implement that ensures that they both have the following properties and methods.
// int Capacity: The number of vehicles that they can refuel at any one time.
// void Refuel(List<T> vehicles): A method to print a message to the terminal that the vehicle has been refueled. (e.g. "The white Cessna has been refueled with 200 gallons of gas") Each refueling station's Refuel() method should accept a list of vehicles that only it can process. GasStation.Refuel() should only accept a list of gas-powered vehicles. BatteryStation.Refuel() should only accept a list of electric-powered vehicles.
// In your main method, make sure you have a list of electric vehicles, and a list of gas vehicles.
// Create an instance of BatteryStation and GasStation.
// Refuel all the vehicles by sending them to the correct refueling station.

using System;
using System.Collections.Generic;

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

            List<IGasPowered> gasVehicles = new List<IGasPowered>() {
                mx410, big4x4
            };

            List<IElectric> electricVehicles = new List<IElectric>() {
                fxs, modelS
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

            GasStation gasStop = new GasStation();
            BatteryStation chargeNgo = new BatteryStation();

            gasStop.Refuel(gasVehicles);
            chargeNgo.Refuel(electricVehicles);

        }
    }
}
