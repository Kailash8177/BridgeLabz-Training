using System;
using System.Collections.Generic;
using System.Text;

namespace sorting_algorithms
{
    internal class StudentAges
    {
        public static void CountingSort(int[] ages)
        {
            int minAge = 10, maxAge = 18;
            int range = maxAge - minAge + 1;

            int[] count = new int[range];

            foreach (int age in ages)
                count[age - minAge]++;

            int index = 0;
            for (int i = 0; i < range; i++)
            {
                while (count[i]-- > 0)
                    ages[index++] = i + minAge;
            }
        }

        public static void Main()
        {
            int[] ages = { 12, 15, 10, 18, 14, 12 };
            CountingSort(ages);

            Console.WriteLine("Sorted Student Ages:");
            foreach (int age in ages)
                Console.Write(age + " ");
        }
    }
}
