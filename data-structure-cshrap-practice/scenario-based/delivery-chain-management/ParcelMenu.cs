using System;
using System.Collections.Generic;
using System.Text;

namespace delivery_chain_management
{
    internal class ParcelMenu
    {
        private IParcelTracker tracker = new ParcelUtility();

        public ParcelMenu()
        {
            ShowMenu();
        } 

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n Parcel Tracker Menu ");
                Console.WriteLine("1. Add Stage");
                Console.WriteLine("2. Add Checkpoint");
                Console.WriteLine("3. Track Parcel");
                Console.WriteLine("4. Check Parcel Status");
                Console.WriteLine("5. Exit");
                Console.Write("Choose option: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter stage name: ");
                        tracker.AddStage(Console.ReadLine());
                        break;

                    case 2:
                        Console.Write("After which stage: ");
                        string afterStage = Console.ReadLine();
                        Console.Write("Enter new checkpoint: ");
                        string newStage = Console.ReadLine();
                        tracker.AddCheckPoint(afterStage, newStage);
                        break;

                    case 3:
                        tracker.TrackParcel();
                        break;

                    case 4:
                        tracker.CheckParcel();
                        break;

                    case 5:
                        Console.WriteLine("🚪 Exiting...");
                        return;

                    default:
                        Console.WriteLine("❌ Invalid choice");
                        break;
                }
            }
        }
    }
}
