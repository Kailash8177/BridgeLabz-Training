using System;

class SumOfNumberUsingFor{
    public static void Main(){
        int n = int.Parse(Console.ReadLine());
        if (n > 0){
            int sum = 0;
            int i = 1;

            for(;i<=n;i++){
				sum += i;
			}
            int sumUsingFormula = n * (n + 1) / 2;

            Console.WriteLine("Sum using while loop: " + sum);
            Console.WriteLine("Sum using formula: " + sumUsingFormula);
            if (sum == sumUsingFormula){
                Console.WriteLine("Both computations are correct.");
            }
            else{
                Console.WriteLine("The computations do not match.");
            }
        }
        else{
            Console.WriteLine("The number " + n + " is not a natural number.");
        }
    }
}
