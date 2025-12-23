using System;

class Armstrong{
    public static void Main(){
        
        int number = int.Parse(Console.ReadLine());
        int original = number;
        int sum = 0;

        while(original != 0){
            int r = original % 10;
            sum = sum + (r * r * r);
            original = original / 10;
        }

        if(sum == number){
            Console.WriteLine("Armstrong Number");
        }else{
            Console.WriteLine("Not an Armstrong Number");
        }
    }
}
