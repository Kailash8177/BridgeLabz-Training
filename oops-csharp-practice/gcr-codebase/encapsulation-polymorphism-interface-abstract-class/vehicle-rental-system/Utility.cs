using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental_System
{
    public class Utility
    {
        public static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("CAR101", 1500, "CAR-INS-999"),
            new Bike("BIKE202", 500, "BIKE-INS-888"),
            new Truck("TRUCK303", 3000, "TRUCK-INS-777")
        };

            int days = 3;

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine($"Vehicle Type: {vehicle.Type}");
                Console.WriteLine($"Rental Cost for {days} days: ₹{vehicle.CalculateRentalCost(days)}");

                if (vehicle is IInsurable insurable)
                {
                    Console.WriteLine($"Insurance Cost: ₹{insurable.CalculateInsurance()}");
                    Console.WriteLine(insurable.GetInsuranceDetails());
                }

                Console.WriteLine("----------------------------------");
            }
        }
    }
}
