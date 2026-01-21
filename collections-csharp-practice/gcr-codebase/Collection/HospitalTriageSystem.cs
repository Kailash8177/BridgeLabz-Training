class HospitalTriageSystem
{
    static void Main()
    {
        PriorityQueue<string, int> pq = new PriorityQueue<string, int>();

        // Enqueue patients (negative priority for max-heap behavior)
        pq.Enqueue("John", -3);
        pq.Enqueue("Alice", -5);
        pq.Enqueue("Bob", -2);

        Console.WriteLine("Treatment Order:");
        while (pq.Count > 0)
        {
            Console.WriteLine(pq.Dequeue());
        }
    }
}