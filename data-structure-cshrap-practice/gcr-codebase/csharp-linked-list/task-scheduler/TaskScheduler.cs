using System;
using System.Collections.Generic;
using System.Text;

namespace task_scheduler
{
    /*
 * TaskScheduler manages tasks using a Circular Singly Linked List.
 * The last node always points back to the head.
 */
    class TaskScheduler
    {
        TaskNode head;

        public void AddTask(int id, string name, int priority)
        {
            TaskNode node = new TaskNode(id, name, priority);
            if (head == null)
            {
                head = node;
                node.Next = head;
                return;
            }
            TaskNode temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            temp.Next = node;
            node.Next = head;
        }

        public void DisplayTasks()
        {
            if (head == null) return;

            TaskNode temp = head;
            do
            {
                Console.WriteLine($"{temp.TaskId} {temp.Name}");
                temp = temp.Next;
            } while (temp != head);
        }
    }
}
