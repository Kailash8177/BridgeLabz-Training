using System;
using System.Collections.Generic;
using System.Text;

namespace custom_furniture_manufacturing
{
    internal interface IRodCutter
    {
        int MaxRevenue(IPriceChart chart, int length);
        int MaxRevenueWithWaste(IPriceChart chart, int length, int maxWaste);
        CutResult BestRevenueWithMinWaste(IPriceChart chart, int length);
    }
}
