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
                Console.WriteLine("\n1. Create and Add New Address ");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Exit");
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
                        utility.DeleteContact();
                        break;

                    case 4:
                        Console.WriteLine("Exiting the application.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            while (choice != 4);
        }
    }
}
