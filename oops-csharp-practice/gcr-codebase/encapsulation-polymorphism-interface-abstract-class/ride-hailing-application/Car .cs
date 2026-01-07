using System;
using System.Collections.Generic;
using System.Text;

namespace Ride_Hailing_Application
{
    public class Car : Vehicle, IGPS
    {
        private string currentLocation;

        public Car(int id, string driver)
            : base(id, driver, 15) { }

        public override double CalculateFare(double distance)
        {
            return distance * ratePerKm + 50; // base charge
        }

        public string GetCurrentLocation()
        {
            return currentLocation;
        }

        public void UpdateLocation(string location)
        {
            currentLocation = location;
        }
    }

}
