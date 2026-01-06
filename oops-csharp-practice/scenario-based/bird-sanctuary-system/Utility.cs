using System;
using System.Collections.Generic;
using System.Text;

namespace Bird_Sanctuary_system
{
    public class Utility
    {
        public static void Main()
        {
            Bird[] birds = new Bird[5];

            birds[0] = new Eagle("Eagle", "Brown");
            birds[1] = new Sparrow("Sparrow","Grey");
            birds[2] = new Duck("Duck", "White");
            birds[3] = new Penguin("Penguin", "Black & White");
            birds[4] = new Seagull("Seagull", "White");

            for (int i = 0; i < birds.Length; i++)
            {
                birds[i].DisplayInfo();

                // Polymorphism using interface check
                if (birds[i] is IFlyable)
                {
                    ((IFlyable)birds[i]).Fly();
                }

                if (birds[i] is ISwimmable)
                {
                    ((ISwimmable)birds[i]).Swim();
                }

                Console.WriteLine();
            }
        }
    }
}
