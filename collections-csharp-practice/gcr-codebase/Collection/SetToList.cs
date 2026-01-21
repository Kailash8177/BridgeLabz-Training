class SetToList
{
     static void Main()
    {
        HashSet<int> set = new HashSet<int> { 5, 3, 9, 1 };

        List<int> sortedList = ConvertAndSort(set);

        Console.WriteLine("Sorted List:");
        foreach (int x in sortedList)
        {
            Console.Write(x + " ");
        }
    }

    static List<int> ConvertAndSort(HashSet<int> set)
    {
        // Step 1: Convert HashSet to List
        List<int> list = new List<int>(set);

        // Step 2: Manual sorting (Ascending)
        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = i + 1; j < list.Count; j++)
            {
                if (list[i] > list[j])
                {
                    int temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            }
        }

        return list;
    }
}