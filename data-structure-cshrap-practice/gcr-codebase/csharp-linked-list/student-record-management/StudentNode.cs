using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.datastructure_csharp_practice.LiknedList_csharp_problem.student_record_management
{

    /*
     * Node class: Represents a single student record
     * Each node contains student data and a reference to the next node
     */
    class StudentNode
    {
        public int RollNo;
        public string Name;
        public int Age;
        public char Grade;
        public StudentNode Next;

        // Constructor to initialize student details
        public StudentNode(int roll, string name, int age, char grade)
        {
            RollNo = roll;
            Name = name;
            Age = age;
            Grade = grade;
            Next = null;
        }
    }
}
