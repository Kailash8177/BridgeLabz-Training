using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleRentalApplication
{
    public class Car : Vehicle
    {
        public Car(string vehicleNumber,int day)
            : base(vehicleNumber, day)
        {
        }

        public override double CalculateRent(int days)
        {
            return (ratePerDay * days) ;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("---- Car Details ----");
            base.DisplayInfo();
        }
    }

}
