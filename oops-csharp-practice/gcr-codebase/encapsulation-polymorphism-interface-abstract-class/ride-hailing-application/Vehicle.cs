using System;
using System.Collections.Generic;
using System.Text;

namespace Ride_Hailing_Application
{

    public abstract class Vehicle
    {
        private int vehicleId;          // Encapsulated
        private string driverName;      // Encapsulated
        protected double ratePerKm;

        public int VehicleId
        {
            get { return vehicleId; }
            protected set { vehicleId = value; }
        }

        public string DriverName
        {
            get { return driverName; }
            protected set { driverName = value; }
        }

        protected Vehicle(int id, string driver, double rate)
        {
            VehicleId = id;
            DriverName = driver;
            ratePerKm = rate;
        }

        public void GetVehicleDetails()
        {
            Console.WriteLine($"Vehicle ID: {VehicleId}, Driver: {DriverName}, Rate/Km: ₹{ratePerKm}");
        }

        public abstract double CalculateFare(double distance);
    }

}
