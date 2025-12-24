using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.array.level_2
{
    public class BMIProgramUsinTwoD
    {
        public static void Main()
        {

            int number = int.Parse(Console.ReadLine());

            double[][] personData = new double[number][];
            string[] weightStatus = new string[number];

            for (int i = 0; i < number; i++)
            {
                personData[i] = new double[3];

                personData[i][0] = double.Parse(Console.ReadLine());
                personData[i][1] = double.Parse(Console.ReadLine());

                if (personData[i][0] <= 0 || personData[i][1] <= 0)
                {
                    i--;
                    continue;
                }
            }

            for (int i = 0; i < number; i++)
            {
                double height = personData[i][0];
                double weight = personData[i][1];

                personData[i][2] = weight / (height * height);

                if (personData[i][2] <= 18.4)
                {
                    weightStatus[i] = "Underweight";
                }
                else if (personData[i][2] <= 24.9)
                {
                    weightStatus[i] = "Normal";
                }
                else if (personData[i][2] <= 39.9)
                {
                    weightStatus[i] = "Overweight";
                }
                else
                {
                    weightStatus[i] = "Obese";
                }
            }

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(
                    personData[i][0] + " " +
                    personData[i][1] + " " +
                    personData[i][2] + " " +
                    weightStatus[i]
                );
            }
        }
    }
}
