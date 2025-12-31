//using System;
//using System.Collections.Generic;
//using System.Text;

///*
// This program implements a simple Bank Management System using object-oriented programming concepts.
// It supports role-based access for Manager and User.
// The Manager can open accounts and manage deposits and withdrawals,
// while the User can perform basic banking operations on an existing account.
// The program demonstrates classes, objects, methods, static members, and menu-driven control flow.
// */


//namespace BridgeLabzTraining.opps_chsarp_pracitce.cenario_based
//{
//    internal class BankManagementSystem
//    {
//        // Entry point of the application
//        public static void Main(string[] args)
//        {
//            // Creating objects of Bank, Manager, and User classes
//            Bank bank = new Bank();
//            Manager manager = new Manager();
//            User user = new User();

//            int role;

//            // Main role-selection menu
//            do
//            {
//                Console.WriteLine("\nSelect Role:");
//                Console.WriteLine("1. Manager");
//                Console.WriteLine("2. User");
//                Console.WriteLine("3. Exit");
//                Console.Write("Enter choice: ");

//                role = int.Parse(Console.ReadLine());

//                // Perform actions based on selected role
//                switch (role)
//                {
//                    case 1:
//                        // Manager opens account and views account details
//                        manager.OpenAccount();
//                        manager.ShowDetails(bank);
//                        break;

//                    case 2:
//                        // User can access only if account already exists
//                        if (manager.accountNumber == null)
//                        {
//                            Console.WriteLine(
//                                "No account found. Please contact the manager to open an account first."
//                            );
//                        }
//                        else
//                        {
//                            user.UserMenu(bank, manager);
//                        }
//                        break;

//                    case 3:
//                        // Exit application
//                        Console.WriteLine("Exiting...");
//                        break;

//                    default:
//                        Console.WriteLine("Invalid choice. Please try again.");
//                        break;
//                }

//            } while (role != 3);
//        }
//    }

//    // ---------------- BANK CLASS ----------------
//    // Contains bank-related information
//    public class Bank
//    {
//        // Static member shared by all objects
//        public static string bankName = "State Bank of India";

//        // Instance members
//        public string branchName = "Renukoot";
//        public string ifscCode = "SBIN0001234";
//    }

//    // ---------------- MANAGER CLASS ----------------
//    // Responsible for account creation and account operations
//    public class Manager
//    {
//        public string accountNumber;
//        public double balance;

//        // Method to open a new bank account
//        public void OpenAccount()
//        {
//            Console.WriteLine("Enter Account Number:");
//            accountNumber = Console.ReadLine();

//            Console.WriteLine("Enter Initial Balance:");
//            balance = double.Parse(Console.ReadLine());

//            // Initial balance cannot be negative
//            if (balance < 0)
//            {
//                Console.WriteLine("Initial balance cannot be negative. Setting balance to 0.");
//                balance = 0;
//            }

//            Console.WriteLine("Account Opened Successfully!");
//        }

//        // Method to deposit money into account
//        public void Deposit()
//        {
//            Console.Write("Enter deposit amount: ");
//            double amount = double.Parse(Console.ReadLine());

//            // Deposit amount must be positive
//            if (amount <= 0)
//            {
//                Console.WriteLine("Invalid deposit amount");
//                return;
//            }

//            balance += amount;
//            Console.WriteLine("Deposit successful");
//        }

//        // Method to withdraw money from account
//        public void Withdraw()
//        {
//            Console.Write("Enter withdrawal amount: ");
//            double amount = double.Parse(Console.ReadLine());

//            // Withdrawal amount must be positive
//            if (amount <= 0)
//            {
//                Console.WriteLine("Invalid withdrawal amount");
//                return;
//            }

//            // Ensure sufficient balance is available
//            if (amount > balance)
//            {
//                Console.WriteLine("Insufficient balance");
//                return;
//            }

//            balance -= amount;
//            Console.WriteLine("Withdrawal successful");
//        }

//        // Method to display bank and account details
//        public void ShowDetails(Bank bank)
//        {
//            Console.WriteLine("\n--- Bank & Account Details ---");
//            Console.WriteLine("Bank Name  : " + Bank.bankName);
//            Console.WriteLine("Branch     : " + bank.branchName);
//            Console.WriteLine("IFSC Code  : " + bank.ifscCode);
//            Console.WriteLine("Account No : " + accountNumber);
//            Console.WriteLine("Balance    : " + balance);
//        }
//    }
//    // ---------------- USER CLASS ----------------
//    // Allows users to perform banking operations
//    public class User
//    {
//        // User-specific menu for banking operations
//        public void UserMenu(Bank bank, Manager manager)
//        {
//            int choice;

//            do
//            {
//                Console.WriteLine("\n1. Deposit");
//                Console.WriteLine("2. Withdraw");
//                Console.WriteLine("3. Check Balance");
//                Console.WriteLine("4. Exit");
//                Console.Write("Enter choice: ");

//                choice = int.Parse(Console.ReadLine());

//                // Perform operation based on user choice
//                switch (choice)
//                {
//                    case 1:
//                        manager.Deposit();
//                        break;

//                    case 2:
//                        manager.Withdraw();
//                        break;

//                    case 3:
//                        manager.ShowDetails(bank);
//                        break;

//                    case 4:
//                        Console.WriteLine("Exiting user menu...");
//                        break;

//                    default:
//                        Console.WriteLine("Invalid choice. Please try again.");
//                        break;
//                }
//            } while (choice != 4);
//        }
//    }
//}