using System;
using System.Collections.Generic;
using System.Text;

namespace round_robin_scheduling
{
    /*
 * ProcessScheduler manages processes using a Circular Linked List.
 * Last process always points back to the head (Round Robin behavior).
 */
    class ProcessScheduler
    {
        private ProcessNode head;

        // Add process at the end of circular list
        public void AddProcess(int id, int burst)
        {
            ProcessNode node = new ProcessNode(id, burst);

            // If list is empty
            if (head == null)
            {
                head = node;
                node.Next = head; // Circular link
                return;
            }

            // Traverse to last node
            ProcessNode temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }

            temp.Next = node;
            node.Next = head;
        }

        // Display all processes
        public void DisplayProcesses()
        {
            if (head == null)
            {
                Console.WriteLine("No processes available");
                return;
            }

            ProcessNode temp = head;
            Console.WriteLine("\nProcess List:");
            do
            {
                Console.WriteLine($"PID: {temp.Pid}, Burst Time: {temp.Burst}");
                temp = temp.Next;
            }
            while (temp != head);
        }

        // Simulate Round Robin execution
        public void ExecuteRoundRobin(int timeQuantum)
        {
            if (head == null)
            {
                Console.WriteLine("No processes to execute");
                return;
            }

            ProcessNode temp = head;
            Console.WriteLine("\n--- Round Robin Execution ---");

            do
            {
                if (temp.Burst > 0)
                {
                    int executed = Math.Min(temp.Burst, timeQuantum);
                    temp.Burst -= executed;

                    Console.WriteLine(
                        $"Process {temp.Pid} executed for {executed} units, Remaining Burst: {temp.Burst}"
                    );
                }

                temp = temp.Next;

            } while (temp != head);
        }
    }
}
