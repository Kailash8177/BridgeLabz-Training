class StringFrequency
{
    public static void Main()
    {
        string text = "Hello world, hello Java!";

        Dictionary<string, int> frequency = CountWordFrequency(text);

        Console.WriteLine("Word Frequency:");
        foreach (var item in frequency)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }
    }

    public static Dictionary<string, int> CountWordFrequency(string text)
    {
        Dictionary<string, int> map = new Dictionary<string, int>();

        // Step 1: lowercase
        text = text.ToLower();

        // Step 2: remove punctuation
        char[] separators = { ' ', ',', '!', '.', '?' };
        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        // Step 3: count words
        foreach (string word in words)
        {
            if (map.ContainsKey(word))
                map[word]++;
            else
                map[word] = 1;
        }

        return map;
    }
}