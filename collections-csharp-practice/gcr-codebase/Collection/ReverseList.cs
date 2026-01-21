using System;
using System.Collections;
using System.Collections.Generic;

public class ReverseList
{
    public static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);
        list.Add(50);

        list = ReverseArrayList(list);
        foreach (int i in list)
        {
            Console.Write(i + " ");
        }
        LinkedList<int> node = new LinkedList<int>();
        node.AddLast(10);
        node.AddLast(20);
        node.AddLast(30);
        node.AddLast(40);
        node.AddLast(50);

        node = ReverseLinkedList(node);
        Console.WriteLine();
        foreach (int i in node)
        {

            Console.Write(i + " ");
        }

    }
    public static ArrayList ReverseArrayList(ArrayList al)
    {
        int l = 0;
        int r = al.Count - 1;

        while (l < r)
        {
            object temp = al[l];
            al[l] = al[r];
            al[r] = temp;
            l++;
            r--;
        }

        return al;
    }

    public static LinkedList<int> ReverseLinkedList(LinkedList<int> list)
    {
        LinkedList<int> reversed = new LinkedList<int>();

        LinkedListNode<int> curr = list.Last;
        while (curr != null)
        {
            reversed.AddLast(curr.Value);
            curr = curr.Previous;
        }

        return reversed;
    }

}