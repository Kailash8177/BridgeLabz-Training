using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.array
{
    public class VotingEligibility
    {

        public static void Main(string[] args)
        {
            int[] ages = new int[10];

            Console.WriteLine("Enter age of 10 students:");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter age of person " + (i + 1) + ": ");
                ages[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] < 0)
                {
                    Console.WriteLine("Invalid age");
                }
                if (ages[i] >= 18)
                {
                    Console.WriteLine("The student with the age " + ages[i] + " can vote.");
                }
                else
                {
                    Console.WriteLine("The student with the age " + ages[i] + " cannot vote.");
                }
            }
        }
    }
}
