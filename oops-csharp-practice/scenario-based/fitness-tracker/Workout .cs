using System;
using System.Collections.Generic;
using System.Text;

namespace fitness_tracker
{
    internal abstract class Workout : ITrackable
    {

        private string workoutType;
        private int durationInMinutes;

        public string WorkoutType
        {
            get { return workoutType; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    workoutType = value;
                else
                    Console.WriteLine("Workout name cannot be empty");
            }
        }
        public int DurationInMinutes
        {
            get { return durationInMinutes; }
            set
            {
                if (value > 0)
                    durationInMinutes = value;
                else
                    Console.WriteLine("Duration must be greater than zero");
            }
        }

        public abstract int CalculateCalories();
        public abstract void TrackWorkout();
    }
}
