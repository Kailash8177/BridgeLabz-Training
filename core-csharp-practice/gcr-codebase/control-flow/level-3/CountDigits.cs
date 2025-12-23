using System;

class CountDigits{
    public static void Main(){
        
        int number = int.Parse(Console.ReadLine());
        int count = 0;

        while(number != 0){
            number = number / 10;
            count++;
        }

        Console.WriteLine(count);
    }
}
