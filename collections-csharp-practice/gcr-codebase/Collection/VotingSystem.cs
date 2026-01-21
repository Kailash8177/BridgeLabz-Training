using System;
using System.Collections.Generic;

class VotingSystem
{
    static Dictionary<string, int> votes = new Dictionary<string, int>();
    static List<string> voteOrder = new List<string>();

    static void Main()
    {
        CastVote("Alice");
        CastVote("Bob");
        CastVote("Alice");

        Console.WriteLine("Voting Result:");
        SortedDictionary<string, int> sorted =
            new SortedDictionary<string, int>(votes);

        foreach (var v in sorted)
            Console.WriteLine(v.Key + " : " + v.Value);
    }

    static void CastVote(string candidate)
    {
        voteOrder.Add(candidate);

        if (votes.ContainsKey(candidate))
            votes[candidate]++;
        else
            votes[candidate] = 1;
    }
}
