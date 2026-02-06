using System;
using System.Collections.Generic;
using System.Text;

namespace bank_management_system
{
    internal class User
    {
        public void UserMenu(Bank bank,IBankAccount account,Manager manager) 
        {
            int choice;
            do
            {
                Console.WriteLine("1 -> Deposite");
                Console.WriteLine("2 -> Withdraw");
                Console.WriteLine("3 -> Show the details of the Account");
                Console.WriteLine("4 -> Exit");
                Console.WriteLine("Eneter the choice");

                choice = int.Parse(Console.ReadLine());

                switch (choice) 
                {
                    case 1:
                        Console.WriteLine("Enter the ammount to Deposite");
                        Double am=Double.Parse(Console.ReadLine());
                        account.Deposit(am);
                        break;
                    case 2:
                        Console.WriteLine("Enter the ammount to withdrawl");
                        Double amm=Double.Parse(Console.ReadLine());
                        account.Withdraw(amm);   
                        break;
                    case 3:
                        Console.WriteLine("Your Details Are below");
                        manager.ShowTheDetails(bank,account);
                        break;
                    case 4:
                        Console.WriteLine("Thank you for visiting the bank");
                        break;
                    default:
                        Console.WriteLine("Enter the valid choice");
                        break;
                }

            }
            while (choice != 4);
        }
    }
}
