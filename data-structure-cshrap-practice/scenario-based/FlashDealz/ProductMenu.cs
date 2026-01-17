using System;
using System.Collections.Generic;
using System.Text;

namespace FlashDealz
{
    internal class ProductMenu
    {

        public ProductMenu()
        {
            Menu();
        }
        public void Menu()
        {
            IProductOperations product = new ProductUtility();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- FlashDealz Menu ---");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Display Products");
                Console.WriteLine("3. Sort Products by Discount");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Product Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Discount (%): ");
                        int discount = Convert.ToInt32(Console.ReadLine());

                        product.AddProduct(name, discount);
                        Console.WriteLine("Product added successfully!");
                        break;

                    case 2:
                        product.DisplayProducts();
                        break;

                    case 3:
                        product.SortByDiscount();
                        Console.WriteLine("Products sorted by discount (High -> Low).");
                        break;

                    case 4:
                        exit = true;
                        Console.WriteLine("Exiting application...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            }
        }
    }
}
