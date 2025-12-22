using System;

class LeapYear{
	public static void Main(){
		
		int year = int.Parse(Console.ReadLine());

		if (year >= 1582){
			
			// Part 1: Using multiple if-else
			if (year % 400 == 0){
				Console.WriteLine("Year is a Leap Year");
			}
			else if (year % 100 == 0){
				Console.WriteLine("Year is not a Leap Year");
			}
			else if (year % 4 == 0){
				Console.WriteLine("Year is a Leap Year");
			}
			else{
				Console.WriteLine("Year is not a Leap Year");
			}

			// Part 2: Using single if with logical operators
			if ( (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0) ){
				Console.WriteLine("Leap Year (using logical operators)");
			}
			else{
				Console.WriteLine("Not a Leap Year (using logical operators)");
			}
		}
		else{
			Console.WriteLine("Year must be 1582 or later");
		}
	}
}
