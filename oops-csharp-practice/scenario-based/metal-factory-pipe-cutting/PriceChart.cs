using System;
using System.Collections.Generic;
using System.Text;

namespace metal_factory_pipe_cutting
{
    internal class PriceChart
    {
        private  int [] prices;

        public PriceChart(int rodLength)
        {
            prices = new int [rodLength+1];
        }

        public void SetPrice(int length,int price)
        {
            prices[length] = price;
        }

        public int GetPrice(int length)
        {
            return prices[length];
        }

        public void DisplayPrices()
        {
            Console.WriteLine("\nPrice Chart:");
            for (int i=1;i<prices.Length;i++)
            {
                Console.WriteLine($"Length: {i}, Price: {prices[i]}");
            }
        }
    }
}
