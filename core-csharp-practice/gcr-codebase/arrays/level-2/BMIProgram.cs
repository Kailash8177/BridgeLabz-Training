using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.array.level_2
{
    public class BMIProgram
    {
        public static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            double[] height = new double[n];
            double[] weight = new double[n];
            double[] bmi = new double[n];
            string[] status = new string[n];

            for (int i = 0; i < n; i++)
            {
                height[i] = double.Parse(Console.ReadLine());
                weight[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                bmi[i] = weight[i] / (height[i] * height[i]);

                if (bmi[i] <= 18.4)
                {
                    status[i] = "Underweight";
                }
                else if (bmi[i] <= 24.9)
                {
                    status[i] = "Normal";
                }
                else if (bmi[i] <= 39.9)
                {
                    status[i] = "Overweight";
                }
                else
                {
                    status[i] = "Obese";
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(height[i] + " " + weight[i] + " " + bmi[i] + " " + status[i]);
            }
        }
    }
}
