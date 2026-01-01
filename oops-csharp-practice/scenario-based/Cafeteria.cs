using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.cenario_based
{
    
    internal class Cafeteria
    {

        static string[] menu =
    {
        "Coffee",
        "Tea",
        "Matar Paneer",
        "Sahi Paneer",
        "Daal Fry",
        "Paner Do Payaja",
        "Palak Paneer",
        "Kadai Paneer",
        "Butter Paneer",
        "Paneer Tikka"
    };
        public static void Main(string[] args)
        {
            int index;
            Console.WriteLine("Welcome to the Cafeteria!");
            Console.WriteLine("Today's Menu:");

            Cafeteria cafeteria = new Cafeteria();

            do
            {

                cafeteria.DisplayMenu();

                Console.Write("\nPlease enter the item numbers you wish to order : ");
                index = int.Parse(Console.ReadLine());

                cafeteria.GetItemByIndex( index );
                
            }
            while ( index != 11 );
        }

        public  void DisplayMenu()
        {
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {menu[i]} ");
            }

            Console.WriteLine("11."+" "+"for nothing");

        }

        public void GetItemByIndex(int index)
        {

            switch(index)
            {
                   case 1:
                    Console.WriteLine("\nYou have ordered " + menu[0]);
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("\nYou have ordered " + menu[1]);
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("\nYou have ordered " + menu[2]);
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine("\nYou have ordered " + menu[3]);
                    Console.WriteLine();
                    break;
                case 5:
                    Console.WriteLine("\nYou have ordered " + menu[4]);
                    Console.WriteLine();
                    break;
                case 6:
                    Console.WriteLine("\nYou have ordered " + menu[5]);
                    Console.WriteLine();
                    break;
                case 7:
                    Console.WriteLine("\nYou have ordered " + menu[6]);
                    Console.WriteLine();
                    break;
                case 8:
                    Console.WriteLine("\nYou have ordered " + menu[7]);
                    Console.WriteLine();
                    break;
                case 9:
                    Console.WriteLine("\nYou have ordered " + menu[8]);
                    Console.WriteLine();
                    break;
                case 10:
                    Console.WriteLine("\nYou have ordered " + menu[9]);
                    Console.WriteLine();
                    break;
                case 11:
                    Console.WriteLine("Thank you for visiting the Cafeteria!");
                    break;
                default:
                    Console.WriteLine("Invalid item number. Please try again.");
                    break;
            }
        }
    }
}
