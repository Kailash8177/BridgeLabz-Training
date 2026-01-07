using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System
{
    public class Magazine : LibraryItem, IReservable
    {
        public Magazine(int id, string title, string author)
            : base(id, title, author) { }

        public override int GetLoanDuration()
        {
            return 7; // 7 days
        }

        public void ReserveItem(string borrowerName)
        {
            if (CheckAvailability())
            {
                AssignBorrower(borrowerName);
                Console.WriteLine($"Magazine reserved by {borrowerName}");
            }
            else
            {
                Console.WriteLine("Magazine is not available");
            }
        }

        public bool CheckAvailability()
        {
            return IsAvailable();
        }
    }

}
