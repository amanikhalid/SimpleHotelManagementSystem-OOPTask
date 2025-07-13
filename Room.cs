using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHotelManagementSystem_OOPTask
{
    class Room
    {
        private int roomNumber;
        private bool isBooked;
        private static int roomCount = 0;

        // Property: RoomNumber
        public int RoomNumber
        {
            get { return roomNumber; }
            set
            {
                if (value >= 100)
                    roomNumber = value;
                else
                    Console.WriteLine("Room number must be 100 or above.");
            }
        }
        public bool IsBooked => isBooked;


        // Method: sets isBooked to true
        public void Book()
        {
            isBooked = true;
        }

        // Method: sets isBooked to false
        public void Free()
        {
            isBooked = false;
        }

        // Constructor: Room(int roomNumber)
        public Room()
        {
            roomNumber = 0;
            isBooked = false; // default value 
            roomCount++;
        }

        // Constructor that takes a Room
        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
            isBooked = false;
            roomCount++;
        }

        public static int GetRoomCount() => roomCount;



    }
}
