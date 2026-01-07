using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System
{
    public class Utility
    {
        public static void Main()
        {
            List<LibraryItem> items = new List<LibraryItem>
        {
            new Book(1, "Clean Code", "Robert C. Martin"),
            new Magazine(2, "Tech Monthly", "Editorial Team"),
            new DVD(3, "Inception", "Christopher Nolan")
        };

            foreach (LibraryItem item in items)
            {
                item.GetItemDetails();
                Console.WriteLine($"Loan Duration: {item.GetLoanDuration()} days");

                if (item is IReservable reservable)
                {
                    Console.WriteLine($"Available: {reservable.CheckAvailability()}");
                    reservable.ReserveItem("Aman");
                }

                Console.WriteLine("--------------------------------");
            }
        }

    }
}
