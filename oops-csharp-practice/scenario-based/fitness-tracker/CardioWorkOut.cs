using System;
using System.Collections.Generic;
using System.Text;

namespace fitness_tracker
{
    internal class CardioWorkOut : Workout
    {
        private int distanceInKm;

        public int DistanceInKm
        {
            get { return distanceInKm; }
            set
            {
                if (value > 0)
                    distanceInKm = value;
                else
                    Console.WriteLine("Distance must be greater than zero");
            }
        }

        public override int CalculateCalories()
        {
            return DurationInMinutes * 8;
        }

        public override void TrackWorkout()
        {
            Console.WriteLine($"Workout Type: Cardio");
            Console.WriteLine($"Name: {WorkoutType}");
            Console.WriteLine($"Duration: {DurationInMinutes} mins");
            Console.WriteLine($"Distance: {DistanceInKm} km");
        }

    }
}
