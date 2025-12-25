using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level_3
{
    public class StudentMarks
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] scores = GenerateScores(n);
            double[,] results = CalculateResults(scores, n);
            DisplayResults(scores, results, n);
        }

        public static int[,] GenerateScores(int n)
        {
            int[,] scores = new int[n, 3];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                scores[i, 0] = rand.Next(0, 101);
                scores[i, 1] = rand.Next(0, 101);
                scores[i, 2] = rand.Next(0, 101);
            }
            return scores;
        }

        public static double[,] CalculateResults(int[,] scores, int n)
        {
            double[,] results = new double[n, 3]; // total, avg, percent
            for (int i = 0; i < n; i++)
            {
                double total = scores[i, 0] + scores[i, 1] + scores[i, 2];
                double avg = total / 3.0;
                double percent = total / 3.0; // percentage in same scale 0-100
                results[i, 0] = Math.Round(total, 2);
                results[i, 1] = Math.Round(avg, 2);
                results[i, 2] = Math.Round(percent, 2);
            }
            return results;
        }

        public static void DisplayResults(int[,] scores, double[,] results, int n)
        {
            Console.WriteLine("Physics\tChemistry\tMaths\tTotal\tAverage\tPercentage");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{scores[i, 0]}\t{scores[i, 1]}\t{scores[i, 2]}\t{results[i, 0]}\t{results[i, 1]}\t{results[i, 2]}");
            }
        }
    }
}
