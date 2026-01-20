using System;

public class AadharUtility : IAadhaarService
{
    private List<long> l = new List<long>();

    public void AddAadhaar(long aadhaar)
    {
        l.Add(aadhaar);
    }
    public void SortAadhaar()
    {

        long max = l.Max();

        for (long exp = 1; max / exp > 0; exp *= 10)
        {
            CountingSort(exp);
        }
        Console.WriteLine("Aadhaar numbers sorted successfully.");
        
    }

    public void CountingSort(long exp)
    {
        int n = l.Count();
        long [] output = new long[n];
        int [] count  = new int [10];

        for (int i = 0; i < n; i++)
        {
            int index = ( int ) ( ( l[i] / exp) % 10);
            count[index]++;
        }

        for (int i = 1; i < 10; i++)
        {
            count [ i ] += count [i-1]; 
        }

        for (int i = n-1; i >= 0; i--)
        {
            int index = ( int ) ((l[i] / exp) % 10);
            output[count [ index] -1] = l[i];
            count[index]--;
        }

        for (int i = 0; i < n; i++)
        {
            l [ i ] = output[i];
        }
    }
    public int SearchAadhaar(long aadhaar)
    {
        int left = 0;
        int right = l.Count - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (l[mid] == aadhaar)
                return mid;

            if (l[mid] < aadhaar)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }
    public void DisplayAll()
    {
        Console.WriteLine("Aadhaar Numbers:");
        foreach (long num in l)
            Console.WriteLine(num); 
    }
} 
