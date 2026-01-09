using System;
using System.Collections.Generic;
using System.Text;

namespace atm_ispenser_logic
{
    internal class ATMManager
    {
        public static int[] denominations =
        {
             500, 200, 100, 50, 20, 10, 5, 2, 1
        };

        public static int[] noteCount;

        public void ConfigureATM()
        {
            noteCount = new int[denominations.Length];

            Console.WriteLine("\nConfigure ATM Note Counts:");

            for (int i = 0; i < denominations.Length; i++)
            {
                Console.Write($"Enter count for {denominations[i]}: ");
                noteCount[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" ATM configured (Scenario A ready)");
        }
    }
}
