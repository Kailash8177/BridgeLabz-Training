using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueHashMap
{
    public class QueueUsingStacks<T>
    {
        private Stack<T> stack1 = new Stack<T>();
        private Stack<T> stack2 = new Stack<T>();

        // Enqueue operation
        public void Enqueue(T item)
        {
            stack1.Push(item);
            Console.WriteLine($"Enqueued: {item}");
        }

        // Dequeue operation
        public T Dequeue()
        {
            if (stack2.Count == 0)
            {
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }

            if (stack2.Count == 0)
                throw new InvalidOperationException("Queue is empty");

            return stack2.Pop();
        }
    }

    class QueueDemo   // 👈 Main class name changed here
    {
        public static void Main(string[] args)
        {
            QueueUsingStacks<int> queue = new QueueUsingStacks<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine("Dequeued: " + queue.Dequeue());
            Console.WriteLine("Dequeued: " + queue.Dequeue());

            queue.Enqueue(40);

            Console.WriteLine("Dequeued: " + queue.Dequeue());
            Console.WriteLine("Dequeued: " + queue.Dequeue());
        }
    }
}
