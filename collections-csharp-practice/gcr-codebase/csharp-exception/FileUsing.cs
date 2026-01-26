using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    internal class FileUsingDemo
    {
        public static void Main()
        {
            try
            {
                using (StreamReader reader = new StreamReader("info.txt"))
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error reading file");
            }
        }
    }

}
