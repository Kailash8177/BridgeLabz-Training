using System;

class Factor{
    static void Main()
    {
        // Take input from user
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Initialize greatest factor
        int greatestFactor = 1;

        // Loop from number-1 down to 1
        for (int i = number - 1; i >= 1; i--)
        {
            if (number % i == 0)
            {
                greatestFactor = i;
                break; // Exit the loop as soon as we find the greatest factor
            }
        }

        // Display the result
        Console.WriteLine("Greatest factor of " + number + " besides itself is: " + greatestFactor);
    }
}
