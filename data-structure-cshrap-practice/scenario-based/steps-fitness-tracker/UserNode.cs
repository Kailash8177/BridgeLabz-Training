using System;
using System.Collections.Generic;
using System.Text;

namespace steps_fitness_tracker
{
    internal class UserNode
    {
        public string name;
        public int steps;
        public UserNode next;

        public UserNode(string name, int steps)
        {
            this.name = name;
            this.steps = steps;
            next = null;
        }
    }
}
