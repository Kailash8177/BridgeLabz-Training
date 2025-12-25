using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level_2
{
    public class BMI
    {
        public static void Main()
        {
            double[,] data = new double[10, 3]; // 0: weight, 1: height(cm), 2: BMI
            string[] status = new string[10];

            for (int i = 0; i < 10; i++)
            {
                data[i, 0] = double.Parse(Console.ReadLine()); // weight in kg
                data[i, 1] = double.Parse(Console.ReadLine()); // height in cm
            }

            CalculateBMI(data);
            status = DetermineBMIStatus(data);

            Console.WriteLine("Weight(kg) Height(cm) BMI Status");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(data[i, 0] + " " + data[i, 1] + " " + data[i, 2] + " " + status[i]);
            }
        }

        public static void CalculateBMI(double[,] data)
        {
            for (int i = 0; i < 10; i++)
            {
                double heightInMeter = data[i, 1] / 100.0;
                data[i, 2] = data[i, 0] / (heightInMeter * heightInMeter);
            }
        }

        public static string[] DetermineBMIStatus(double[,] data)
        {
            string[] status = new string[10];
            for (int i = 0; i < 10; i++)
            {
                if (data[i, 2] < 18.5)
                {
                    status[i] = "Underweight";
                }
                else if (data[i, 2] >= 18.5 && data[i, 2] < 25)
                {
                    status[i] = "Normal";
                }
                else if (data[i, 2] >= 25 && data[i, 2] < 30)
                {
                    status[i] = "Overweight";
                }
                else
                {
                    status[i] = "Obese";
                }
            }
            return status;
        }
    }
}
