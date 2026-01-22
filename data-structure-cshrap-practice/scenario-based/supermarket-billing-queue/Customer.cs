using System;
using System.Collections.Generic;
using System.Text;

namespace supermarket_billing_queue
{
    public class Customer
    {
        public string Name;
        public Dictionary<string, int> Items;

        public Customer(string name)
        {
            Name = name;
            Items = new Dictionary<string, int>();
        }
    }
}
