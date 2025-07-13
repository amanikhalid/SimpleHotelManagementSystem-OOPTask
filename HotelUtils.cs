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
                throw new ArgumentException("Guest name cannot be null or empty.");
            }
            Console.WriteLine($"Welcome to our hotel, {guestName}! We hope you have a pleasant stay.");
        }
    }
}
