using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            this.next = null; 
        }
    }
    internal class RemoveNode
    {
        public static void Main()
        {
            Console.WriteLine("enter the number of the Node");

            int n = int.Parse(Console.ReadLine());

            Node head = new Node(-1);
            Node temp = head;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter the value of {i+1} Node");
                int m = int.Parse(Console.ReadLine());
                temp.next = new Node(m);
                temp = temp.next; 
            }

            head = head.next;

            Console.WriteLine("Linked List Before Remove");
            print(head);


            Console.WriteLine("enter the number of the Nth node to delet from the Last");
            int k = int.Parse(Console.ReadLine());

            head = RemoveNthFromEnd(head, k);

            Console.WriteLine("Linked List After Remove");
            print(head);
        }
        public static void print(Node head)
        {
            Node temp = head;
            int n = LengthNode(temp);

            for (int i = 0; i < n-1; i++)
            {
                Console.Write($"{temp.data}->");
                temp = temp.next;
            }
            Console.Write($"{temp.data}->null");
            Console.WriteLine();
        }
        public static Node RemoveNthFromEnd(Node head,int k)
        {
            Node temp = head;
            int size = LengthNode(head);

            for (int i = 0; i < size-k-1; i++)
            {
                temp = temp.next;
            }
            Node t = temp.next.next;
            temp.next = t;
            return head;
        }

        public static int LengthNode(Node head)
        {
            Node temp = head;
            int count = 0;
            while(temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
    }
}
