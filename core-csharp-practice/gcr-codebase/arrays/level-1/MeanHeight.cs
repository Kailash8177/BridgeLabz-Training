using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.array
{
    public class MeanHeight
    {
        public static void Main()
        {
            Double[] heights = new double[11];
            double totalHeight = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                heights[i] = double.Parse(Console.ReadLine());
                totalHeight += heights[i];
            }
            double meanHeight = totalHeight / heights.Length;
            Console.WriteLine("The mean height is: " + meanHeight);
        }
    }
}
