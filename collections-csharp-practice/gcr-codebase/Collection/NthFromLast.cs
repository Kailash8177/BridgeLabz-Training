class NthFromLast
{
    public static void Main(string[] args)
    {
        LinkedList<string> list = new LinkedList<string>();
        list.AddLast("A");
        list.AddLast("B");
        list.AddLast("C");
        list.AddLast("D");
        list.AddLast("E");

        int N = 2;

        string result = NthFromEnd(list, N);
        Console.WriteLine(result);
    }

    static string NthFromEnd(LinkedList<string> list, int n)
    {
        LinkedListNode<string>? fast = list.First;
        LinkedListNode<string>? slow = list.First;

        for (int i = 0; i < n; i++)
        {
            fast = fast.Next;
        }

        while (fast != null)
        {
            fast = fast.Next;
            slow = slow.Next;
        }
        return slow.Value;
    }

}