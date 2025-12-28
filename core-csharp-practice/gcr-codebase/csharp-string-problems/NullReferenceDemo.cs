using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_string.level_1
{
    public class NullReferenceDemo
    {
        public static void Main()
        {
            try
            {
                string name = null;
                Console.WriteLine(name.Length);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NullReferenceException occurred");
            }
        }
    }
}
