using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_inheritance
{
    // ---------------- Superclass ----------------
    class Animal
    {
        // Common properties for all animals
        public string Name;
        public int Age;

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    // ---------------- Subclass: Dog ----------------
    class Dog : Animal
    {
        // Override parent method
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    // ---------------- Subclass: Cat ----------------
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    // ---------------- Subclass: Bird ----------------
    class Bird : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bird chirps");
        }
    }

    // ---------------- Main Class ----------------
    class AnimalUtility
    {
        public static void Main()
        {
            // Parent reference holding child objects (Polymorphism)
            Animal animal1 = new Dog();
            Animal animal2 = new Cat();
            Animal animal3 = new Bird();

            // Runtime method binding
            animal1.MakeSound();
            animal2.MakeSound();
            animal3.MakeSound();
        }
    }
}
