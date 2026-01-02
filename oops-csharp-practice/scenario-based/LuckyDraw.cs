using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining
{
    internal class LuckyDraw
    {
        public static void Main() 
        {
            
            LuckyDraw ld = new LuckyDraw();
            ld.StartLuckyDraw();

        }
        public void StartLuckyDraw() 
        {

            Console.Write("Enter number of visitors: ");
            int visitors = int.Parse(Console.ReadLine());

            for (int i = 1; i <= visitors; i++)
            {
                Console.Write($"Enter number for Visitor {i}: ");
                int input = int.Parse(Console.ReadLine());

                if ( input <= 0)
                {
                    Console.WriteLine("Invalid input! Skipping this visitor.");
                    continue;
                }

                
                if (input % 3 == 0 && input % 5 == 0)
                {
                    Console.WriteLine("Congratulations! You won a gift!");
                }
                else
                {
                    Console.WriteLine("Better luck next time!");
                }
            }

            Console.WriteLine("Lucky Draw Completed 🎊");


        }
    }
}
