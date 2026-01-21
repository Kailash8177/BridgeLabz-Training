class Ivertmap
{
     static void Main()
    {
        Dictionary<string, int> input = new Dictionary<string, int>
        {
            { "A", 1 },
            { "B", 2 },
            { "C", 1 }
        };

        Dictionary<int, List<string>> inverted = InvertDictionary(input);

        Console.WriteLine("Inverted Map:");
        foreach (var item in inverted)
        {
            Console.WriteLine(item.Key + " -> [" + string.Join(", ", item.Value) + "]");
        }
    }

    static Dictionary<int, List<string>> InvertDictionary(
        Dictionary<string, int> dict)
    {
        Dictionary<int, List<string>> result =
            new Dictionary<int, List<string>>();

        foreach (var item in dict)
        {
            int value = item.Value;
            string key = item.Key;

            if (!result.ContainsKey(value))
            {
                result[value] = new List<string>();
            }

            result[value].Add(key);
        }

        return result;
    }
}