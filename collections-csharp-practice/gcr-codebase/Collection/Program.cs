using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

        HashSet<int> result = SymmetricDifference(set1, set2);

        Console.WriteLine("Symmetric Difference: " +
                          string.Join(", ", result));
    }

    static HashSet<int> SymmetricDifference(
        HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> result = new HashSet<int>();

        // Elements in set1 but not in set2
        foreach (int item in set1)
        {
            if (!set2.Contains(item))
                result.Add(item);
        }

        // Elements in set2 but not in set1
        foreach (int item in set2)
        {
            if (!set1.Contains(item))
                result.Add(item);
        }

        return result;
    }
}
