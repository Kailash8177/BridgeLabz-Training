using System;

class YoungestAndTallest{
    public static void Main(){
        int ageAmar = int.Parse(Console.ReadLine());
        int ageAkbar = int.Parse(Console.ReadLine());
        int ageAnthony = int.Parse(Console.ReadLine());
		
        double heightAmar = double.Parse(Console.ReadLine()!);
        double heightAkbar = double.Parse(Console.ReadLine()!);
        double heightAnthony = double.Parse(Console.ReadLine()!);

        int youngestAge = ageAmar;
        string youngestFriend = "Amar";

        if(ageAkbar < youngestAge){
            youngestAge = ageAkbar;
            youngestFriend = "Akbar";
        }
        if(ageAnthony < youngestAge){
            youngestAge = ageAnthony;
            youngestFriend = "Anthony";
        }

        double tallestHeight = heightAmar;
        string tallestFriend = "Amar";

        if(heightAkbar > tallestHeight){
            tallestHeight = heightAkbar;
            tallestFriend = "Akbar";
        }
        if(heightAnthony > tallestHeight){
            tallestHeight = heightAnthony;
            tallestFriend = "Anthony";
        }

        Console.WriteLine("The youngest friend is " + youngestFriend + " with age " + youngestAge);
        Console.WriteLine("The tallest friend is " + tallestFriend + " with height " + tallestHeight);
    }
}
