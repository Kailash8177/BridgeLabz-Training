using System;
using System.Collections.Generic;
using System.Text;

namespace address_book_system
{
    internal class AddressBookManager
    {
        //UC6 – Manage Multiple Address Books
        private Dictionary<string, AddressBook> books =
            new Dictionary<string, AddressBook>();

        public void CreateBook()
        {
            Console.Write("Enter Address Book Name: ");
            string name = Console.ReadLine();

            if (books.ContainsKey(name))
            {
                Console.WriteLine("Address Book already exists.");
                return;
            }

            Console.Write("Enter max number of contacts: ");
            int size = int.Parse(Console.ReadLine());

            books[name] = new AddressBook(size);
            Console.WriteLine($"Address Book '{name}' created.");
        }

        public AddressBook GetBook(string name)
        {
            if (!books.ContainsKey(name))
            {
                Console.WriteLine("Address Book not found.");
                return null;
            }
            return books[name];
        }

        public void ShowBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No Address Books available.");
                return;
            }

            Console.WriteLine("Available Address Books:");
            foreach (var key in books.Keys)
                Console.WriteLine("- " + key);
        }
    }
}

