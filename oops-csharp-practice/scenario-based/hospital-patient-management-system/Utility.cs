using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.cenario_based
{
    public class Utility
    {
        public static void Main()
        {
            Patient p1 = new InPatient(101, "Rahul", 30, 5, 2000);
            Patient p2 = new OutPatient(102, "Amit", 25, 500);

            Doctor doctor = new Doctor(1, "Dr. Sharma", "Cardiology");

            doctor.DisplayInfo();

            p1.DisplayInfo();   // Calls InPatient version
            p2.DisplayInfo();   // Calls OutPatient version

            Bill.PrintBill(p1);
            Bill.PrintBill(p2);
        }
    }
}
