using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHotelManagementSystem_OOPTask
{
    class Room
    {

        // Field: roomNumber
        private int roomNumber;

        // Property: RoomNumber
        public int RoomNumber
        {
            get { return roomNumber; }
            set
            {
                if (roomNumber <= 0)
                {
                    Console.WriteLine("Room number must be greater than 0.");
                }
                else
                {
                    roomNumber = value;
                }
            }
            
        }

        // Field: isBooked (bool)
        private bool isBooked=true;

        // Property: IsBooked
        public bool IsBooked
        {
            get { return isBooked; }
           
        }

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
        }

        // Constructor that takes a Room
        public Room(int roomNumber)
        {
            this.roomNumber = roomNumber;
            isBooked = false; // default value 
        }






    }
}
