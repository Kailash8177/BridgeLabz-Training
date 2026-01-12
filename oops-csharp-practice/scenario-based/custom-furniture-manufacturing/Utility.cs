using System;
using System.Collections.Generic;
using System.Text;

namespace custom_furniture_manufacturing
{
    internal class Utility
    {
        public static void Main()
        {
            int[] prices =
            {
            0, 2, 5, 7, 8, 10,
            13, 17, 17, 20, 24, 30, 32
        };

            IPriceChart chart = new PriceChart(prices);
            IRodCutter cutter = new RodCutter();

            int rodLength = 12;

            // Scenario A
            Console.WriteLine(
                "Scenario A - Max Revenue: " +
                cutter.MaxRevenue(chart, rodLength));

            // Scenario B
            Console.WriteLine(
                "Scenario B - Max Revenue (Waste ≤ 2): " +
                cutter.MaxRevenueWithWaste(chart, rodLength, 2));

            // Scenario C
            CutResult result =
                cutter.BestRevenueWithMinWaste(chart, rodLength);

            Console.WriteLine(
                "Scenario C - Revenue: " +
                result.Revenue +
                ", Waste: " +
                result.Waste);
        }
    }
}
