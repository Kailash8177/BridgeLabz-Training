using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.extra_csharp_string
{
    public class ReplaceWord
    {
        public static void Main()
        {
            string sentence = Console.ReadLine();
            string oldWord = Console.ReadLine();
            string newWord = Console.ReadLine();

            string result = sentence.Replace(oldWord, newWord);
            Console.WriteLine(result);
        }
    }
}
