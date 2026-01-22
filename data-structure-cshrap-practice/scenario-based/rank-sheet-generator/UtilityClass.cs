using System;
using System.Collections.Generic;
using System.Text;

namespace rank_sheet_generator
{
    class UtilityClass
    {
        static List<Student> allStudents = new List<Student>();

        static void Main()
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== EduResults Rank Sheet Generator =====");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Generate Rank Sheet");
                Console.WriteLine("3. Display All Students");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;

                    case 2:
                        GenerateRankSheet();
                        break;

                    case 3:
                        DisplayStudents();
                        break;

                    case 4:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 4);
        }

        static void AddStudent()
        {
            Console.Write("Enter Roll No: ");
            int roll = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Marks: ");
            int marks = int.Parse(Console.ReadLine());

            allStudents.Add(new Student(roll, name, marks));
            Console.WriteLine("Student added successfully.");
        }

        static void GenerateRankSheet()
        {
            if (allStudents.Count == 0)
            {
                Console.WriteLine("No students available!");
                return;
            }

            var sortedList = MergeSortUtility.MergeSort(allStudents);

            Console.WriteLine("\n📊 State-Wise Rank Sheet (Ascending Marks)");
            int rank = 1;
            foreach (var s in sortedList)
            {
                Console.WriteLine($"Rank {rank++}: {s.Name} | Marks: {s.Marks}");
            }
        }

        static void DisplayStudents()
        {
            if (allStudents.Count == 0)
            {
                Console.WriteLine("No students available!");
                return;
            }

            Console.WriteLine("\n--- Student List ---");
            foreach (var s in allStudents)
            {
                Console.WriteLine($"Roll: {s.RollNo}, Name: {s.Name}, Marks: {s.Marks}");
            }
        }
    }

}
