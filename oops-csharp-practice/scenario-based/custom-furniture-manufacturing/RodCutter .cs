using System;
using System.Collections.Generic;
using System.Text;

namespace custom_furniture_manufacturing
{
    internal class RodCutter : IRodCutter
    {
        public int MaxRevenue(IPriceChart chart, int length)
        {
            if (length == 0)
                return 0;

            int max = 0;
            int maxCut = Math.Min(length, chart.MaxLength());

            for (int cut = 1; cut <= maxCut; cut++)
            {
                int revenue =
                    chart.GetPrice(cut) +
                    MaxRevenue(chart, length - cut);

                max = Math.Max(max, revenue);
            }
            return max;
        }

        // 🔹 Scenario B
        public int MaxRevenueWithWaste(
            IPriceChart chart,
            int length,
            int maxWaste)
        {
            if (length <= maxWaste)
                return 0;

            int max = 0;
            int maxCut = Math.Min(length, chart.MaxLength());

            for (int cut = 1; cut <= maxCut; cut++)
            {
                int revenue =
                    chart.GetPrice(cut) +
                    MaxRevenueWithWaste(chart, length - cut, maxWaste);

                max = Math.Max(max, revenue);
            }
            return max;
        }

        // 🔹 Scenario C
        public CutResult BestRevenueWithMinWaste(
            IPriceChart chart,
            int length)
        {
            if (length == 0)
                return new CutResult(0, 0);

            CutResult best = new CutResult(0, length);
            int maxCut = Math.Min(length, chart.MaxLength());

            for (int cut = 1; cut <= maxCut; cut++)
            {
                CutResult next =
                    BestRevenueWithMinWaste(chart, length - cut);

                int totalRevenue =
                    chart.GetPrice(cut) + next.Revenue;

                int totalWaste = next.Waste;

                if (totalRevenue > best.Revenue ||
                   (totalRevenue == best.Revenue &&
                    totalWaste < best.Waste))
                {
                    best = new CutResult(totalRevenue, totalWaste);
                }
            }
            return best;
        }
    }
}
