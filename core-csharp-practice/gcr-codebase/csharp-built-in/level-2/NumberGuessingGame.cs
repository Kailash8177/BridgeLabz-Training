using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_builtin.level_2
{
    public class NumberGuessingGame
    {
        public static int GenerateGuess(int low, int high)
        {
            return (low + high) / 2;
        }

        public static string GetFeedback()
        {
            return Console.ReadLine().ToLower();
        }

        public static void Main()
        {
            int low = 1, high = 100;
            string feedback;
            int guess;

            Console.WriteLine("Think of a number between 1 and 100");

            while (true)
            {
                guess = GenerateGuess(low, high);
                Console.WriteLine("Is your number " + guess + "? (high/low/correct)");
                feedback = GetFeedback();

                if (feedback == "correct")
                {
                    Console.WriteLine("Guessed correctly!");
                    break;
                }
                else if (feedback == "high")
                {
                    high = guess - 1;
                }
                else if (feedback == "low")
                {
                    low = guess + 1;
                }
            }
        }
    }
}
