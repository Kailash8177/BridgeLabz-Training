using System;
using System.Collections.Generic;
using System.Text;

namespace algorithm_runtime_analysis
{
    internal class FileReadComparison
    {
        static void Main()
        {
            string path = "largefile.txt";

            var sw = System.Diagnostics.Stopwatch.StartNew();
            using (StreamReader reader = new StreamReader(path))
            {
                while (reader.ReadLine() != null) { }
            }
            sw.Stop();
            Console.WriteLine($"StreamReader: {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                byte[] buffer = new byte[8192];
                while (fs.Read(buffer, 0, buffer.Length) > 0) { }
            }
            sw.Stop();
            Console.WriteLine($"FileStream: {sw.ElapsedMilliseconds} ms");
        }
    }
}
