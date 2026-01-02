//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace BridgeLabzTraining
//{
//    internal class DistanceTracker
//    {
//        public static void Main(string[] args)
//        {
//            DistanceTracker tracker = new DistanceTracker();
//            tracker.TrackDistance();

//        }
//        public void TrackDistance()
//        {
//            int totalDistance = 0;
//            int stopDistance = 5;

//            string choice;

//            Console.WriteLine("Bus Route Distance Tracker Started");

//            while (true)
//            {
//                totalDistance += stopDistance;

//                Console.WriteLine("Bus reached next stop.");
//                Console.WriteLine("Distance covered so far: " + totalDistance + " km");

//                Console.Write("Do you want to get off at this stop? (yes/no): ");
//                choice = Console.ReadLine().ToLower();

//                if (choice == "yes")
//                {
//                    Console.WriteLine("Passenger got off the bus.");
//                    break;
//                }
//                else if (choice != "no" && choice != "yes")
//                {
//                    Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
//                }
//            }

//            Console.WriteLine("Total distance traveled: " + totalDistance + " km");
//            Console.WriteLine("Journey Ended ");
//        }
//    }
//}
