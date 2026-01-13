using System;
using System.Collections.Generic;
using System.Text;

namespace linear_binary_search
{
    internal class SearchMatrix
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            Console.WriteLine("Enter matrix elements:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Enter target: ");
            int target = int.Parse(Console.ReadLine());

            Search(matrix, rows, cols, target);
        }

        public static void Search(int[,] matrix, int rows, int cols, int target)
        {
            int low = 0;
            int high = rows * cols - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                int row = mid / cols;
                int col = mid % cols;

                int value = matrix[row, col];

                if (value == target)
                {
                    Console.WriteLine($"Target found at position: ({row}, {col})");
                    return;
                }
                else if (value < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            Console.WriteLine("Target not found.");
        }
    }
}
