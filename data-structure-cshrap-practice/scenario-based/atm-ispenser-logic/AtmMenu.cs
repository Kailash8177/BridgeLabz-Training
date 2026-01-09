using System;
using System.Collections.Generic;
using System.Text;

namespace atm_ispenser_logic
{
    internal class AtmMenu
    {

        public AtmMenu()
        {
            Menu();
        }

        public void Menu()
        {
            ATMManager manager = new ATMManager();
            Customer customer = new Customer();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- ATM MENU ---");
                Console.WriteLine("1. Manager ");
                Console.WriteLine("2. Customer");
                Console.WriteLine("3. Exit");
                Console.Write("Choose option: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    //  MANAGER
                    case 1:
                        manager.ConfigureATM();
                        break;

                    //  CUSTOMER
                    case 2:
                        customer.StartTransaction();  
                        break;

                    case 3:
                        exit = true;
                        Console.WriteLine("Exiting ATM");
                        break;
                }
            }
        }
    }
}
