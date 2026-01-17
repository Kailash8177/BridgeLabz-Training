using System;
using System.Collections.Generic;
using System.Text;

namespace steps_fitness_tracker
{
    internal interface IFitnessOperations
    {
        void AddUser(string name, int steps);
        void DisplayRanking();
        void SortBySteps();
    }
}
