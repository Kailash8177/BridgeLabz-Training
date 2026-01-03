//using System;
//using System.Collections.Generic;
//using System.Text;

///*
//A frequency array is used to count occurrences of each number.
//The array is traversed once.
//As soon as a number appears twice, it is returned.
//*/

//namespace BridgeLabzTraining.opps_chsarp_pracitce.leet_code
//{
//    public class RepeatedNTimesInArray
//    {
//        // Finds and returns the element repeated N times
//        public int FindRepeatedNTimesElement(int[] numbers)
//        {
//            // Frequency array to store count of elements
//            int[] frequency = new int[10000];

//            // Traverse each element in the array
//            foreach (int num in numbers)
//            {
//                // Increase count for current number
//                frequency[num]++;

//                // If count becomes 2, element is repeated
//                if (frequency[num] >= 2)
//                {
//                    return num;
//                }
//            }

//            // Safety return (problem guarantees a repeated element)
//            return 0;
//        }
//    }

//    // Entry point class
//    class RepeatedNTimesDriver
//    {
//        // Program execution starts here
//        static void Main(string[] args)
//        {
//            // Create object of solution class
//            RepeatedNTimesInArray solver = new RepeatedNTimesInArray();

//            // Input array


//            Console.WriteLine("Enter the Size of the array");

//            int n = int.Parse(Console.ReadLine()); 
//            int [] numbers = new int[n];

//            for (int i = 0; i < n; i++)
//            {
//                Console.WriteLine("Entes the " + i+1 + " Element");
//                numbers[i] = int.Parse(Console.ReadLine());
//            }

//            // Method call to find repeated element
//            int result = solver.FindRepeatedNTimesElement(numbers);

//            // Output result
//            Console.WriteLine("Repeated element is: " + result);
//        }
//    }

//}
