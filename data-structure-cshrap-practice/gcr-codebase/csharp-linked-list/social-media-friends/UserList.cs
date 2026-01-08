using System;
using System.Collections.Generic;
using System.Text;

namespace social_media_friends
{
    /*
  * UserList manages users using a Singly Linked List.
  */
    class UserList
    {
        private UserNode head; // Points to the first user

        // Add user at the end of the list
        public void AddUser(int id, string name)
        {
            UserNode node = new UserNode(id, name);

            // If list is empty
            if (head == null)
            {
                head = node;
                return;
            }

            // Traverse to the last node
            UserNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = node;
        }

        // Search user by ID
        public void SearchUser(int id)
        {
            UserNode temp = head;

            while (temp != null)
            {
                if (temp.UserId == id)
                {
                    Console.WriteLine($"User Found → ID: {temp.UserId}, Name: {temp.Name}");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("User not found");
        }

        // Display all users
        public void DisplayUsers()
        {
            if (head == null)
            {
                Console.WriteLine("No users available");
                return;
            }

            UserNode temp = head;
            Console.WriteLine("\nUsers List:");
            while (temp != null)
            {
                Console.WriteLine($"ID: {temp.UserId}, Name: {temp.Name}");
                temp = temp.Next;
            }
        }
    }

}
