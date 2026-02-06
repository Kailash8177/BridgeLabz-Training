using System;
using System.Collections.Generic;
using System.Text;

namespace Groceries_system
{
    internal class Groceries
    {
        static List<string> itemName = new List<string>();
        static List<int> quantity = new List<int>();
        static List<double> price = new List<double>();

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("------Grocery Management System-----");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. Customer");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter the choice");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AdminMenu();
                        break;
                    case 2:
                        CustomerMenu();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Enter the valid value");
                        break;
                }
            }
        }

        // Admin Menu

        public static void AdminMenu()
        {
            while (true)
            {
                Console.WriteLine("----Admin Menu------");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Display Item");
                Console.WriteLine("3. Exit form the Admin Menu");
                Console.WriteLine("Enter the Choice");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddItem();
                        break;
                    case 2:
                        DisplayItem();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Enter the valid Choice");
                        break;

                }
            }
        }

        //customer mernu
        public static void CustomerMenu()
        {
            
            while (true)
            {
                Console.WriteLine("----Cutomer Menu------");
                Console.WriteLine("1. Display Item");
                Console.WriteLine("2. Buy Item");
                Console.WriteLine("3. Exit form the Cutomer Menu");
                Console.WriteLine("Enter the Choice");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayItem();
                        break;
                    case 2:
                        BuyItem();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Enter the valid Choice");
                        break;
                }
            }
        }

        public static void AddItem()
        {
            Console.WriteLine("Enter the Item Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Item Quantity");
            int qnt = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Price");
            double p = double.Parse(Console.ReadLine());

            itemName.Add(name);
            quantity.Add(qnt);
            price.Add(p);
        }

        public static void DisplayItem()
        {
            if (itemName.Count == 0)
            {

                Console.WriteLine("No Item is Available");
                return;
            }
            for (int i = 0; i < itemName.Count; i++)
            {
                Console.WriteLine($"{i+1}. Item Name :{itemName[i]}, Quantity :{quantity[i]}, price :{price[i]} ");
            }
        }

        public static void BuyItem()
        {

            if (itemName.Count == 0)
            { 
                Console.WriteLine("No Item is Available");
                return;
            }

            DisplayItem();

            Console.WriteLine("Enter the item number to buy");
            int n = int.Parse(Console.ReadLine());

            n = n - 1;

            if (n < 0 || n >= itemName.Count)
            {
                Console.WriteLine("Wrong item Index");
                return;
            }

            Console.WriteLine("Enter the Number of Quantity to Buy");
            int q = int.Parse(Console.ReadLine());

            if (q > quantity[n])
            {
                Console.WriteLine("Stock is Not Available");
                return;
            }
            
            double bill = q*price[n];
            quantity[n] -= q;

            Console.WriteLine($"Pice is : {bill}");
            return;
        }
    }
}
