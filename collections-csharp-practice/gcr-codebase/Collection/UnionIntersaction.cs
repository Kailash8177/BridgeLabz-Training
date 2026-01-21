class UnionIntersaction
{
    public static void Main(string[] args)
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

        HashSet<int> union = Union(set1, set2);
        HashSet<int> intersection = Intersection(set1, set2);

        Console.WriteLine("Union: " + string.Join(", ", union));
        Console.WriteLine("Intersection: " + string.Join(", ", intersection));
    }
    public static HashSet<int> Union(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> result = new HashSet<int>();

        foreach (var item in set1)
        {
            result.Add(item);
        }
        foreach (var item in set2)
        {
            if (!result.Contains(item))
                result.Add(item);
        }
        return result;
    }
    public static HashSet<int> Intersection(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> result = new HashSet<int>();

        foreach (int item in set1)
        {
            if (set2.Contains(item))
                result.Add(item);
        }

        return result;
    }
}