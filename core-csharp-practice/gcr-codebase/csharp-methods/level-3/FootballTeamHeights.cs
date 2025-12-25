using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level_3
{
    public class FootballTeamHeights
    {
        public static void Main()
        {
            int[] heights = new int[11];
            Random rand = new Random();

            for (int i = 0; i < 11; i++)
            {
                heights[i] = rand.Next(150, 251); // 150 to 250 cm
            }

            int sum = FindSum(heights);
            double mean = FindMean(heights);
            int shortest = FindShortest(heights);
            int tallest = FindTallest(heights);

            Console.WriteLine("Heights of players: ");
            for (int i = 0; i < 11; i++)
            {
                Console.Write(heights[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Mean = " + mean);
            Console.WriteLine("Shortest = " + shortest);
            Console.WriteLine("Tallest = " + tallest);
        }

        public static int FindSum(int[] heights)
        {
            int sum = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                sum += heights[i];
            }
            return sum;
        }

        public static double FindMean(int[] heights)
        {
            return FindSum(heights) / (double)heights.Length;
        }

        public static int FindShortest(int[] heights)
        {
            int min = heights[0];
            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] < min)
                {
                    min = heights[i];
                }
            }
            return min;
        }

        public static int FindTallest(int[] heights)
        {
            int max = heights[0];
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
