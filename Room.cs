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





    }
}
