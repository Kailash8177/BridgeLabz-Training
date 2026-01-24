using System;
using System.Collections.Generic;
using System.Text;

namespace Stream
{
    internal class UpperToLower
    {
        static void Main()
        {
            using (FileStream fs = new FileStream("input.txt", FileMode.Open))
            using (BufferedStream bs = new BufferedStream(fs))
            using (StreamReader reader = new StreamReader(bs))
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line.ToLower());
                }
            }

            Console.WriteLine("Conversion completed.");
        }
    }
}
