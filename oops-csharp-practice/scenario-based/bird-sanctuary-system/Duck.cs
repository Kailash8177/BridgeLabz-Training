using System;
using System.Collections.Generic;
using System.Text;

namespace Bird_Sanctuary_system
{
    public class Duck : Bird, ISwimmable
    {
        public Duck(string name, string color) : base(name, color)
        {
        }
        public void Swim()
        {
            Console.WriteLine($"{name} is swimming in the pond.");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Duck Name: {name}, Color Code: {color}");
        }
    

    }
}
