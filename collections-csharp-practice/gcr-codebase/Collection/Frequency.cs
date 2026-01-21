using System;
public class Frequency
{
    public static void Main(string[] args)
    {
        List<string> l = new List<string>() { "apple", "banana", "apple", "orange" };
        Dictionary<string, int> d = new Dictionary<string, int>();

        foreach (string s in l)
        {
            if (d.ContainsKey(s))
            {
                d[s] = ++d[s];
            }
            else
            {
                d.Add(s, 1);
            }
        }

        foreach (var item in d)
        {
            Console.WriteLine($"{item.Key} {item.Value}");
        }
    }
}