using System;
using System.Collections.Generic;
class SubSetList
{
    static void Main()
    {
        HashSet<int> setA = new HashSet<int> { 2, 3 };
        HashSet<int> setB = new HashSet<int> { 1, 2, 3, 4 };

        bool result = IsSubset(setA, setB);

        Console.WriteLine(result); // true
    }

    static bool IsSubset(HashSet<int> smallSet, HashSet<int> bigSet)
    {
        foreach (int item in smallSet)
        {
            if (!bigSet.Contains(item))
                return false;
        }

        return true;
    }
}