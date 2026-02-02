using System;
using JsonDataHandlingAssignment.Services;


    class Program
    {
        static void Main(string[] args)
        {
            JsonBasicOperations.CreateStudentJson();
            JsonBasicOperations.ConvertCarToJson();
            JsonBasicOperations.MergeJsonObjects();
            JsonBasicOperations.ValidateJson();

            JsonAdvancedOperations.FilterUsersByAge();
            JsonAdvancedOperations.PrintAllKeys();
            JsonAdvancedOperations.CsvToJson();

            Console.WriteLine("Assignment Completed Successfully");
            Console.ReadLine();
        }
    }

