using System;

class SumUntilNatural{
    public static void Main(){
        double total = 0.0;
        double number;
		number = double.Parse(Console.ReadLine());
		while (true){
			if( number <= 0 ) break;
            total += number;
            number = double.Parse(Console.ReadLine());
        }
		Console.WriteLine("The total sum is " + total);
    }
}
