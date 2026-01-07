using System;
using System.Collections.Generic;
using System.Text;

namespace Ride_Hailing_Application
{
    public class Auto : Vehicle, IGPS
    {
        private string currentLocation;

        public Auto(int id, string driver)
            : base(id, driver, 10) { }

        public override double CalculateFare(double distance)
        {
            return (distance * ratePerKm) + 20; // small base charge
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
