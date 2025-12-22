using System;

class CheckNumber{
    public static void Main(){
        int number = int.Parse(Console.ReadLine());
		if (number > 0){
            Console.WriteLine("Positive");
        }
        else if (number < 0){
            Console.WriteLine("Negative");
        }
        else if ( number == 0){
            Console.WriteLine("Zero");
        }
    }
}
