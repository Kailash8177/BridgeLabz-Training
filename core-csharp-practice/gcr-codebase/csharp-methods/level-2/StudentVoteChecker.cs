using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level_2
{
    public class StudentVoteChecker
    {

        public static void Main()
        {
            int[] ages = new int[10];

            for (int i = 0; i < 10; i++)
            {
                ages[i] = int.Parse(Console.ReadLine());
                bool canVote = CanStudentVote(ages[i]);
                Console.WriteLine("Student " + (i + 1) + " can vote: " + canVote);
            }
        }

        public static bool CanStudentVote(int age)
        {
            if (age < 0)
            {
                return false;
            }
            else if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
