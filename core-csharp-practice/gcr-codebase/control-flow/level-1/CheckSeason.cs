using System;

class CheckSeason{
	public static void Main(){
		int day = int.Parse(Console.ReadLine());
		int month= int.Parse(Console.ReadLine());
		if ((month == 3 && day >= 20) ||(month == 4) ||(month == 5) ||(month == 6 && day <= 20)){
		    Console.WriteLine("Its a Spring Season");
		}
		else {
		    Console.WriteLine("not a Spring Season");	
		}
	}
}