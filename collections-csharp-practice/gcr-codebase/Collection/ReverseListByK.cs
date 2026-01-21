public class ReverseListByK
{
    public static void Main(string[] args)
    {
        List<int> list = new List<int> { 10, 20, 30, 40, 50 };
        int k = 2;

        List<int> rotated = RotateLeft(list, k);

        foreach (int x in rotated)
            Console.Write(x + " ");
    }

    public static List<int> RotateLeft(List<int> list, int k)
    {
        int n = list.Count;
        k = k % n;

        List<int> result = new List<int>();

        for (int i = k; i < n; i++)
            result.Add(list[i]);

        for (int i = 0; i < k; i++)
            result.Add(list[i]);

        return result;
    }
}