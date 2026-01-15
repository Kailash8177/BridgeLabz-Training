using System;
using System.Collections.Generic;
using System.Text;

namespace address_book_system
{
    internal class ContactUtility
    {
        private AddressBook addressBook;

        public ContactUtility(AddressBook addressBook)
        {
            this.addressBook = addressBook;
        }

        // UC2

        public void AddContact()
        {
            if (addressBook.count >= addressBook.contacts.Length)
            {
                Console.WriteLine("Address Book is full. Cannot add more contacts.");
                return;
            }
            Contacts contacts = new Contacts();

            Console.WriteLine("Enter First Name:");
            contacts.FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            contacts.LastName = Console.ReadLine();

            Console.WriteLine("Enter the address");
            contacts.Address = Console.ReadLine();

            Console.WriteLine("Enter City Name:");
            contacts.City = Console.ReadLine();

            Console.WriteLine("Enter state Name:");
            contacts.State = Console.ReadLine();

            Console.WriteLine("Enter Zip Number:");
            contacts.Zip = Console.ReadLine();
            Console.WriteLine("Enter Phone Number:");
            contacts.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Email Address:");
            contacts.Email = Console.ReadLine();

            addressBook.contacts[addressBook.count] = contacts;
            addressBook.count++;
        }

        //UC3
        public void EditContact()
        {
            if (addressBook.count == 0)
            {
                Console.WriteLine("No contacts available to edit.");
                return;
            }

            Console.WriteLine("\n Enter the First Name of the contact to edit:");
            string firstNameToEdit = Console.ReadLine().ToLower();

            bool contactFound = false;

            for (int i = 0; i < addressBook.count; i++)
            {

                if (addressBook.contacts[i].FirstName.ToLower().Equals(firstNameToEdit))
                {
                    contactFound = true;

                    Contacts c = addressBook.contacts[i];

                    Console.WriteLine("\n Enter new  the Details:");

                    Console.Write("New Address: ");
                    c.Address = Console.ReadLine();

                    Console.Write("New City: ");
                    c.City = Console.ReadLine();

                    Console.Write("New State: ");
                    c.State = Console.ReadLine();

                    Console.Write("New Zip: ");
                    c.Zip = Console.ReadLine();

                    Console.Write("New Phone: ");
                    c.PhoneNumber = Console.ReadLine();

                    Console.Write("New Email: ");
                    c.Email = Console.ReadLine();

                    Console.WriteLine("Contact Updated Successfully!");
                    break;
                }

            }
            if (!contactFound)
            {
                Console.WriteLine("Contact not found with given name.");
            }
        }


        //UC4
        public void DeleteContact()
        {
            if (addressBook.count == 0)
            {
                Console.WriteLine("No contacts available to delete.");
                return;
            }


            Console.WriteLine("\n Enter the First Name of the contact to delete:");
            string firstNameToDelete = Console.ReadLine().ToLower();


            int deleteIndex = -1;


            for (int i = 0; i < addressBook.count; i++)
            {
                if (addressBook.contacts[i].FirstName.Equals(firstNameToDelete, StringComparison.OrdinalIgnoreCase)
)
                {
                    deleteIndex = i;
                    break;
                }
            }
            if (deleteIndex == -1)
            {
                Console.WriteLine("Contact not found with given name.");
                return;
            }

            for (int i = deleteIndex; i < addressBook.count - 1; i++)
            {
                addressBook.contacts[i] = addressBook.contacts[i + 1];
            }
            addressBook.contacts[addressBook.count - 1] = null;
            addressBook.count--;

            Console.WriteLine("Contact Deleted Successfully!");
        }
    }
}
