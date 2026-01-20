using System;
class PasswordCrackerMain
{
    public static void Main()
    {
        Console.Write("Enter password to crack: ");
        string password = Console.ReadLine();

        IPasswordCracker cracker = new PasswordCrackerUtility(password);
        cracker.CrackPassword(password.Length);
    }
}
