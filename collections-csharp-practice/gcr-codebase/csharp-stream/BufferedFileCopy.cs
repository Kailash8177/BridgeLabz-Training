using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;

namespace Stream
{
    internal class BufferedFileCopy
    {
        static void Main()
        {
            string source = "largefile.dat";
            string bufferedDest = "buffered.dat";
            string normalDest = "normal.dat";

            CopyNormal(source, normalDest);
            CopyBuffered(source, bufferedDest);
        }

        static void CopyNormal(string source, string dest)
        {
            Stopwatch sw = Stopwatch.StartNew();

            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (FileStream fsWrite = new FileStream(dest, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[4096];
                int bytesRead;

                while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fsWrite.Write(buffer, 0, bytesRead);
                }
            }

            sw.Stop();
            Console.WriteLine($"Normal Stream Time: {sw.ElapsedMilliseconds} ms");
        }

        static void CopyBuffered(string source, string dest)
        {
            Stopwatch sw = Stopwatch.StartNew();

            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (FileStream fsWrite = new FileStream(dest, FileMode.Create, FileAccess.Write))
            using (BufferedStream bsRead = new BufferedStream(fsRead))
            using (BufferedStream bsWrite = new BufferedStream(fsWrite))
            {
                byte[] buffer = new byte[4096];
                int bytesRead;

                while ((bytesRead = bsRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    bsWrite.Write(buffer, 0, bytesRead);
                }
            }

            sw.Stop();
            Console.WriteLine($"Buffered Stream Time: {sw.ElapsedMilliseconds} ms");
        }
    }
}
