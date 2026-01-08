using System;
using System.Collections.Generic;
using System.Text;

namespace inventory_management
{

    /*
     * ItemNode represents a single inventory item.
     * Each node stores item details and a reference to the next item.
     */
    class ItemNode
    {
        public int Id;
        public string Name;
        public int Qty;
        public double Price;
        public ItemNode Next;

        // Constructor to initialize item details
        public ItemNode(int id, string name, int qty, double price)
        {
            Id = id;
            Name = name;
            Qty = qty;
            Price = price;
            Next = null;
        }
    }

    
}
