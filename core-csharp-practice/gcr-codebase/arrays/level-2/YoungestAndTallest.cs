//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.array.level_2
//{
//    public class YoungestAndTallest
//    {
//        public static void Main()
//        {

//            string[] names = { "Amar", "Akbar", "Anthony" };
//            int[] age = new int[3];
//            int[] height = new int[3];

//            for (int i = 0; i < 3; i++)
//            {
//                age[i] = int.Parse(Console.ReadLine());
//                height[i] = int.Parse(Console.ReadLine());
//            }

//            int youngIndex = 0;
//            int tallIndex = 0;

//            for (int i = 1; i < 3; i++)
//            {
//                if (age[i] < age[youngIndex])
//                {
//                    youngIndex = i;
//                }

//                if (height[i] > height[tallIndex])
//                {
//                    tallIndex = i;
//                }
//            }

//            Console.WriteLine("Youngest Friend = " + names[youngIndex]);
//            Console.WriteLine("Tallest Friend = " + names[tallIndex]);
//        }
//    }
//}
