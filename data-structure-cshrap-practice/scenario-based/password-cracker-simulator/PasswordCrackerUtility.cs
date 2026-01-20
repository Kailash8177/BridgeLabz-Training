using System;

public class PasswordCrackerUtility : IPasswordCracker
{
    private char[] charset = { 'a', 'b', 'c', '1', '2' };
    private string targetPassword;
    private bool isFound = false;
    private int attempts = 0;

    public PasswordCrackerUtility(string password)
    {
        targetPassword = password;
    }

    public void CrackPassword(int length)
    {
        char[] current = new char[length];
        Backtrack(0, current);

        Console.WriteLine("\nTotal Attempts: " + attempts);
    }

    private void Backtrack(int index, char[] current)
    {
        if (isFound) return;   // Scenario B: STOP EARLY

        if (index == current.Length)
        {
            attempts++;
            string guess = new string(current);
            Console.WriteLine("Trying: " + guess);

            if (guess == targetPassword)
            {
                Console.WriteLine("\n✅ Password Cracked: " + guess);
                isFound = true;
            }
            return;
        }

        foreach (char ch in charset)
        {
            current[index] = ch;     // CHOOSE
            Backtrack(index + 1, current); // EXPLORE
            // UNCHOOSE happens automatically (overwrite)
        }
    }
}
