using System;
using System.Collections.Generic;
using System.Text;

namespace ticket_reservation
{

    /*
     * TicketNode represents a single ticket in the system.
     * Each node stores ticket details and a reference to the next ticket.
     */
    class TicketNode
    {
        public int TicketId;
        public string Customer;
        public TicketNode Next;

        // Constructor to initialize ticket details
        public TicketNode(int id, string cust)
        {
            TicketId = id;
            Customer = cust;
            Next = null;
        }
    }
}
