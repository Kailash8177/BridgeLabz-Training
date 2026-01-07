using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management_System
{
    public abstract class LibraryItem
    {
        private string borrowerName;   // Encapsulated (secured)
        private bool isAvailable = true;

        public int ItemId { get; protected set; }
        public string Title { get; protected set; }
        public string Author { get; protected set; }

        protected LibraryItem(int itemId, string title, string author)
        {
            ItemId = itemId;
            Title = title;
            Author = author;
        }

        protected void AssignBorrower(string name)
        {
            borrowerName = name;
            isAvailable = false;
        }

        protected void ReleaseItem()
        {
            borrowerName = null;
            isAvailable = true;
        }

        protected bool IsAvailable()
        {
            return isAvailable;
        }

        public void GetItemDetails()
        {
            Console.WriteLine($"ID: {ItemId}, Title: {Title}, Author: {Author}");
        }

        public abstract int GetLoanDuration();
    }

}
