using System;
using System.Collections.Generic;
using System.Text;

namespace Bird_Sanctuary_system
{
    public class Penguin : Bird, ISwimmable
    {
        public Penguin(string name, string color) : base(name, color)
        {
        }
        public void Swim()
        {
            Console.WriteLine($"{name} is swimming swiftly in the icy waters.");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Penguin Name: {name}, Color Code: {color}");
        }
    }
    
    
}
