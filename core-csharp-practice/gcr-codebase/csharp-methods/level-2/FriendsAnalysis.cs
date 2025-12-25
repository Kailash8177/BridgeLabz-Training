using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level_2
{
    public class FriendsAnalysis
    {
        public static void Main()
        {
            int[] ages = new int[3];
            double[] heights = new double[3];

            for (int i = 0; i < 3; i++)
            {
                ages[i] = int.Parse(Console.ReadLine());
                heights[i] = double.Parse(Console.ReadLine());
            }

            int youngest = FindYoungest(ages);
            double tallest = FindTallest(heights);

            Console.WriteLine("Youngest age = " + youngest);
            Console.WriteLine("Tallest height = " + tallest);
        }

        public static int FindYoungest(int[] ages)
        {
            int min = ages[0];
            for (int i = 1; i < ages.Length; i++)
            {
                if (ages[i] < min)
                {
                    min = ages[i];
                }
            }
            return min;
        }

        public static double FindTallest(double[] heights)
        {
            double max = heights[0];
            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] > max)
                {
                    max = heights[i];
                }
            }
            return max;
        }
    }
}
