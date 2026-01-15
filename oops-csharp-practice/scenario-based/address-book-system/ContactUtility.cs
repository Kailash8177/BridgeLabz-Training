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

        // UC2 + UC6 : Add Contact (ALL DETAILS)
        public void AddContact()
        {
            if (addressBook.count >= addressBook.contacts.Length)
            {
                Console.WriteLine("Address Book is full.");
                return;
            }

            Contacts c = new Contacts();

            Console.Write("First Name: ");
            c.FirstName = Console.ReadLine();

            Console.Write("Last Name: ");
            c.LastName = Console.ReadLine();

            // UC6 – Prevent Duplicate
            //if (IsDuplicate(c.FirstName, c.LastName))
            //{
            //    Console.WriteLine("Duplicate contact found.");
            //    return;
            //}

            Console.Write("Address: ");
            c.Address = Console.ReadLine();

            Console.Write("City: ");
            c.City = Console.ReadLine();

            Console.Write("State: ");
            c.State = Console.ReadLine();

            Console.Write("Zip: ");
            c.Zip = Console.ReadLine();

            Console.Write("Phone Number: ");
            c.PhoneNumber = Console.ReadLine();

            Console.Write("Email: ");
            c.Email = Console.ReadLine();

            addressBook.contacts[addressBook.count++] = c;
            Console.WriteLine("Contact added successfully.");
        }

        // UC3 – Edit Contact by Name (NO CHANGE IN CONCEPT)
        public void EditContact()
        {
            if (addressBook.count == 0)
            {
                Console.WriteLine("No contacts available.");
                return;
            }

            Console.Write("Enter First Name to edit: ");
            string name = Console.ReadLine();

            for (int i = 0; i < addressBook.count; i++)
            {
                if (addressBook.contacts[i].FirstName
                    .Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Contacts c = addressBook.contacts[i];

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

                    Console.WriteLine("Contact updated successfully.");
                    return;
                }
            }

            Console.WriteLine("Contact not found.");
        }

        // UC4 – Delete Contact (UNCHANGED)
        public void DeleteContact()
        {
            Console.Write("Enter First Name to delete: ");
            string name = Console.ReadLine();

            for (int i = 0; i < addressBook.count; i++)
            {
                if (addressBook.contacts[i].FirstName
                    .Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    for (int j = i; j < addressBook.count - 1; j++)
                        addressBook.contacts[j] = addressBook.contacts[j + 1];

                    addressBook.contacts[--addressBook.count] = null;
                    Console.WriteLine("Contact deleted.");
                    return;
                }
            }
            Console.WriteLine("Contact not found.");
        }

        //// UC6 – Duplicate Check (UNCHANGED)
        //private bool IsDuplicate(string firstName, string lastName)
        //{
        //    for (int i = 0; i < addressBook.count; i++)
        //    {
        //        if (addressBook.contacts[i].FirstName
        //                .Equals(firstName, StringComparison.OrdinalIgnoreCase)
        //            &&
        //            addressBook.contacts[i].LastName
        //                .Equals(lastName, StringComparison.OrdinalIgnoreCase))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
    }
}
