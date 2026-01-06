using System;
using System.Collections.Generic;
using System.Text;

namespace Bird_Sanctuary_system
{
    public class Seagull : Bird, IFlyable, ISwimmable
    {
        public Seagull(string name, string color) : base(name, color)
        {
        }
        public void Fly()
        {
            Console.WriteLine($"{name} is gliding over the ocean waves.");
        }
        public void Swim()
        {
            Console.WriteLine($"{name} is swimming near the shore.");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Seagull Name: {name}, Color Code: {color}");
        }
    }
}
