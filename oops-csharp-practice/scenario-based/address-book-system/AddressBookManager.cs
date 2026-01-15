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

        //UC8 – Search Person in a City or State across Multiple Address Books
        public void SearchPersonByCityOrState()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No Address Books available.");
                return;
            }

            Console.Write("Enter City or State to search: ");
            string searchValue = Console.ReadLine();

            bool found = false;

            foreach (var entry in books)
            {
                string bookName = entry.Key;
                AddressBook book = entry.Value;

                for (int i = 0; i < book.count; i++)
                {
                    Contacts c = book.contacts[i];

                    if (c.City.Equals(searchValue, StringComparison.OrdinalIgnoreCase) ||
                        c.State.Equals(searchValue, StringComparison.OrdinalIgnoreCase))
                    {
                        found = true;

                        Console.WriteLine(
                            $"[{bookName}] {c.FirstName} {c.LastName}, " +
                            $"City: {c.City}, State: {c.State}, Phone: {c.PhoneNumber}"
                        );
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("No matching persons found.");
            }
        }
    }
}

