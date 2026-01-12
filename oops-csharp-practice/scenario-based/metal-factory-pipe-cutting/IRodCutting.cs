using System;
using System.Collections.Generic;
using System.Text;

namespace metal_factory_pipe_cutting
{
    internal interface IRodCutting
    {
        CutResult SingleCut(Rod rod,PriceChart priceChart);
        int GetRevenueWithOutCut(Rod rod,PriceChart priceChart);
    }
}
