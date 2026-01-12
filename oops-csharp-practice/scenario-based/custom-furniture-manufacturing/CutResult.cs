using System;
using System.Collections.Generic;
using System.Text;

namespace custom_furniture_manufacturing
{
    internal class CutResult
    {
        public int Revenue;
        public int Waste;

        public CutResult(int revenue, int waste)
        {
            Revenue = revenue;
            Waste = waste;
        }
    }
}
