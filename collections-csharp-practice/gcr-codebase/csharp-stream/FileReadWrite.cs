using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Stream
{
    internal class FileReadWrite
    {
        public static void Main()
        {
            string source = "source.txt";
            string destination = "destination.txt";

            if (!File.Exists(source))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }

            using (FileStream readStream = new FileStream(source, FileMode.Open, FileAccess.Read))
            using (FileStream writeStream = new FileStream(destination, FileMode.Create, FileAccess.Write))
            {
                int data;
                while ((data = readStream.ReadByte()) != -1)
                {
                    writeStream.WriteByte((byte)data);
                }
            }

            Console.WriteLine("File copied successfully.");
        }
    }
}
