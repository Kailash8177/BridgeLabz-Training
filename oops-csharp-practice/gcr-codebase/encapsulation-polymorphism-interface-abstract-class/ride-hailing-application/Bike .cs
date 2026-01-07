using System;
using System.Collections.Generic;
using System.Text;

namespace Ride_Hailing_Application
{
    public class Bike : Vehicle, IGPS
    {
        private string currentLocation;

        public Bike(int id, string driver)
            : base(id, driver, 8) { }

        public override double CalculateFare(double distance)
        {
            return distance * ratePerKm; // no base charge
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
