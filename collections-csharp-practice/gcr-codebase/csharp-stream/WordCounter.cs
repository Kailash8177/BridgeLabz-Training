using System;
using System.Collections.Generic;
using System.Text;

namespace Stream
{
    internal class WordCounter
    {
        public static void Main()
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            using (StreamReader reader = new StreamReader("text.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ', ',', '.', '!' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {
                        string w = word.ToLower();
                        if (wordCount.ContainsKey(w))
                            wordCount[w]++;
                        else
                            wordCount[w] = 1;
                    }
                }
            }

            foreach (var item in wordCount.OrderByDescending(x => x.Value).Take(5))
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
