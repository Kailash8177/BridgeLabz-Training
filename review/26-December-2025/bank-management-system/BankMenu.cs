using System;
using System.Collections.Generic;
using System.Text;

namespace bank_management_system
{
    internal class BankMenu
    {
        Bank bank = new Bank();
        Manager manger = new Manager();
        User user = new User();

        IBankAccount account = null;

        int choice;
        BankMenu()
        {
            Menu();
        }

        public void Menu()
        {
            do
            {
                Console.WriteLine("Select the Role");
                Console.WriteLine("1-> Manager");
                Console.WriteLine("2-> User");
                Console.WriteLine("3-> Exit");
                Console.WriteLine("Enter the choice");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        account = manger.OpenAccount();
                        break;

                    case 2:
                        if (account == null)
                        {
                            Console.WriteLine("No account found. Please open account first.");
                        }
                        else
                        {
                            user.UserMenu(bank, account, manger);
                        }
                        break;

                    case 3:
                        Console.WriteLine("Thank you for using Bank Management System");
                        break;

                    default:
                        Console.WriteLine("Enter valid choice");
                        break;
                }

            } while (choice != 3);
        }
    }
}
