using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_constructor.level_1
{
    public class CarRentalUtility
    {
        public static void Main()
        {
            CarRental cr = new CarRental("Karan", "Swift", 4);
            Console.WriteLine("Total Cost: " + cr.CalculateTotalCost());
        }
    }
    public class CarRental
    {
        public string CustomerName;
        public string CarModel;
        public int RentalDays;

        private const int COST_PER_DAY = 1200;

        public CarRental(string customerName, string carModel, int rentalDays)
        {
            CustomerName = customerName;
            CarModel = carModel;
            RentalDays = rentalDays;
        }

        public int CalculateTotalCost()
        {
            return RentalDays * COST_PER_DAY;
        }
    }
}
