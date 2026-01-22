using System;
using System.Collections.Generic;
using System.Text;

namespace supermarket_billing_queue
{
    public class Inventory
    {
        private Dictionary<string, (int price, int stock)> items =
            new Dictionary<string, (int, int)>()
            {
                { "Milk", (50, 20) },
                { "Bread", (30, 15) },
                { "Rice", (60, 25) },
                { "Sugar", (45, 10) }
            };

        public bool HasItem(string item)
        {
            return items.ContainsKey(item);
        }

        public bool IsInStock(string item, int qty)
        {
            return items[item].stock >= qty;
        }

        public int GetPrice(string item)
        {
            return items[item].price;
        }

        public void UpdateStock(string item, int qty)
        {
            var data = items[item];
            items[item] = (data.price, data.stock - qty);
        }

        public void DisplayInventory()
        {
            Console.WriteLine("\n--- Inventory ---");
            foreach (var item in items)
            {
                Console.WriteLine(
                    $"{item.Key} | Price: ₹{item.Value.price} | Stock: {item.Value.stock}");
            }
        }
    }
}
