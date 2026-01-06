using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleRentalApplication
{
    public class Bike : Vehicle
    {
        public Bike(string vehicleNumber,int day): base(vehicleNumber, day)
        {
        }
        public override double CalculateRent(int Days)
        {
            return ratePerDay * Days;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("---- Bike Details ----");
            base.DisplayInfo();
        }
    }
}
