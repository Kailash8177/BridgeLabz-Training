using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_inheritance
{
    class Vehicle
    {
        public int MaxSpeed;
        public string FuelType;

        // Virtual method
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Speed: {MaxSpeed}, Fuel: {FuelType}");
        }
    }

    // ---------------- Car Class ----------------
    class Car : Vehicle
    {
        public int SeatCapacity;

        public override void DisplayInfo()
        {
            Console.WriteLine(
                $"Car → Speed: {MaxSpeed}, Fuel: {FuelType}, Seats: {SeatCapacity}"
            );
        }
    }

    // ---------------- Truck Class ----------------
    class Truck : Vehicle
    {
        public int PayloadCapacity;

        public override void DisplayInfo()
        {
            Console.WriteLine(
                $"Truck → Speed: {MaxSpeed}, Fuel: {FuelType}, Payload: {PayloadCapacity} kg"
            );
        }
    }

    // ---------------- Motorcycle Class ----------------
    class Motorcycle : Vehicle
    {
        public bool HasSidecar;

        public override void DisplayInfo()
        {
            Console.WriteLine(
                $"Motorcycle → Speed: {MaxSpeed}, Fuel: {FuelType}, Sidecar: {HasSidecar}"
            );
        }
    }

    // ----------------Main Class ----------------
    class VehicleUtility
    {
        public static void Main()
        {
            // Vehicle type array holding different objects
            Vehicle[] vehicles =
            {
            new Car { MaxSpeed = 180, FuelType = "Petrol", SeatCapacity = 5 },
            new Truck { MaxSpeed = 120, FuelType = "Diesel", PayloadCapacity = 5000 },
            new Motorcycle { MaxSpeed = 150, FuelType = "Petrol", HasSidecar = false }
        };

            // Dynamic method dispatch
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.DisplayInfo();
            }
        }
    }
}
