using System;
using System.Collections.Generic;
using System.Text;

namespace Stream
{
    internal class StudentBinaryData
    {
        public static void Main()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("student.dat", FileMode.Create)))
            {
                writer.Write(101);
                writer.Write("Rahul");
                writer.Write(8.9);
            }

            using (BinaryReader reader = new BinaryReader(File.Open("student.dat", FileMode.Open)))
            {
                Console.WriteLine("Roll: " + reader.ReadInt32());
                Console.WriteLine("Name: " + reader.ReadString());
                Console.WriteLine("GPA: " + reader.ReadDouble());
            }
        }
    }
}
