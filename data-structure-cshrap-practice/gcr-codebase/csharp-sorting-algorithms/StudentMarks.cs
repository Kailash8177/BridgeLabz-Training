using System;
using System.Collections.Generic;
using System.Text;

namespace sorting_algorithms
{
    internal class StudentMarks
    {
        public static void BubbleSort(int[] marks)
        {
            int n = marks.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (marks[j] > marks[j + 1])
                    {
                        int temp = marks[j];
                        marks[j] = marks[j + 1];
                        marks[j + 1] = temp;
                    }
                }
            }
        }

        public static void Main()
        {
            int[] marks = { 55, 72, 38, 90, 61 };
            BubbleSort(marks);

            Console.WriteLine("Sorted Student Marks:");
            foreach (int mark in marks)
                Console.Write(mark + " ");
        }
    }
}
