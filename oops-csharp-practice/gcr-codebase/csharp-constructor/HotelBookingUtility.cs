using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.opps_chsarp_pracitce.gcr_codebase.csharp_constructor.level_1
{
    public class HotelBookingUtility
    {
        public static void Main()
        {
            HotelBooking h1 = new HotelBooking("Ravi", "Deluxe", 3);
            HotelBooking h2 = new HotelBooking(h1);

            h1.Display();
            h2.Display();
        }
    }
    public class HotelBooking
    {
        public string GuestName;
        public string RoomType;
        public int Nights;

        // Default constructor
        public HotelBooking()
        {
            GuestName = "Guest";
            RoomType = "Standard";
            Nights = 1;
        }

        // Parameterized constructor
        public HotelBooking(string guestName, string roomType, int nights)
        {
            GuestName = guestName;
            RoomType = roomType;
            Nights = nights;
        }

        // Copy constructor
        public HotelBooking(HotelBooking hb)
        {
            GuestName = hb.GuestName;
            RoomType = hb.RoomType;
            Nights = hb.Nights;
        }

        public void Display()
        {
            Console.WriteLine($"{GuestName} | {RoomType} | {Nights} nights");
        }
    }
}
