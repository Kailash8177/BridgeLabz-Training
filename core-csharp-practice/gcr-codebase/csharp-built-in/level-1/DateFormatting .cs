using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_builtin.level_1
{
    public class DateFormatting
    {
        public static void Main()
        {

            DateTime today = DateTime.Now;
            Console.WriteLine(today.ToString("dd/MM/yyyy"));
            Console.WriteLine(today.ToString("yyyy-MM-dd"));
            Console.WriteLine(today.ToString("ddd, MMM dd, yyyy"));
        }
    }
}
