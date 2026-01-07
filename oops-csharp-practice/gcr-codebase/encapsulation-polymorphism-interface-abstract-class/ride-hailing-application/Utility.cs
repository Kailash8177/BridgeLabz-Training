using System;
using System.Collections.Generic;
using System.Text;

namespace Ride_Hailing_Application
{
    public class Utility
    {
        public static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car(101, "Rohit"),
            new Bike(202, "Amit"),
            new Auto(303, "Suresh")
        };

            double distance = 12.5;

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.GetVehicleDetails();
                Console.WriteLine($"Fare for {distance} km: ₹{vehicle.CalculateFare(distance)}");

                if (vehicle is IGPS gps)
                {
                    gps.UpdateLocation("City Center");
                    Console.WriteLine($"Current Location: {gps.GetCurrentLocation()}");
                }

                Console.WriteLine("----------------------------------");
            }
        }
    }
}
