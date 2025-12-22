using System;

class FactorialUsingWhile{
	public static void Main(){
		int n = int.Parse(Console.ReadLine());
		int fact = 1;
		while ( n > 1 ){
			fact *= n;
			n--;
		}
		Console.WriteLine(fact);
	}
}