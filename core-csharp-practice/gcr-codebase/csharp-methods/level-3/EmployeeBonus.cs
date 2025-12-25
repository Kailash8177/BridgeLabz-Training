using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level_3
{
    public class EmployeeBonus
    {
        public static void Main()
        {
            double[,] data = new double[10, 2];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                data[i, 0] = rand.Next(10000, 100000); // salary
                data[i, 1] = rand.Next(1, 21); // years of service
            }

            double[,] newData = CalculateBonus(data);
            DisplayBonus(data, newData);
        }

        public static double[,] CalculateBonus(double[,] data)
        {
            double[,] newData = new double[10, 3]; // salary, years, bonus
            for (int i = 0; i < 10; i++)
            {
                newData[i, 0] = data[i, 0];
                newData[i, 1] = data[i, 1];
                double bonus = (data[i, 1] > 5) ? 0.05 * data[i, 0] : 0.02 * data[i, 0];
                newData[i, 2] = data[i, 0] + bonus;
            }
            return newData;
        }

        public static void DisplayBonus(double[,] oldData, double[,] newData)
        {
            double sumOld = 0, sumNew = 0, totalBonus = 0;
            Console.WriteLine("Salary\tYears\tNew Salary");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{oldData[i, 0]}\t{oldData[i, 1]}\t{newData[i, 2]}");
                sumOld += oldData[i, 0];
                sumNew += newData[i, 2];
                totalBonus += (newData[i, 2] - oldData[i, 0]);
            }
            Console.WriteLine($"Total Old Salary = {sumOld}, Total New Salary = {sumNew}, Total Bonus = {totalBonus}");
        }
    }
}
