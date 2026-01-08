using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.datastructure_csharp_practice.LiknedList_csharp_problem.student_record_management
{
    /*
 * Main class: Takes user input and interacts with StudentList
 */
    public class Utility
    {
        public static void Main()
        {
            StudentList list = new StudentList();
            int choice;

            do
            {
                Console.WriteLine("\n--- Student Record Management ---");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Delete Student");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Update Grade");
                Console.WriteLine("5. Display All Students");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Roll No: ");
                        int roll = int.Parse(Console.ReadLine());

                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Age: ");
                        int age = int.Parse(Console.ReadLine());

                        Console.Write("Enter Grade: ");
                        char grade = char.Parse(Console.ReadLine());

                        list.AddStudent(roll, name, age, grade);
                        Console.WriteLine("Student added successfully");
                        break;

                    case 2:
                        Console.Write("Enter Roll No to delete: ");
                        int delRoll = int.Parse(Console.ReadLine());
                        list.DeleteStudent(delRoll);
                        break;

                    case 3:
                        Console.Write("Enter Roll No to search: ");
                        int searchRoll = int.Parse(Console.ReadLine());
                        list.SearchStudent(searchRoll);
                        break;

                    case 4:
                        Console.Write("Enter Roll No to update grade: ");
                        int updateRoll = int.Parse(Console.ReadLine());

                        Console.Write("Enter new Grade: ");
                        char newGrade = char.Parse(Console.ReadLine());

                        list.UpdateGrade(updateRoll, newGrade);
                        break;

                    case 5:
                        list.Display();
                        break;

                    case 6:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice != 6);
        }
    }
}
