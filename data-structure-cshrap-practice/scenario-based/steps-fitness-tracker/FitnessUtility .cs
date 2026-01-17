using System;
using System.Collections.Generic;
using System.Text;

namespace steps_fitness_tracker
{
    internal class FitnessUtility : IFitnessOperations
    {
        private UserNode head;

        public void AddUser(string name, int steps)
        {
            UserNode newNode = new UserNode(name, steps);

            if (head == null)
            {
                head = newNode;
                return;
            }

            UserNode temp = head;
            while (temp.next != null)
                temp = temp.next;

            temp.next = newNode;
        }

        public void DisplayRanking()
        {
            if (head == null)
            {
                Console.WriteLine("No users available.");
                return;
            }

            UserNode temp = head;
            int rank = 1;

            while (temp != null)
            {
                Console.WriteLine($"{rank}. {temp.name} - {temp.steps} steps");
                rank++;
                temp = temp.next;
            }
        }

        public void SortBySteps()
        {
            if (head == null) return;

            bool swapped;

            do
            {
                swapped = false;
                UserNode current = head;

                while (current.next != null)
                {
                    if (current.steps < current.next.steps)
                    {
                        // swap data (not nodes)
                        int tempSteps = current.steps;
                        string tempName = current.name;

                        current.steps = current.next.steps;
                        current.name = current.next.name;

                        current.next.steps = tempSteps;
                        current.next.name = tempName;

                        swapped = true;
                    }
                    current = current.next;
                }
            } while (swapped);
        }
    }
}
