using System;
using System.Collections.Generic;
using System.Text;

namespace Bird_Sanctuary_system
{
    public class Eagle : Bird , IFlyable
    {
        public Eagle(string name, string color): base(name, color)
        {
        }
        public void Fly()
        {
            Console.WriteLine($"{name} is soaring high in the sky!");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Eagle Name: {name}, Color Code: {color}");
        }
    }
}
