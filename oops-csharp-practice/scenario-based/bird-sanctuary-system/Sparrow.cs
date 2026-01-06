using System;
using System.Collections.Generic;
using System.Text;

namespace Bird_Sanctuary_system
{
    public class Sparrow : Bird, IFlyable
    {
        public Sparrow(string name, string color): base(name, color)
        {
        }
        public void Fly()
        {
            Console.WriteLine($"{name} is flying between trees.");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Sparrow Name: {name}, Color Code: {color}");
        }
    }
}
