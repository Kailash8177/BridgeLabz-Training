using System;
using System.Collections.Generic;
using System.Text;

namespace linear_binary_search
{
    internal class SearchWordInSentence
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number of sentences: ");
            int n = int.Parse(Console.ReadLine());

            string[] sentences = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Sentence {i + 1}: ");
                sentences[i] = Console.ReadLine();
            }

            Console.Write("Enter word to search: ");
            string word = Console.ReadLine();

            SearchWordInSentences(sentences, word);
        }

        public static void SearchWordInSentences(string[] sentences, string word)
        {
            for (int i = 0; i < sentences.Length; i++)
            {
                if (sentences[i].Contains(word))
                {
                    Console.WriteLine("Found in: " + sentences[i]);
                    return;
                }
            }

            Console.WriteLine("Word not found.");
        }
    }
}
