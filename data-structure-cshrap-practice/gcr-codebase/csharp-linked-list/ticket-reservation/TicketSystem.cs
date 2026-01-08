using System;
using System.Collections.Generic;
using System.Text;

namespace ticket_reservation
{

    /*
     * TicketSystem manages tickets using a Circular Singly Linked List.
     * The last ticket always points back to the head.
     */
    class TicketSystem
    {
        private TicketNode head; // Points to the first ticket

        // Add ticket at the end of circular list
        public void AddTicket(int id, string cust)
        {
            TicketNode node = new TicketNode(id, cust);

            // If list is empty
            if (head == null)
            {
                head = node;
                node.Next = head; // Circular link
                return;
            }

            // Traverse to last node
            TicketNode temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }

            // Insert new ticket
            temp.Next = node;
            node.Next = head;
        }

        // Count total number of tickets
        public int CountTickets()
        {
            if (head == null)
                return 0;

            int count = 0;
            TicketNode temp = head;

            // Traverse circular list once
            do
            {
                count++;
                temp = temp.Next;
            }
            while (temp != head);

            return count;
        }

        // Display all tickets
        public void DisplayTickets()
        {
            if (head == null)
            {
                Console.WriteLine("No tickets available");
                return;
            }

            TicketNode temp = head;
            Console.WriteLine("\nTickets:");
            do
            {
                Console.WriteLine($"Ticket ID: {temp.TicketId}, Customer: {temp.Customer}");
                temp = temp.Next;
            }
            while (temp != head);
        }
    }
}
