using System;
using System.Collections.Generic;
using System.Text;

namespace supermarket_billing_queue
{
    class Utility
    {
        static void Main()
        {
            Inventory inventory = new Inventory();
            CheckoutQueue checkout = new CheckoutQueue(inventory);

            int choice;

            do
            {
                Console.WriteLine("\n===== SmartCheckout System =====");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Process Billing");
                Console.WriteLine("3. View Queue");
                Console.WriteLine("4. View Inventory");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine() ?? "0");

                switch (choice)
                {
                    case 1:
                        AddCustomer(checkout, inventory);
                        break;

                    case 2:
                        checkout.ProcessBilling();
                        break;

                    case 3:
                        checkout.ViewQueue();
                        break;

                    case 4:
                        inventory.DisplayInventory();
                        break;

                    case 5:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 5);
        }

        static void AddCustomer(CheckoutQueue checkout, Inventory inventory)
        {
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine() ?? "";

            Customer customer = new Customer(name);

            while (true)
            {
                Console.Write("Enter item name (or 'done'): ");
                string item = Console.ReadLine() ?? "";

                if (item.ToLower() == "done")
                    break;

                if (!inventory.HasItem(item))
                {
                    Console.WriteLine("Item not available!");
                    continue;
                }

                Console.Write("Enter quantity: ");
                int qty = int.Parse(Console.ReadLine() ?? "0");

                customer.Items[item] = qty;
            }

            checkout.AddCustomer(customer);
        }
    }
}
