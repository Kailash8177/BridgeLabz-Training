using System;
using IplCensorshipAnalyzer.Services;

namespace IplCensorshipAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            CensorshipService.ProcessJson(
                "Data/input.json",
                "Output/censored.json"
            );

            CensorshipService.ProcessCsv(
                "Data/input.csv",
                "Output/censored.csv"
            );

            Console.WriteLine("IPL Data Censorship Completed Successfully!");
            Console.ReadLine();
        }
    }
}
