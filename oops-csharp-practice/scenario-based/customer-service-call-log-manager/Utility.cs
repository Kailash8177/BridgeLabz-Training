using System;
using System.Collections.Generic;
using System.Text;

namespace Customer_Service_Call_Log_Manager
{
    public class Utility
    {

        public static void Main()
        {
            Console.WriteLine("Enter the number of CallLog");
            int maxLogs = int.Parse(Console.ReadLine());

            maxLogs = maxLogs > 0 ? maxLogs : 10;

            Manager manager = new Manager(maxLogs);

            // Sample data

            for (int i = 0; i < maxLogs; i++)
            {
                Console.WriteLine($"Enter details for CallLog {i + 1}:");

                Console.Write("Phone Number: ");
                string phoneNumber = Console.ReadLine();

                Console.Write("Message: ");
                string message = Console.ReadLine();

                DateTime timestamp = DateTime.Now;

                manager.AddCallLog(phoneNumber, message, timestamp);
            }

            //Search by KeyWord

            Console.Write("\nEnter keyword to search: ");
            string keyword = Console.ReadLine();
            manager.SearchByKeyword(keyword);

            // Filter by time

            Console.WriteLine("Please enter the number of past hours to display call logs:");
            int time = int.Parse(Console.ReadLine());

            DateTime startTime = DateTime.Now.AddHours((-time));
            DateTime endTime = DateTime.Now;

            manager.FilterByTime(startTime, endTime);
        }
    }
}
