using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level_3
{
    public class MatrixOperations
    {
        public static void Main()
        {

            int[,] A = CreateRandomMatrix(2, 2);
            int[,] B = CreateRandomMatrix(2, 2);

            Console.WriteLine("Matrix A:");
            DisplayMatrix(A);

            Console.WriteLine("Matrix B:");
            DisplayMatrix(B);

            Console.WriteLine("Addition:");
            DisplayMatrix(AddMatrices(A, B));

            Console.WriteLine("Subtraction:");
            DisplayMatrix(SubtractMatrices(A, B));

            Console.WriteLine("Multiplication:");
            DisplayMatrix(MultiplyMatrices(A, B));

            Console.WriteLine("Transpose of A:");
            DisplayMatrix(TransposeMatrix(A));

            double det2 = Determinant2x2(A);
            Console.WriteLine("Determinant of A (2x2) = " + det2);

            if (det2 != 0)
            {
                Console.WriteLine("Inverse of A (2x2):");
                DisplayDoubleMatrix(Inverse2x2(A));
            }
            else
            {
                Console.WriteLine("Inverse not possible (Determinant is 0)");
            }

            int[,] C = CreateRandomMatrix(3, 3);
            Console.WriteLine("Matrix C (3x3):");
            DisplayMatrix(C);

            double det3 = Determinant3x3(C);
            Console.WriteLine("Determinant of C (3x3) = " + det3);

            if (det3 != 0)
            {
                Console.WriteLine("Inverse of C (3x3):");
                DisplayDoubleMatrix(Inverse3x3(C));
            }
            else
            {
                Console.WriteLine("Inverse not possible (Determinant is 0)");
            }
        }

        public static int[,] CreateRandomMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(1, 10);
                }
            }
            return matrix;
        }

        public static int[,] AddMatrices(int[,] A, int[,] B)
        {
            int[,] result = new int[A.GetLength(0), A.GetLength(1)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    result[i, j] = A[i, j] + B[i, j];
                }
            }
            return result;
        }

        public static int[,] SubtractMatrices(int[,] A, int[,] B)
        {
            int[,] result = new int[A.GetLength(0), A.GetLength(1)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    result[i, j] = A[i, j] - B[i, j];
                }
            }
            return result;
        }

        public static int[,] MultiplyMatrices(int[,] A, int[,] B)
        {
            int[,] result = new int[A.GetLength(0), B.GetLength(1)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < A.GetLength(1); k++)
                    {
                        result[i, j] += A[i, k] * B[k, j];
                    }
                }
            }
            return result;
        }

        public static int[,] TransposeMatrix(int[,] A)
        {
            int[,] result = new int[A.GetLength(1), A.GetLength(0)];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    result[j, i] = A[i, j];
                }
            }
            return result;
        }

        public static double Determinant2x2(int[,] A)
        {
            return A[0, 0] * A[1, 1] - A[0, 1] * A[1, 0];
        }

        public static double Determinant3x3(int[,] A)
        {
            double det;
            det = A[0, 0] * (A[1, 1] * A[2, 2] - A[1, 2] * A[2, 1])
                - A[0, 1] * (A[1, 0] * A[2, 2] - A[1, 2] * A[2, 0])
                + A[0, 2] * (A[1, 0] * A[2, 1] - A[1, 1] * A[2, 0]);
            return det;
        }

        public static double[,] Inverse2x2(int[,] A)
        {
            double det = Determinant2x2(A);
            double[,] inv = new double[2, 2];

            inv[0, 0] = A[1, 1] / det;
            inv[0, 1] = -A[0, 1] / det;
            inv[1, 0] = -A[1, 0] / det;
            inv[1, 1] = A[0, 0] / det;

            return inv;
        }

        public static double[,] Inverse3x3(int[,] A)
        {
            double det = Determinant3x3(A);
            double[,] inv = new double[3, 3];

            inv[0, 0] = (A[1, 1] * A[2, 2] - A[1, 2] * A[2, 1]) / det;
            inv[0, 1] = -(A[0, 1] * A[2, 2] - A[0, 2] * A[2, 1]) / det;
            inv[0, 2] = (A[0, 1] * A[1, 2] - A[0, 2] * A[1, 1]) / det;

            inv[1, 0] = -(A[1, 0] * A[2, 2] - A[1, 2] * A[2, 0]) / det;
            inv[1, 1] = (A[0, 0] * A[2, 2] - A[0, 2] * A[2, 0]) / det;
            inv[1, 2] = -(A[0, 0] * A[1, 2] - A[0, 2] * A[1, 0]) / det;

            inv[2, 0] = (A[1, 0] * A[2, 1] - A[1, 1] * A[2, 0]) / det;
            inv[2, 1] = -(A[0, 0] * A[2, 1] - A[0, 1] * A[2, 0]) / det;
            inv[2, 2] = (A[0, 0] * A[1, 1] - A[0, 1] * A[1, 0]) / det;

            return inv;
        }

        public static void DisplayMatrix(int[,] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void DisplayDoubleMatrix(double[,] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(Math.Round(A[i, j], 2) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
