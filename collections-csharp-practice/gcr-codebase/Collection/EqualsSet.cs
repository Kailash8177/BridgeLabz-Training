using System;
class EqualsSet
{
    public static void Main(string[] args)
    {

        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 2, 1 };

        foreach (var item in set1)
        {
            if (!set2.Contains(item))
            {
                Console.WriteLine("stes are not equal");
                return;
            }
        }
        Console.WriteLine("stes are equal");

    }
}