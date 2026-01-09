using System;
using System.Collections.Generic;
using System.Text;

namespace atm_ispenser_logic
{
    internal class Customer
    {
        public void StartTransaction()
        {
            Console.Write("Enter withdrawal amount: ");
            int amount = int.Parse(Console.ReadLine());

            Withdraw(amount);   
        }
        private void Withdraw(int amount)
        {
            int remaining = amount;

            Console.WriteLine("\nRequested Amount: {amount}");
            Console.WriteLine("Dispensed Notes:");

            for (int i = 0; i < ATMManager.denominations.Length; i++)
            {
                int note = ATMManager.denominations[i];
                int available = ATMManager.noteCount[i];

                if (remaining >= note && available > 0)
                {
                    int used = Math.Min(remaining / note, available);

                    remaining -= used * note;
                    ATMManager.noteCount[i] -= used;

                    if (used > 0)
                    {
                        int withdrawnAmount = note * used;
                        Console.WriteLine($"{note} x {used} = {withdrawnAmount}");
                    }
                        
                }
            }

            if (remaining != 0)
            {
                Console.WriteLine("\n Unable to dispense exact amount");
                Console.WriteLine("Remaining amount: {remaining}");
            }
            else
            {
                Console.WriteLine("\n Cash dispensed successfully");
            }
        }
    }
}
