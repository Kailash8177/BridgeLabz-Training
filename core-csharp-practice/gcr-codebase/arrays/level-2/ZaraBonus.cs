using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.array.level_2
{
    public class ZaraBonus
    {
        public static void Main()
        {

            int n = 10;

            double[] salary = new double[n];
            double[] years = new double[n];
            double[] bonus = new double[n];
            double[] newSalary = new double[n];

            double totalBonus = 0;
            double totalOldSalary = 0;
            double totalNewSalary = 0;

            for (int i = 0; i < n; i++)
            {

                salary[i] = double.Parse(Console.ReadLine());
                years[i] = double.Parse(Console.ReadLine());

                if (salary[i] <= 0 || years[i] < 0)
                {
                    i--;
                    continue;
                }
            }

            for (int i = 0; i < n; i++)
            {

                if (years[i] > 5)
                {
                    bonus[i] = salary[i] * 0.05;
                }
                else
                {
                    bonus[i] = salary[i] * 0.02;
                }

                newSalary[i] = salary[i] + bonus[i];

                totalBonus = totalBonus + bonus[i];
                totalOldSalary = totalOldSalary + salary[i];
                totalNewSalary = totalNewSalary + newSalary[i];
            }

            Console.WriteLine("Total Bonus = " + totalBonus);
            Console.WriteLine("Total Old Salary = " + totalOldSalary);
            Console.WriteLine("Total New Salary = " + totalNewSalary);

        }
    }
}
