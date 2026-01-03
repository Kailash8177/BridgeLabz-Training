using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_constructor.level_1
{
    public class PersonUtility
    {
        public static void Main()
        {
            Person p1 = new Person("Aman", 22);
            Person p2 = new Person(p1);

            p1.Display();
            p2.Display();
        }
    }
    public class Person
    {
        public string Name;
        public int Age;

        // Parameterized constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Copy constructor
        public Person(Person p)
        {
            Name = p.Name;
            Age = p.Age;
        }

        public void Display()
        {
            Console.WriteLine($"{Name} - {Age}");
        }
    }


}
