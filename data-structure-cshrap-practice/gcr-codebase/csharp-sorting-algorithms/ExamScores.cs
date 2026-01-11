using System;
using System.Collections.Generic;
using System.Text;

namespace sorting_algorithms
{
    internal class ExamScores
    {
        public static void SelectionSort(int[] scores)
        {
            for (int i = 0; i < scores.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < scores.Length; j++)
                {
                    if (scores[j] < scores[minIndex])
                        minIndex = j;
                }

                int temp = scores[minIndex];
                scores[minIndex] = scores[i];
                scores[i] = temp;
            }
        }

        public static void Main()
        {
            int[] scores = { 78, 92, 65, 88, 70 };
            SelectionSort(scores);

            Console.WriteLine("Sorted Exam Scores:");
            foreach (int score in scores)
                Console.Write(score + " ");
        }
    }
}
