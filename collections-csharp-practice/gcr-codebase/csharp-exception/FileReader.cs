using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    internal class FileReader
    {
        public static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText("data.txt");
                Console.WriteLine(content);
            }
            catch (IOException)
            {
                Console.WriteLine("File not found");
            }
        }
    }
}
