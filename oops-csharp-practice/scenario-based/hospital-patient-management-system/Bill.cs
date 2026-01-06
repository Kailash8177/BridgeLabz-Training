using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.cenario_based
{
    public class Bill
    {
        public static void PrintBill(IPayable payableEntity)
        {
            double amount = payableEntity.GenrateBill();
            Console.WriteLine($"Total Amount to be Paid: {amount}");
        }
    }
}
