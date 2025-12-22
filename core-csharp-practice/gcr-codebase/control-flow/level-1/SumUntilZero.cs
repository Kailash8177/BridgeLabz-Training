using System;

class SumUntilZero{
    public static void Main(){
        double total = 0.0;
        double number;
		number = double.Parse(Console.ReadLine());
		while (number != 0){
            total += number;
            number = double.Parse(Console.ReadLine());
        }
		Console.WriteLine("The total sum is " + total);
    }
}
