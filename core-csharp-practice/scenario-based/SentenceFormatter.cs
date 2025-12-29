//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Metrics;
//using System.Text;

//namespace BridgeLabzTraining.core_csharp_practice.Scenariobased
//{
//    public class SentenceFormatter
//    {
//        // Entry point of the program (Main hamesha static hota hai)
//        public static void Main()
//        {
//            // Object creation to call non-static methods
//            SentenceFormatter formatter = new SentenceFormatter();

//            // Ask user to enter a sentence
//            Console.WriteLine("Enter a sentence:");
//            string input = Console.ReadLine();

//            // Call non-static FormatSentence method using object
//            string formattedSentence = formatter.FormatSentence(input);

//            // Display result if sentence is valid
//            if (formattedSentence.Length != 0)
//            {
//                Console.WriteLine("Formatted Sentence:");
//                Console.WriteLine(formattedSentence);
//            }
//            else
//            {
//                Console.WriteLine("Please Enter The Correct Sentence");
//            }
//        }

//        // This method controls the complete formatting flow
//        // 1. Removes extra spaces
//        // 2. Fixes punctuation spacing
//        // 3. Capitalizes sentence characters
//        public string FormatSentence(string sentence)
//        {
//            // Check for null or empty input
//            if (sentence == null || sentence.Length == 0)
//            {
//                return string.Empty;
//            }

//            // Step 1: Remove extra spaces
//            string text = RemoveExtraSpace(sentence);

//            // Step 2: Ensure proper spacing after punctuation
//            text = FixPunctuationSpacing(text);

//            // Step 3: Capitalize characters based on rules
//            text = CapitalizeSentences(text);

//            return text;
//        }

//        // This method removes:
//        // - Leading spaces
//        // - Trailing spaces
//        // - Multiple spaces between words
//        // Without using Trim() or StringBuilder
//        public string RemoveExtraSpace(string sentence)
//        {
//            bool spaceFound = false; // Tracks last added character
//            string s = "";

//            // Loop through each character of the sentence
//            for (int i = 0; i < sentence.Length; i++)
//            {
//                char ch = sentence[i];

//                // Add a single space only when:
//                // - Previous character was not a space
//                // - Next character is not a space
//                if (ch == ' ' && spaceFound && i + 1 < sentence.Length && sentence[i + 1] != ' ')
//                {
//                    s += ' ';
//                    spaceFound = false;
//                }
//                // Add all non-space characters
//                else if (ch != ' ')
//                {
//                    s += ch;
//                    spaceFound = true;
//                }
//            }
//            return s;
//        }

//        // This method ensures that:
//        // - There is exactly one space after '.', '!', '?'
//        public string FixPunctuationSpacing(string sentence)
//        {
//            string s = "";

//            // Loop through each character
//            for (int i = 0; i < sentence.Length; i++)
//            {
//                char ch = sentence[i];
//                s += ch;

//                // If punctuation is found, add a space if missing
//                if (ch == '.' || ch == '!' || ch == '?')
//                {
//                    if (i + 1 < sentence.Length && sentence[i + 1] != ' ')
//                    {
//                        s += ' ';
//                    }
//                }
//            }
//            return s;
//        }

//        // This method capitalizes:
//        // - First character of the sentence
//        // - Character after '.', '?', '!', ',', or space
//        // Uses ASCII logic instead of built-in methods
//        public string CapitalizeSentences(string sentence)
//        {
//            string s = "";
//            bool capitalizeNext = true; // Indicates next letter should be capitalized

//            // Loop through each character
//            for (int i = 0; i < sentence.Length; i++)
//            {
//                char ch = sentence[i];

//                // Capitalize lowercase letter if flag is true
//                if (capitalizeNext && ch >= 'a' && ch <= 'z')
//                {
//                    s += (char)(ch - 32); // Convert to uppercase using ASCII
//                    capitalizeNext = false;
//                }
//                else
//                {
//                    s += ch;
//                }

//                // Set flag after punctuation or space
//                if (ch == '.' || ch == '?' || ch == '!' || ch == ',' || ch == ' ')
//                {
//                    capitalizeNext = true;
//                }
//            }
//            return s;
//        }
//    }
//}
