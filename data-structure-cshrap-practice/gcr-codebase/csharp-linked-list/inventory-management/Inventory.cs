using System;
using System.Collections.Generic;
using System.Text;

namespace inventory_management
{

    /*
     * Inventory class manages items using a Singly Linked List.
     * Items are added at the beginning of the list.
     */
    class Inventory
    {
        private ItemNode head; // Points to the first item

        // Add item at the beginning (O(1) operation)
        public void AddItem(int id, string name, int qty, double price)
        {
            ItemNode node = new ItemNode(id, name, qty, price);

            // New node points to current head
            node.Next = head;

            // Head is updated to new node
            head = node;
        }

        // Calculate total inventory value
        public double TotalValue()
        {
            double sum = 0;
            ItemNode temp = head;

            // Traverse the list and calculate total value
            while (temp != null)
            {
                sum += temp.Price * temp.Qty;
                temp = temp.Next;
            }

            return sum;
        }

        // Display all items
        public void DisplayItems()
        {
            if (head == null)
            {
                Console.WriteLine("Inventory is empty");
                return;
            }

            ItemNode temp = head;
            Console.WriteLine("\nInventory Items:");
            while (temp != null)
            {
                Console.WriteLine($"ID: {temp.Id}, Name: {temp.Name}, Qty: {temp.Qty}, Price: {temp.Price}");
                temp = temp.Next;
            }
        }
    }

}
