using System;
using System.Collections.Generic;
using System.Text;

namespace address_book_system
{
    internal class ContactMenu
    {
        private AddressBookManager manager = new AddressBookManager();

        public ContactMenu()
        {
            Menu();
        }

        public void Menu()
        {
            int choice;
            do
            {
                Console.WriteLine("1. Create Address Book");
                Console.WriteLine("2. Select Address Book");
                Console.WriteLine("3. Search Person by City/State");
                Console.WriteLine("4. Exit");


                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        manager.CreateBook();
                        break;

                    case 2:
                        manager.ShowBooks();
                        Console.Write("Enter Address Book Name: ");
                        string name = Console.ReadLine();

                        AddressBook book = manager.GetBook(name);
                        if (book != null)
                        {
                            ContactUtility utility =
                                new ContactUtility(book);
                            AddressBookMenu(utility);
                        }
                        break;
                    case 3:
                        manager.SearchPersonByCityOrState();
                        break;

                    case 4:
                        Console.WriteLine("Exiting...");
                        break;
                }
            }
            while (choice != 4);
        }

        private void AddressBookMenu(ContactUtility utility)
        {
            int choice;
            do
            {
                Console.WriteLine("\n1. Add Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Back");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: utility.AddContact(); break;
                    case 2: utility.EditContact(); break;
                    case 3: utility.DeleteContact(); break;
                }
            }
            while (choice != 4);
        }
    }
}
