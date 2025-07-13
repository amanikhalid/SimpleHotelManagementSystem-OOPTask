using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHotelManagementSystem_OOPTask
{
    class Booking
    {
        // Booking Fields
        private Room bookedRoom;
        private Guest bookingGuest;
        private DateTime bookingDate;

        // Constructor that takes a Room and a Guest 
        public Booking(Room room, Guest guest)
        {
            if (room == null || guest == null)
            {
                throw new ArgumentNullException("Room and Guest cannot be null.");
            }
            bookedRoom = room;
            bookingGuest = guest;
            // Check if the room is already booked
            if (bookedRoom.IsBooked)
            {
                Console.WriteLine("The room is already booked.");
            }
            else
            {
                bookedRoom.Book(); // Book the room
                Console.WriteLine($"Room {bookedRoom.RoomNumber} has been booked for {bookingGuest.Name}.");
            }

            // Method ConfirmBooking()
            // Checks if the room is booked and confirms the booking
            void ConfirmBooking()
            {
                if (bookedRoom.IsBooked)
                {
                    Console.WriteLine($"Booking confirmed for {bookingGuest.Name} in room {bookedRoom.RoomNumber}.");
                }
                else // If not booked
                {
                    Console.WriteLine("Booking could not be confirmed as the room is not booked.");
                }
            }
        }

    }
}
