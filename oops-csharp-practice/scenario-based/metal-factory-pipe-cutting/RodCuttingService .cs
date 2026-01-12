using System;
using System.Collections.Generic;
using System.Text;

namespace metal_factory_pipe_cutting
{
    internal class RodCuttingService : IRodCutting
    {
        public CutResult SingleCut(Rod rod, PriceChart priceChart)
        {
            int maxRevenue = 0;
            int bestPart1 = 0;
            int bestPart2 = 0;
            for (int i = 0; i <= rod.Length/2; i++)
            {
                int a = i;
                int b = rod.Length - i;

                int revenue = priceChart.GetPrice(a) + priceChart.GetPrice(b);

                if (revenue > maxRevenue)
                {
                    maxRevenue = revenue;
                    bestPart1 = a;
                    bestPart2 = b;
                }

            }
            return new CutResult(bestPart1, bestPart2, maxRevenue);
        }
        public int GetRevenueWithOutCut(Rod rod, PriceChart priceChart)
        {
            return priceChart.GetPrice(rod.Length);
        }
    }
}
