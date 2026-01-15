using System;
using System.Collections.Generic;
using System.Text;

namespace address_book_system
{
    internal class ContactMenu
    {

        private ContactUtility utility;
        public ContactMenu()
        {
            AddressBook addressBook = new AddressBook(1);
            utility = new ContactUtility(addressBook);
            Menu();
        }
        public void Menu()
        {
            int choice;

            do
            {
                Console.WriteLine("\n 1. Create and Add New Address ");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.AddContact();
                        Console.WriteLine("Address Book operations completed.");
                        break;

                    case 2:
                        utility.EditContact();
                        break;

                    case 3:
                        Console.WriteLine("Exiting the application.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            while (choice != 3);
        }
    }
}
