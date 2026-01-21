using System;
using System.Collections.Generic;

class InsurancePolicySystem
{
    class Policy
    {
        public string PolicyNumber;
        public string CoverageType;
        public DateTime ExpiryDate;

        public override bool Equals(object obj)
            => obj is Policy p && PolicyNumber == p.PolicyNumber;

        public override int GetHashCode()
            => PolicyNumber.GetHashCode();
    }

    static HashSet<Policy> uniquePolicies = new HashSet<Policy>();
    static List<Policy> insertionOrder = new List<Policy>();

    static SortedSet<Policy> sortedByExpiry =
        new SortedSet<Policy>(Comparer<Policy>.Create(
            (a, b) => a.ExpiryDate.CompareTo(b.ExpiryDate)));

    static void Main()
    {
        AddPolicy("P1", "Health", DateTime.Now.AddDays(20));
        AddPolicy("P2", "Life", DateTime.Now.AddDays(60));
        AddPolicy("P3", "Health", DateTime.Now.AddDays(10));

        Console.WriteLine("Policies expiring in 30 days:");
        foreach (var p in sortedByExpiry)
        {
            if ((p.ExpiryDate - DateTime.Now).Days <= 30)
                Console.WriteLine(p.PolicyNumber);
        }
    }

    static void AddPolicy(string no, string type, DateTime expiry)
    {
        Policy p = new Policy { PolicyNumber = no, CoverageType = type, ExpiryDate = expiry };

        if (uniquePolicies.Add(p))
        {
            insertionOrder.Add(p);
            sortedByExpiry.Add(p);
        }
    }
}
