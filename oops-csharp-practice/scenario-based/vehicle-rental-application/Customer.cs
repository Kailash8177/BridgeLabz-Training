using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleRentalApplication
{
    public class Customer
    {
        public string Name { get; set; }

        public Customer(string name)
        {
            Name = name;
        }

        public void RentVehicle(IRentable rentable, int days)
        {
            Console.WriteLine($"Customer: {Name}");
            Console.WriteLine($"Total Rent for {days} days: {rentable.CalculateRent(days)}");
        }
    }

}
