using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.datastructure_csharp_practice.LiknedList_csharp_problem.student_record_management
{
    /*
 * Linked List class: Manages all student records
 */
    public class StudentList
    {
    private StudentNode head; // Head points to the first node

    // Add student at the end of the list
    public void AddStudent(int roll, string name, int age, char grade)
    {
        StudentNode newNode = new StudentNode(roll, name, age, grade);

        // If list is empty
        if (head == null)
        {
            head = newNode;
            return;
        }

        // Traverse to the last node
        StudentNode temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }

        // Attach new node at the end
        temp.Next = newNode;
    }

    // Delete student by Roll Number
    public void DeleteStudent(int roll)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty");
            return;
        }

        // If first node is to be deleted
        if (head.RollNo == roll)
        {
            head = head.Next;
            Console.WriteLine("Student deleted successfully");
            return;
        }

        StudentNode temp = head;

        // Search for the node before the target node
        while (temp.Next != null && temp.Next.RollNo != roll)
        {
            temp = temp.Next;
        }

        if (temp.Next != null)
        {
            temp.Next = temp.Next.Next;
            Console.WriteLine("Student deleted successfully");
        }
        else
        {
            Console.WriteLine("Student not found");
        }
    }

    // Search student by Roll Number
    public void SearchStudent(int roll)
    {
        StudentNode temp = head;

        while (temp != null)
        {
            if (temp.RollNo == roll)
            {
                Console.WriteLine($"RollNo: {temp.RollNo}");
                Console.WriteLine($"Name  : {temp.Name}");
                Console.WriteLine($"Age   : {temp.Age}");
                Console.WriteLine($"Grade : {temp.Grade}");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Student not found");
    }

    // Update student grade
    public void UpdateGrade(int roll, char grade)
    {
        StudentNode temp = head;

        while (temp != null)
        {
            if (temp.RollNo == roll)
            {
                temp.Grade = grade;
                Console.WriteLine("Grade updated successfully");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Student not found");
    }

    // Display all student records
    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("No records available");
            return;
        }

        StudentNode temp = head;
        Console.WriteLine("\nStudent Records:");
        while (temp != null)
        {
            Console.WriteLine($"{temp.RollNo} {temp.Name} {temp.Age} {temp.Grade}");
            temp = temp.Next;
        }
    }
}
}
