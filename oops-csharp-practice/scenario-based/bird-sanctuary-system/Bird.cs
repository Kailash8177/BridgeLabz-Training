using System;
using System.Collections.Generic;
using System.Text;

namespace Bird_Sanctuary_system
{
    public abstract class Bird
    {
        protected string name;
        protected string color;

        public Bird(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public abstract void DisplayInfo();
    }
}
