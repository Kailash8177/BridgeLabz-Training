using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

class OverrideDemo
{
    static void TestOverride()
    {
        Animal a = new Dog();
        a.MakeSound();
    }

    public static void Main()
    {
        TestOverride();
    }
}
