using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_this_static_sealed_is
{
    public class VehicleUtility
    {
        public static void Main()
        {
            object v = new Vehicle("Rohit", "Car", "UP85AB1234");

            if (v is Vehicle)
            {
                ((Vehicle)v).Display();
            }
        }
    }

    public class Vehicle
    {
        public static double RegistrationFee = 1500;

        public readonly string RegistrationNumber;
        public string OwnerName;
        public string VehicleType;

        public Vehicle(string ownerName, string vehicleType, string regNo)
        {
            this.OwnerName = ownerName;
            this.VehicleType = vehicleType;
            this.RegistrationNumber = regNo;
        }

        public static void UpdateRegistrationFee(double fee)
        {
            RegistrationFee = fee;
        }

        public void Display()
        {
            Console.WriteLine($"{OwnerName} | {VehicleType} | {RegistrationNumber} | Fee:{RegistrationFee}");
        }
    }
}
