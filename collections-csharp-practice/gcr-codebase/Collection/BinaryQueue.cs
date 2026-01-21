class BinaryQueue
{
    public static void Main()
    {
        int N = 5;
        GenerateBinaryNumbers(N);
    }

    static void GenerateBinaryNumbers(int n)
    {
        Queue<string> q = new Queue<string>();
        q.Enqueue("1");

        for (int i = 0; i < n; i++)
        {
            string current = q.Dequeue();
            Console.Write(current + " ");

            q.Enqueue(current + "0");
            q.Enqueue(current + "1");
        }
    }
}