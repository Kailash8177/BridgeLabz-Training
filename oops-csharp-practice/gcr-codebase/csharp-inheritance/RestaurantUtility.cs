using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_inheritance
{
    interface Worker
    {
        void PerformDuties();
    }

    // ---------------- Superclass ----------------
    class Person
    {
        public string Name;
        public int Id;
    }

    // ---------------- Chef ----------------
    class Chef : Person, Worker
    {
        public void PerformDuties()
        {
            Console.WriteLine("Chef cooks food");
        }
    }

    // ---------------- Waiter ----------------
    class Waiter : Person, Worker
    {
        public void PerformDuties()
        {
            Console.WriteLine("Waiter serves food");
        }
    }

    // ---------------- Utility Class ----------------
    class RestaurantUtility
    {
        public static void Main()
        {
            Worker chef = new Chef();
            Worker waiter = new Waiter();

            chef.PerformDuties();
            waiter.PerformDuties();
        }
    }

}
