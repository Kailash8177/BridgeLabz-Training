using System;
using System.Collections.Generic;
using System.Text;

namespace sorting_algorithms
{
    internal class EmployeeIDs
    {
        public static void InsertionSort(int[] ids)
        {
            for (int i = 1; i < ids.Length; i++)
            {
                int key = ids[i];
                int j = i - 1;

                while (j >= 0 && ids[j] > key)
                {
                    ids[j + 1] = ids[j];
                    j--;
                }

                ids[j + 1] = key;
            }
        }

        static void Main()
        {
            int[] employeeIds = { 104, 102, 109, 101, 105 };
            InsertionSort(employeeIds);

            Console.WriteLine("Sorted Employee IDs:");
            foreach (int id in employeeIds)
                Console.Write(id + " ");
        }
    }
}
