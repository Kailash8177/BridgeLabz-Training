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
                Console.WriteLine("3. Search Person by City/State (UC8)");
                Console.WriteLine("4. View Persons by City (UC9)");
                Console.WriteLine("5. View Persons by State (UC9)");
                Console.WriteLine("6. Count Persons by City (UC10)");
                Console.WriteLine("7. Count Persons by State (UC10)");
                Console.WriteLine("8. Exit");




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
                        manager.ViewPersonsByCity(); // UC9
                        break;

                    case 5:
                        manager.ViewPersonsByState(); // UC9
                        break;

                    case 6:
                        manager.CountPersonsByCity(); // UC10
                        break;

                    case 7:
                        manager.CountPersonsByState(); // UC10
                        break;

                    case 8:
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
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Sort Contacts by Name (UC11)");
                Console.WriteLine("5. Back");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.AddContact();
                        break;

                    case 2:
                        utility.EditContact();
                        break;

                    case 3:
                        utility.DeleteContact();
                        break;

                    case 4:
                        utility.SortContactsByName(); // UC11
                        break;
                }

            }
            while (choice != 4);
        }
    }
}
