using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleRentalApplication
{
    public abstract class Vehicle : IRentable
    {
        protected string vehicleNumber;
        protected double ratePerDay;

        public Vehicle(string vehicleNumber, double ratePerDay)
        {
            this.vehicleNumber = vehicleNumber;
            this.ratePerDay = ratePerDay;
        }

        public abstract double CalculateRent(int Days);

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicle Number: {vehicleNumber}");
            Console.WriteLine($"Rate Per Day: {ratePerDay}");
        }
    }
}
