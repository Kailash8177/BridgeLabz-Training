using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_constructor.level_1
{
    public class VehicleUtility
    {

        public static void Main()
        {
            Vehicle.UpdateRegistrationFee(2000);

            Vehicle v = new Vehicle("Rahul", "Bike");
            v.DisplayVehicleDetails();
        }
    }

    public class Vehicle
    {
        // Instance variables
        public string OwnerName;
        public string VehicleType;

        // Class variable
        public static double RegistrationFee = 1500;

        public Vehicle(string ownerName, string vehicleType)
        {
            OwnerName = ownerName;
            VehicleType = vehicleType;
        }

        // Instance method
        public void DisplayVehicleDetails()
        {
            Console.WriteLine($"{OwnerName} owns a {VehicleType}. Fee: {RegistrationFee}");
        }

        // Class method
        public static void UpdateRegistrationFee(double newFee)
        {
            RegistrationFee = newFee;
        }
    }
}
