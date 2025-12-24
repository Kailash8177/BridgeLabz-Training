using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.array.level_2
{
    public class StudentGradeUSingOneD
    {
        public static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            int[,] marks = new int[n, 3];   // Physics, Chemistry, Maths
            double[] percentage = new double[n];
            string[] grade = new string[n];

            for (int i = 0; i < n; i++)
            {

                marks[i, 0] = int.Parse(Console.ReadLine());
                marks[i, 1] = int.Parse(Console.ReadLine());
                marks[i, 2] = int.Parse(Console.ReadLine());

                if (marks[i, 0] < 0 || marks[i, 1] < 0 || marks[i, 2] < 0)
                {
                    i--;
                    continue;
                }
            }

            for (int i = 0; i < n; i++)
            {

                int total = marks[i, 0] + marks[i, 1] + marks[i, 2];
                percentage[i] = total / 3.0;

                if (percentage[i] >= 80)
                {
                    grade[i] = "A";
                }
                else if (percentage[i] >= 70)
                {
                    grade[i] = "B";
                }
                else if (percentage[i] >= 60)
                {
                    grade[i] = "C";
                }
                else if (percentage[i] >= 50)
                {
                    grade[i] = "D";
                }
                else if (percentage[i] >= 40)
                {
                    grade[i] = "E";
                }
                else
                {
                    grade[i] = "R";
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    marks[i, 0] + " " +
                    marks[i, 1] + " " +
                    marks[i, 2] + " " +
                    percentage[i] + " " +
                    grade[i]
                );
            }
        }
    }
}
