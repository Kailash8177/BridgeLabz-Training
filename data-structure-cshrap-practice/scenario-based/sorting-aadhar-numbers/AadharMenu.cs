using System;

class AadharMenu
{
    public AadharMenu(){
        Menu();
    }

    public void Menu()
    {
        IAadhaarService service = new AadharUtility();
        int choice;

        do
        {
            Console.WriteLine("\n--- Aadhaar Management System ---");
            Console.WriteLine("1. Add Aadhaar Number");
            Console.WriteLine("2. Sort Aadhaar Numbers (Radix Sort)");
            Console.WriteLine("3. Search Aadhaar Number (Binary Search)");
            Console.WriteLine("4. Display All Aadhaar Numbers");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter 12-digit Aadhaar Number: ");
                    long aadhaar = long.Parse(Console.ReadLine());
                    service.AddAadhaar(aadhaar);
                    break;

                case 2:
                    service.SortAadhaar();
                    break;

                case 3:
                    Console.Write("Enter Aadhaar to search: ");
                    long search = long.Parse(Console.ReadLine());
                    int index = service.SearchAadhaar(search);
                    Console.WriteLine(index == -1
                        ? "Aadhaar not found"
                        : $"Aadhaar found at position {index}");
                    break;

                case 4:
                    service.DisplayAll();
                    break;

                case 5:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        } while (choice != 5);
    }
}
