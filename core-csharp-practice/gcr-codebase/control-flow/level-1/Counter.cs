using System;

class Counter{
    public static void Main(){
        int counter = int.Parse(Console.ReadLine());
		while (counter >= 1){
            Console.WriteLine(counter);
            counter--;
        }
    }
}
