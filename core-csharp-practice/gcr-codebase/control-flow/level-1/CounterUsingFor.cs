using System;

class CounterUsingFor{
    public static void Main(){
        int counter = int.Parse(Console.ReadLine());
		for ( int i = counter ; i >= 1 ; i--){
			Console.WriteLine(i);
		} 
    }
}
