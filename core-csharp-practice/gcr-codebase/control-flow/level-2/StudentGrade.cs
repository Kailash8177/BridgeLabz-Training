using System;

class StudentGrade{
    public static void Main(){
        
        int physics = int.Parse(Console.ReadLine());
        int chemistry = int.Parse(Console.ReadLine());
        int maths = int.Parse(Console.ReadLine());
        
        int total = physics + chemistry + maths;
        double percentage = total / 3.0;
        
        Console.WriteLine("Average Mark: " + percentage);
        
        if (percentage >= 80){
            Console.WriteLine("Grade: A");
            Console.WriteLine("Remarks: Level 4, above agency-normalized standards");
        }
        else if (percentage >= 70){
            Console.WriteLine("Grade: B");
            Console.WriteLine("Remarks: Level 3, at agency-normalized standards");
        }
        else if (percentage >= 60){
            Console.WriteLine("Grade: C");
            Console.WriteLine("Remarks: Level 2, below but approaching standards");
        }
        else if (percentage >= 50){
            Console.WriteLine("Grade: D");
            Console.WriteLine("Remarks: Level 1, well below standards");
        }
        else if (percentage >= 40){
            Console.WriteLine("Grade: E");
            Console.WriteLine("Remarks: Level 1, too below standards");
        }
        else{
            Console.WriteLine("Grade: R");
            Console.WriteLine("Remarks: Remedial standards");
        }
    }
}
