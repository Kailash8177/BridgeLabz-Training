using System;

class DayOfWeek{
    public static void Main(string[] args){
        
        int m = int.Parse(args[0]);
        int d = int.Parse(args[1]);
        int y = int.Parse(args[2]);

        y = y - (14 - m) / 12;
        int x = y + y / 4 - y / 100 + y / 400;
        m = m + 12 * ((14 - m) / 12) - 2;

        int day = (d + x + (31 * m) / 12) % 7;

        Console.WriteLine(day);
    }
}
