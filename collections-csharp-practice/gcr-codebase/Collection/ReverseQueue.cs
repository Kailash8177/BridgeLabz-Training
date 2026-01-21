class ReverseQueue
{
     public static void Main()
    {
        Queue<int> q = new Queue<int>();
        q.Enqueue(10);
        q.Enqueue(20);
        q.Enqueue(30);

        ReverseQueu(q);

        Console.WriteLine("Reversed Queue:");
        while (q.Count > 0)
        {
            Console.Write(q.Dequeue() + " ");
        }
    }

    public static void ReverseQueu(Queue<int> q)
    {
        if (q.Count == 0)
            return;

        int front = q.Dequeue();
        ReverseQueu(q);
        q.Enqueue(front);
    }
}