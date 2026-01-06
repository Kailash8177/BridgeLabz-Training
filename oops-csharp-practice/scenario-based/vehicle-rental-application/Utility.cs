using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleRentalApplication
{
    public class Program
    {
        public static void Main()
        {
            Vehicle bike = new Bike("BIKE-101",500);
            Vehicle car = new Car("CAR-202",1000);
            Vehicle truck = new Truck("TRUCK-303",5000);

            Customer customer = new Customer("Rahul");

            bike.DisplayInfo();
            customer.RentVehicle(bike, 3);

            car.DisplayInfo();
            customer.RentVehicle(car, 2);

            truck.DisplayInfo();
            customer.RentVehicle(truck, 4);
        }
    }

}
