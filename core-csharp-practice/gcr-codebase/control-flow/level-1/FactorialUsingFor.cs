using System;

class FactorialUsingFor{
	public static void Main(){
		int n = int.Parse(Console.ReadLine());
		int fact = 1;
		for(int i = 2; i <= n; i++){
			fact *= i; 
		}
		Console.WriteLine(fact);
	}
}