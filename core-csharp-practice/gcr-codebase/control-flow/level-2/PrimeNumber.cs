using System;

class PrimeNumber{
	public static void Main(){
		
		int number = int.Parse(Console.ReadLine());
		bool isPrime = true;

		if (number <= 1){
			isPrime = false;
		}
		else{
			for (int i = 2; i < number; i++){
				if (number % i == 0){
					isPrime = false;
					break;
				}
			}
		}

		if (isPrime){
			Console.WriteLine("The number " + number + " is a prime number.");
		}
		else{
			Console.WriteLine("The number " + number + " is not a prime number.");
		}
	}
}
