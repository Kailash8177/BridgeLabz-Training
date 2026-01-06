using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleRentalApplication
{
    public class Truck : Vehicle
    {
        public Truck(string vehicleNumber,int day)
            : base(vehicleNumber, day)
        {
        }

        public override double CalculateRent(int days)
        {
            return (ratePerDay * days);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("---- Truck Details ----");
            base.DisplayInfo();
        }
    }

}
