using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System
{
    public class Book : LibraryItem, IReservable
    {
        public Book(int id, string title, string author)
            : base(id, title, author) { }

        public override int GetLoanDuration()
        {
            return 14; // 14 days
        }

        public void ReserveItem(string borrowerName)
        {
            if (CheckAvailability())
            {
                AssignBorrower(borrowerName);
                Console.WriteLine($"Book reserved by {borrowerName}");
            }
            else
            {
                Console.WriteLine("Book is not available");
            }
        }

        public bool CheckAvailability()
        {
            return IsAvailable();
        }
    }

}
