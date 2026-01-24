using System;
using System.Collections.Generic;
using System.Text;

namespace Stream
{
    internal class LargeFileReader
    {
        public static void Main()
        {
            using (StreamReader reader = new StreamReader("large.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}
