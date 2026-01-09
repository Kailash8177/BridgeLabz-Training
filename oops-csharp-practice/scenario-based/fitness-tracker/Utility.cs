using System;
using System.Collections.Generic;
using System.Text;

namespace fitness_tracker
{
    internal class Utility
    {
        public static void Main()
        {
            UserProfile user = new UserProfile();

            Console.Write("Enter User Name: ");
            user.UserName = Console.ReadLine();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- FITTRACK MENU ---");
                Console.WriteLine("1. Cardio Workout");
                Console.WriteLine("2. Strength Workout");
                Console.WriteLine("3. Exit");
                Console.Write("Choose option: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Enter a number.");
                    continue;
                }

                Workout workout = null;

                switch (choice)
                {
                    case 1:
                        CardioWorkOut cardio = new CardioWorkOut();

                        Console.Write("Enter Workout Name: ");
                        cardio.WorkoutType = Console.ReadLine();

                        Console.Write("Enter Duration (minutes): ");
                        cardio.DurationInMinutes = int.Parse(Console.ReadLine());

                        Console.Write("Enter Distance (km): ");
                        cardio.DistanceInKm = int.Parse(Console.ReadLine());

                        workout = cardio;
                        user.StartWorkout(workout);
                        break;

                    case 2:
                        StrengthWorkout strength = new StrengthWorkout();

                        Console.Write("Enter Workout Name: ");
                        strength.WorkoutType = Console.ReadLine();

                        Console.Write("Enter Duration (minutes): ");
                        strength.DurationInMinutes = int.Parse(Console.ReadLine());

                        Console.Write("Enter Sets: ");
                        strength.Sets = int.Parse(Console.ReadLine());

                        workout = strength;
                        user.StartWorkout(workout);
                        break;

                    case 3:
                        exit = true;
                        Console.WriteLine("Exiting FitTrack. Stay Fit! 💪");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
