//using System;
//using System.Collections.Generic;
//using System.Text;
//using static System.Net.Mime.MediaTypeNames;

//namespace BridgeLabzTraining.core_csharp_practice.Scenariobased
//{
//    public class ParagraphAnalyzer
//    {
//        // Entry point of the program (Main static hi rahega)
//        public static void Main()
//        {
//            // Object creation to call non-static methods
//            ParagraphAnalyzer analyzer = new ParagraphAnalyzer();

//            bool exit = false;

//            // Loop continues until user chooses to exit
//            while (!exit)
//            {
//                // Taking paragraph input from user
//                Console.WriteLine("Enter a paragraph:");
//                string paragraph = Console.ReadLine();

//                // If input is empty or null, exit the program
//                if (paragraph == null || paragraph.Length == 0)
//                {
//                    exit = true;
//                    break;
//                }

//                // Display menu options
//                Console.WriteLine("Choose an option:");
//                Console.WriteLine("1 -> ● Count the number of word ");
//                Console.WriteLine("2 -> ● the longest word");
//                Console.WriteLine("3 -> ● replace the word ");
//                Console.WriteLine("4 -> ● exit ");

//                // Reading user choice
//                int choice = int.Parse(Console.ReadLine());

//                // Perform action based on user choice
//                switch (choice)
//                {
//                    case 1:
//                        // Calling non-static method using object
//                        Console.WriteLine("The number of the word in the sentence "
//                            + analyzer.CountWords(paragraph));
//                        break;

//                    case 2:
//                        // Calling non-static method using object
//                        Console.WriteLine("The longest word in the sentence "
//                            + analyzer.FindLongestWord(paragraph));
//                        break;

//                    case 3:
//                        // Calling non-static method using object
//                        Console.WriteLine("After replacing the word the paragraph is:"
//                            + analyzer.ReplaceWord(paragraph));
//                        break;

//                    case 4:
//                        // Exit the loop and program
//                        exit = true;
//                        break;
//                }
//            }
//        }

//        // Non-static method to count words
//        public int CountWords(string paragraph)
//        {
//            int count = 0;
//            bool flag = false;

//            for (int i = 0; i < paragraph.Length; i++)
//            {
//                if (paragraph[i] != ' ' && !flag)
//                {
//                    count++;
//                    flag = true;
//                }
//                else if (paragraph[i] == ' ')
//                {
//                    flag = false;
//                }
//            }
//            return count;
//        }

//        // Non-static method to find longest word
//        public string FindLongestWord(string paragraph)
//        {
//            string longest = "";
//            string current = "";

//            for (int i = 0; i < paragraph.Length; i++)
//            {
//                char ch = paragraph[i];

//                if (ch != ' ')
//                {
//                    current += ch;
//                }
//                else
//                {
//                    if (current.Length > longest.Length)
//                    {
//                        longest = current;
//                    }
//                    current = "";
//                }
//            }

//            if (current.Length > longest.Length)
//            {
//                longest = current;
//            }

//            return longest;
//        }

//        // Non-static method to replace word
//        public string ReplaceWord(string paragraph)
//        {
//            Console.WriteLine("Enter the word to be replaced:");
//            string oldWord = Console.ReadLine();

//            Console.WriteLine("Enter the new word:");
//            string newWord = Console.ReadLine();

//            if (oldWord == null || oldWord.Length == 0)
//            {
//                return paragraph;
//            }

//            string result = "";
//            string current = "";

//            for (int i = 0; i < paragraph.Length; i++)
//            {
//                char ch = paragraph[i];

//                if (ch != ' ')
//                {
//                    current += ch;
//                }
//                else
//                {
//                    if (current.Equals(oldWord, StringComparison.OrdinalIgnoreCase))
//                    {
//                        result += newWord;
//                    }
//                    else
//                    {
//                        result += current;
//                    }
//                    result += ' ';
//                    current = "";
//                }
//            }

//            if (current.Equals(oldWord, StringComparison.OrdinalIgnoreCase))
//            {
//                result += newWord;
//            }
//            else
//            {
//                result += current;
//            }

//            return result;
//        }
//    }
//}
