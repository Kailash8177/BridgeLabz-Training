using System;
using System.Collections.Generic;
using System.Text;

namespace fitness_tracker
{
    internal class StrengthWorkout : Workout
    {
        private int sets;

        public int Sets
        {
            get { return sets; }
            set
            {
                if (value > 0)
                    sets = value;
                else
                    Console.WriteLine("Sets must be greater than zero");
            }
        }

        public override int CalculateCalories()
        {
            return DurationInMinutes * 5;
        }

        public override void TrackWorkout()
        {
            Console.WriteLine($"Workout Type: Strength");
            Console.WriteLine($"Name: {WorkoutType}");
            Console.WriteLine($"Duration: {DurationInMinutes} mins");
            Console.WriteLine($"Sets: {Sets}");
        }
    }
}
