using System;
using System.Collections.Generic;
using System.Text;

namespace social_media_friends
{
    internal class Utility
    {
        public static void Main()
        {
            UserList users = new UserList();
            int choice;

            do
            {
                Console.WriteLine("\n--- User Management System ---");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Search User");
                Console.WriteLine("3. Display All Users");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter User ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();

                        users.AddUser(id, name);
                        Console.WriteLine("User added successfully");
                        break;

                    case 2:
                        Console.Write("Enter User ID to search: ");
                        int searchId = Convert.ToInt32(Console.ReadLine());
                        users.SearchUser(searchId);
                        break;

                    case 3:
                        users.DisplayUsers();
                        break;

                    case 4:
                        Console.WriteLine("Exiting User Management System...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice != 4);
        }
    }
}
