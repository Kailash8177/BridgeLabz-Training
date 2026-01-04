using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_inheritance
{
    // ---------------- Base Class ----------------
    class Order
    {
        public int OrderId;
        public string OrderDate;

        public virtual string GetOrderStatus()
        {
            return "Order Placed";
        }
    }

    // ---------------- Intermediate Class ----------------
    class ShippedOrder : Order
    {
        public string TrackingNumber;

        public override string GetOrderStatus()
        {
            return "Order Shipped";
        }
    }

    // ---------------- Final Child Class ----------------
    class DeliveredOrder : ShippedOrder
    {
        public string DeliveryDate;

        public override string GetOrderStatus()
        {
            return "Order Delivered";
        }
    }

    // ---------------- Utility Class ----------------
    class OrderUtility
    {
        public static void Main()
        {
            DeliveredOrder order = new DeliveredOrder
            {
                OrderId = 5001,
                OrderDate = "01-Jan-2026",
                TrackingNumber = "TRK12345",
                DeliveryDate = "05-Jan-2026"
            };

            Console.WriteLine(order.GetOrderStatus());
        }
    }
}
