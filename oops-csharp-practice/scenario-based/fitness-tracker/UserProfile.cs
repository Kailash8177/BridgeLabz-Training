using System;
using System.Collections.Generic;
using System.Text;

namespace fitness_tracker
{
    internal class UserProfile
    {
        private string userName;

        public string UserName
        {
            get { return userName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    userName = value;
                else
                    Console.WriteLine("User name cannot be empty");
            }
        }
        public void StartWorkout(Workout workout)
        {
            Console.WriteLine("\n----- Workout Summary -----");
            Console.WriteLine($"User: {UserName}");
            workout.TrackWorkout();
            Console.WriteLine($"Calories Burned: {workout.CalculateCalories()}");
        }

    }

}
