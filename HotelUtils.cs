using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHotelManagementSystem_OOPTask
{
    class HotelUtils
    {
        // A static method PrintWelcomeMessage() that prints a welcome message to the guest
        public static void PrintWelcomeMessage(string guestName)
        {
            if (string.IsNullOrEmpty(guestName))
            {
                Console.WriteLine("Guest name cannot be null or empty.");
            }
            Console.WriteLine($"Welcome to our hotel, {guestName}! We hope you have a pleasant stay.");
        }
        // A static method IsRoomAvailable(Room room) that returns true/false
        public static bool IsRoomAvailable(Room room)
        {
            if (room == null)
            {
                Console.WriteLine("Room cannot be null.");
            }
            return !room.IsBooked; // Returns true if the room is not booked
        }
    }
}
