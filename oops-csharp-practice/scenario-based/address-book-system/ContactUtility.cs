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
    }
}
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
    }
}
