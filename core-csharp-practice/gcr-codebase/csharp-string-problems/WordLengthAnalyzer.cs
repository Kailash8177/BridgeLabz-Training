using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_string.level_1
{
    public class WordLengthAnalyzer
    {
        public static void Main()
        {
            string text = "C Sharp Programming";
            string[,] words = new string[10, 2];

            string word = "";
            int row = 0;

            for (int i = 0; i < GetLength(text); i++)
            {
                if (text[i] != ' ')
                {
                    word += text[i];
                }
                else
                {
                    words[row, 0] = word;
                    words[row, 1] = GetLength(word).ToString();
                    row++;
                    word = "";
                }
            }

            words[row, 0] = word;
            words[row, 1] = GetLength(word).ToString();

            Console.WriteLine("Word\tLength");
            for (int i = 0; i <= row; i++)
            {
                Console.WriteLine(words[i, 0] + "\t" + words[i, 1]);
            }
        }

        public static int GetLength(string text)
        {
            int count = 0;
            foreach (char c in text)
                count++;
            return count;
        }
    }
}
