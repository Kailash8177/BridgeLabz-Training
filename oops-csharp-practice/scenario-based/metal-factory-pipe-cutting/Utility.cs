using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace metal_factory_pipe_cutting
{
    internal class Utility
    {
        public static void Main()
        {
            Console.WriteLine("Enter the Length of the Rod:");
            int rodLength = int.Parse(Console.ReadLine());

            Rod rod = new Rod(rodLength);
            PriceChart priceChart = new PriceChart(rodLength);

            for (int i = 1; i <= rodLength; i++)
            {
                Console.WriteLine($"Enter the price for length {i}:");
                priceChart.SetPrice(i, int.Parse(Console.ReadLine()));
            }

            priceChart.DisplayPrices();

            IRodCutting service = new RodCuttingService();

            int choice;
            do
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Scenario A - Optimized Single Cut");
                Console.WriteLine("2. Scenario B - Custom Price Update");
                Console.WriteLine("3. Scenario C - No Optimization");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n--- Scenario A ---");
                        service.SingleCut(rod, priceChart).Display();
                        break;

                    case 2:
                        Console.WriteLine("\n--- Scenario B ---");
                        Console.Write("Enter custom length: ");
                        int length = int.Parse(Console.ReadLine());

                        Console.Write("Enter new price: ");
                        int price = int.Parse(Console.ReadLine());

                        priceChart.SetPrice(length, price);
                        service.SingleCut(rod, priceChart).Display();
                        break;

                    case 3:
                        Console.WriteLine("\n--- Scenario C ---");
                        int revenue =
                            service.GetRevenueWithOutCut(rod, priceChart);
                        Console.WriteLine($"Revenue without cut = {revenue}");
                        break;

                    case 0:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 0);
        }
    }
}
