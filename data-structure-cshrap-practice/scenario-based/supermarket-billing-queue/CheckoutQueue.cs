using System;
using System.Collections.Generic;
using System.Text;

namespace supermarket_billing_queue
{
    public class CheckoutQueue
    {
        private Queue<Customer> queue = new Queue<Customer>();
        private Inventory inventory;

        public CheckoutQueue(Inventory inventory)
        {
            this.inventory = inventory;
        }

        public void AddCustomer(Customer customer)
        {
            queue.Enqueue(customer);
            Console.WriteLine("Customer added to queue.");
        }

        public void ProcessBilling()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("No customers in queue!");
                return;
            }

            Customer customer = queue.Dequeue();
            int total = 0;

            Console.WriteLine($"\nBilling Customer: {customer.Name}");

            foreach (var item in customer.Items)
            {
                string itemName = item.Key;
                int qty = item.Value;

                if (!inventory.HasItem(itemName))
                {
                    Console.WriteLine($"{itemName} not available!");
                    continue;
                }

                if (inventory.IsInStock(itemName, qty))
                {
                    int cost = inventory.GetPrice(itemName) * qty;
                    total += cost;
                    inventory.UpdateStock(itemName, qty);

                    Console.WriteLine($"{itemName} x {qty} = {cost}");
                }
                else
                {
                    Console.WriteLine($"{itemName} OUT OF STOCK!");
                }
            }

            Console.WriteLine($"Total Bill: {total}");
        }

        public void ViewQueue()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("Queue is empty!");
                return;
            }

            Console.WriteLine("\nCustomers in Queue:");
            foreach (var c in queue)
                Console.WriteLine(c.Name);
        }
    }
}
