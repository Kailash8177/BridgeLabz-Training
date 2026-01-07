using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Food_Delivery_System
{
    public abstract class FoodItem
    {
        public string ItemName { get; protected set; }
        public double Price { get; protected set; }
        public int Quantity { get; protected set; }

        protected FoodItem(string name, double price, int quantity)
        {
            ItemName = name;
            Price = price;
            Quantity = quantity;
        }

        public void GetItemDetails()
        {
            Console.WriteLine($"Item: {ItemName}, Price: ₹{Price}, Quantity: {Quantity}");
        }

        public abstract double CalculateTotalPrice();
    }

}
