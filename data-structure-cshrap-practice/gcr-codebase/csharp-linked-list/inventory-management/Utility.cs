using System;
using System.Collections.Generic;
using System.Text;

namespace inventory_management
{
   /*
 * Main class: Takes user input and controls inventory operations
 */
    class Utility
    {
        public static void Main()
        {
            Inventory inventory = new Inventory();
            int choice;

            do
            {
                Console.WriteLine("\n--- Inventory Management System ---");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Display Items");
                Console.WriteLine("3. Calculate Total Inventory Value");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Item ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Item Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Quantity: ");
                        int qty = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Price: ");
                        double price = Convert.ToDouble(Console.ReadLine());

                        inventory.AddItem(id, name, qty, price);
                        Console.WriteLine("Item added successfully");
                        break;

                    case 2:
                        inventory.DisplayItems();
                        break;

                    case 3:
                        double total = inventory.TotalValue();
                        Console.WriteLine($"Total Inventory Value = ₹{total}");
                        break;

                    case 4:
                        Console.WriteLine("Exiting Inventory System...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice != 4);
        }
    }
}
