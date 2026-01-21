using System;
using System.Collections.Generic;

class BankingSystem
{
    static Dictionary<int, double> accounts = new Dictionary<int, double>();
    static Queue<int> withdrawalQueue = new Queue<int>();

    static void Main()
    {
        accounts[101] = 5000;
        accounts[102] = 8000;

        Withdraw(101, 2000);
        Withdraw(102, 3000);
    }

    static void Withdraw(int accountId, double amount)
    {
        withdrawalQueue.Enqueue(accountId);

        int id = withdrawalQueue.Dequeue();
        if (accounts[id] >= amount)
        {
            accounts[id] -= amount;
            Console.WriteLine($"Account {id} balance: {accounts[id]}");
        }
        else
        {
            Console.WriteLine($"Insufficient balance in {id}");
        }
    }
}
