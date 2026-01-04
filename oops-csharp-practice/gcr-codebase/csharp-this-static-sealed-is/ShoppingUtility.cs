using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_this_static_sealed_is
{
    public class ShoppingUtility
    {
        public static void Main()
        {
            object p = new Product("Laptop", 50000, 1, 9001);

            if (p is Product)
            {
                ((Product)p).Display();
            }
        }
    }
    public class Product
    {
        public static double Discount = 10;

        public readonly int ProductID;
        public string ProductName;
        public double Price;
        public int Quantity;

        public Product(string productName, double price, int quantity, int productId)
        {
            this.ProductName = productName;
            this.Price = price;
            this.Quantity = quantity;
            this.ProductID = productId;
        }

        public static void UpdateDiscount(double discount)
        {
            Discount = discount;
        }

        public void Display()
        {
            Console.WriteLine($"{ProductName} | {ProductID} | Qty:{Quantity} | Discount:{Discount}%");
        }
    }

}
