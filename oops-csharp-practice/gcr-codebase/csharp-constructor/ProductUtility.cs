using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_constructor.level_1
{
    public class ProductUtility
    {
        public static void Main()
        {
            Product p1 = new Product("Laptop", 55000);
            Product p2 = new Product("Mouse", 800);

            p1.DisplayProductDetails();
            p2.DisplayProductDetails();

            Product.DisplayTotalProducts();
        }
    }
    public class Product
    {
        // Instance variables (unique for each object)
        public string ProductName;
        public double Price;

        // Class variable (shared among all products)
        public static int TotalProducts = 0;

        // Constructor
        public Product(string productName, double price)
        {
            ProductName = productName;
            Price = price;
            TotalProducts++; // increases for every object created
        }

        // Instance method
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product: {ProductName}, Price: {Price}");
        }

        // Class method
        public static void DisplayTotalProducts()
        {
            Console.WriteLine($"Total Products Created: {TotalProducts}");
        }
    }
}
