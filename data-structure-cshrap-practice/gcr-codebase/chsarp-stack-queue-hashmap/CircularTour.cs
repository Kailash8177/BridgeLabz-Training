using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueHashMap
{
    public class CircularTour
    {
        public static int FindStartingPoint(int[] petrol, int[] distance)
        {
            int start = 0, surplus = 0, deficit = 0;

            for (int i = 0; i < petrol.Length; i++)
            {
                surplus += petrol[i] - distance[i];

                if (surplus < 0)
                {
                    start = i + 1;
                    deficit += surplus;
                    surplus = 0;
                }
            }

            return (surplus + deficit >= 0) ? start : -1;
        }
    }

    //  Logical Main class
    class CircularTourDemo
    {
        public static void Main(string[] args)
        {
            int[] petrol = { 4, 6, 7, 4 };
            int[] distance = { 6, 5, 3, 5 };

            int startPoint = CircularTour.FindStartingPoint(petrol, distance);

            if (startPoint != -1)
                Console.WriteLine("Start the tour from petrol pump index: " + startPoint);
            else
                Console.WriteLine("No possible circular tour");
        }
    }
}
