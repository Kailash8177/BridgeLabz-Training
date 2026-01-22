using System;
using System.Collections.Generic;
using System.Text;

namespace rank_sheet_generator
{
    public class Student
    {
        public int RollNo;
        public string Name;
        public int Marks;
        
        public Student(int rollNo, string name, int marks)
        {
            RollNo = rollNo;
            Name = name;
            Marks = marks;
        }
    }

}
