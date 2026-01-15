using System;
using System.Collections.Generic;
using System.Text;

namespace address_book_system
{
    internal class AddressBook
    {
        public Contacts[] contacts;
        public int count;

        public AddressBook(int n)
        {
            contacts = new Contacts[n];
            count = 0;
        }
    }
}
