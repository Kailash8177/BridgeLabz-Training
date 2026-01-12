using System;
using System.Collections.Generic;
using System.Text;

namespace custom_furniture_manufacturing
{
    class PriceChart : IPriceChart
    {
        private int[] prices;

        public PriceChart(int[] prices)
        {
            this.prices = prices;
        }

        public int GetPrice(int length)
        {
            if (length < prices.Length)
                return prices[length];
            return 0;
        }

        public int MaxLength()
        {
            return prices.Length - 1;
        }
    }

}
