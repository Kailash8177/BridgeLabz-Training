using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods
{
    public class HandshakesSecond
    {
        public static void Main()
        {
            int numberOfStudents;
            int handshakes;

            numberOfStudents = int.Parse(Console.ReadLine());

            handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

            Console.WriteLine(handshakes);
        }
    }
}
