using System;

class Harshad{
    public static void Main(){
        
        int number = int.Parse(Console.ReadLine());
        int original = number;
        int sum = 0;

        while(original != 0){
            int r = original % 10;
            sum = sum + r;
            original = original / 10;
        }

        if(number % sum == 0){
            Console.WriteLine("Harshad Number");
        }else{
            Console.WriteLine("Not a Harshad Number");
        }
    }
}
