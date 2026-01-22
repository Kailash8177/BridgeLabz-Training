using System;
using System.Collections.Generic;
using System.Text;

namespace ambulance_route
{

    class AmbulanceRoute
    {
        // Node of Circular Linked List
        class UnitNode
        {
            public string UnitName;
            public bool IsAvailable;
            public UnitNode Next;

            public UnitNode(string name, bool available)
            {
                UnitName = name;
                IsAvailable = available;
                Next = null;
            }
        }

        UnitNode head = null;

        // Add hospital unit
        public void AddUnit(string name, bool available)
        {
            UnitNode newNode = new UnitNode(name, available);

            if (head == null)
            {
                head = newNode;
                newNode.Next = head;
                return;
            }

            UnitNode temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            temp.Next = newNode;
            newNode.Next = head;
        }

        // Redirect ambulance to nearest available unit
        public void RedirectPatient()
        {
            if (head == null)
            {
                Console.WriteLine("No hospital units available.");
                return;
            }

            UnitNode temp = head;

            do
            {
                if (temp.IsAvailable)
                {
                    Console.WriteLine("Patient redirected to: " + temp.UnitName);
                    return;
                }
                Console.WriteLine(temp.UnitName + " busy. Moving to next unit...");
                temp = temp.Next;

            } while (temp != head);

            Console.WriteLine("No available units at the moment!");
        }

        // Remove unit under maintenance
        public void RemoveUnit(string unitName)
        {
            if (head == null) return;

            UnitNode current = head;
            UnitNode prev = null;

            do
            {
                if (current.UnitName == unitName)
                {
                    if (current == head)
                    {
                        UnitNode last = head;
                        while (last.Next != head)
                            last = last.Next;

                        head = head.Next;
                        last.Next = head;
                    }
                    else
                    {
                        prev.Next = current.Next;
                    }

                    Console.WriteLine(unitName + " removed (Under Maintenance).");
                    return;
                }

                prev = current;
                current = current.Next;

            } while (current != head);
        }

        // Display all units
        public void DisplayUnits()
        {
            if (head == null) return;

            UnitNode temp = head;
            Console.WriteLine("\nHospital Units:");
            do
            {
                Console.WriteLine(temp.UnitName + " | Available: " + temp.IsAvailable);
                temp = temp.Next;
            } while (temp != head);
        }

        // Main Method
        static void Main()
        {
            AmbulanceRoute route = new AmbulanceRoute();

            route.AddUnit("Emergency", false);
            route.AddUnit("Radiology", false);
            route.AddUnit("Surgery", true);
            route.AddUnit("ICU", false);

            route.DisplayUnits();

            Console.WriteLine("\nAmbulance arriving.");
            route.RedirectPatient();

            route.RemoveUnit("Radiology");

            route.DisplayUnits();

            Console.WriteLine("\nNew patient arriving");
            route.RedirectPatient();
        }
    }
}
