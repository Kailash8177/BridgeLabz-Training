using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_obejct_oriented_design.object_modeling
{

    // ---------------- Product ----------------
    class Product
    {
        public string Name;
    }

    // ---------------- Order ----------------
    class Order
    {
        public Product[] Products = new Product[5];
        public int count = 0;
    }

    // ---------------- Customer ----------------
    class Customer
    {
        public string Name;

        public void PlaceOrder(Order order)
        {
            Console.WriteLine($"{Name} placed order with {order.count} products");
        }
    }

    // ---------------- Utility ----------------
    class EcommerceUtility
    {
        public static void Main()
        {
            Order order = new Order();
            order.Products[order.count++] = new Product { Name = "Laptop" };

            Customer cust = new Customer { Name = "Rahul" };
            cust.PlaceOrder(order);
        }
    }
}
