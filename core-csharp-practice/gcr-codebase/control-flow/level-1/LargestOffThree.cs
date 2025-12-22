using System;

class LargestOffThree{
	public static void Main(){
		
		int number1 = int.Parse(Console.ReadLine());
		int number2 = int.Parse(Console.ReadLine());
		int number3 = int.Parse(Console.ReadLine());
		
		
		if( number1 > number2 && number1 > number3){
			
			Console.WriteLine("Is the first number the Largest? Yes");
			Console.WriteLine("Is the Second number the Largest? No");
			Console.WriteLine("Is the Third number the Largest? No");
			
		}
		else if ( number2 > number1 && number2 > number3 ){
			
			Console.WriteLine("Is the first number the Largest? No");
			Console.WriteLine("Is the Second number the Largest? Yes");
			Console.WriteLine("Is the Third number the Largest? No");
		}
		else {
			Console.WriteLine("Is the first number the Largest? No");
			Console.WriteLine("Is the Second number the Largest? No");
			Console.WriteLine("Is the Third number the Largest? Yes");
		}
	}
}