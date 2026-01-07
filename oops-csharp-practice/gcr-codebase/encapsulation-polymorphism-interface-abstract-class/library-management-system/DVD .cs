using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System
{
    public class DVD : LibraryItem, IReservable
    {
        public DVD(int id, string title, string author)
            : base(id, title, author) { }

        public override int GetLoanDuration()
        {
            return 3; // 3 days
        }

        public void ReserveItem(string borrowerName)
        {
            if (CheckAvailability())
            {
                AssignBorrower(borrowerName);
                Console.WriteLine($"DVD reserved by {borrowerName}");
            }
            else
            {
                Console.WriteLine("DVD is not available");
            }
        }

        public bool CheckAvailability()
        {
            return IsAvailable();
        }
    }

}
