public class RemoveDuplicate
{
    public static void Main(string [] args)
    {
        List<int> list = new List<int> { 3, 1, 2, 2, 3, 4 };

        HashSet<int> set = new HashSet<int>();

        foreach (int item in list)
        {
           set.Add(item);
        }

        foreach (var item in set)
        {
            Console.WriteLine(item);
        }
    }
}