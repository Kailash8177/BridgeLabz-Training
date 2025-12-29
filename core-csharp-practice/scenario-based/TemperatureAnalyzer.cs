//public class TemperatureAnalyzer
//{
//    public static void Main()
//    {
//        // 2D array to store temperatures for 7 days and 24 hours
//        float[,] temperatures = new float[7, 24];

//        // Random object to generate random temperature values
//        Random random = new Random();

//        // Filling the 2D array with random temperatures
//        // Range: -10°C to 50°C
//        for (int day = 0; day < temperatures.GetLength(0); day++)
//        {
//            for (int hour = 0; hour < temperatures.GetLength(1); hour++)
//            {
//                // NextDouble() gives value between 0.0 and 1.0
//                // -10 + (random * 60) → range becomes -10 to 50
//                temperatures[day, hour] = -10 + (float)(random.NextDouble() * 60);
//            }
//        }

//        // Creating object of class to call NON-static method
//        TemperatureAnalyzer analyzer = new TemperatureAnalyzer();

//        // Calling non-static method using object
//        analyzer.AnalyzeTemperature(temperatures);
//    }

//    // NON-STATIC method to analyze temperature data
//    public void AnalyzeTemperature(float[,] temp)
//    {
//        // Variables to store hottest and coldest day index
//        int hottestDay = 0;
//        int coldestDay = 0;

//        // Initializing hottest and coldest temperature
//        float hottestTemp = temp[0, 0];
//        float coldestTemp = temp[0, 0];

//        // Loop through each day
//        for (int day = 0; day < temp.GetLength(0); day++)
//        {
//            float sum = 0; // To calculate total temperature of the day

//            // Loop through each hour of the day
//            for (int hour = 0; hour < temp.GetLength(1); hour++)
//            {
//                float current = temp[day, hour];
//                sum += current;

//                // Check for hottest temperature
//                if (current > hottestTemp)
//                {
//                    hottestTemp = current;
//                    hottestDay = day;
//                }

//                // Check for coldest temperature
//                if (current < coldestTemp)
//                {
//                    coldestTemp = current;
//                    coldestDay = day;
//                }
//            }

//            // Calculating average temperature for the day
//            float average = sum / temp.GetLength(1);

//            // Printing average temperature of the day
//            Console.WriteLine("Average temperature of Day " + (day + 1) + " : " + average);
//        }

//        // Printing hottest and coldest day details
//        Console.WriteLine("\nHottest Day : Day " + (hottestDay + 1) + " with temp " + hottestTemp);
//        Console.WriteLine("Coldest Day : Day " + (coldestDay + 1) + " with temp " + coldestTemp);
//    }
//}