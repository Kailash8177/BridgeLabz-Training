using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Stream
{
    internal class ConsoleToFile
    {
        public static void Main()
        {
            using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
            using (StreamWriter writer = new StreamWriter("userData.txt"))
            {
                Console.Write("Enter Name: ");
                string name = reader.ReadLine();

                Console.Write("Enter Age: ");
                string age = reader.ReadLine();

                Console.Write("Favorite Programming Language: ");
                string language = reader.ReadLine();

                writer.WriteLine($"Name: {name}");
                writer.WriteLine($"Age: {age}");
                writer.WriteLine($"Language: {language}");
            }

            Console.WriteLine("Data saved successfully.");
        }
    }
}
