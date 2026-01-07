using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental_System
{
    public abstract class Vehicle
    {
        public string VehicleNumber { get; protected set; }
        public string Type { get; protected set; }
        public double RentalRate { get; protected set; }

        protected Vehicle(string vehicleNumber, string type, double rentalRate)
        {
            VehicleNumber = vehicleNumber;
            Type = type;
            RentalRate = rentalRate;
        }

        public abstract double CalculateRentalCost(int days);
    }

}
