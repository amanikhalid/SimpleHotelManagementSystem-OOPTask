using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleHotelManagementSystem_OOPTask
{
    class Guest
    {
        //Auto-property: Name
        public string Name { get; set; }


        //Auto-property: NationalID
        public string NationalID { get; set; }

        // Constructor overloads to Guest class 
        public Guest()
        {
            Name = "Amani";
            NationalID = "221199";
        }

        // Parameterized constructor
        public Guest(string name, string nationalID)
        {
            Name = name;
            NationalID = nationalID;
        }

        // Display room status before booking
        // Console.WriteLine("Room" + room1.RoomNumber + " booked status: " + room1.isBooked);

        // Book the Room
        // room1.Book(); 

        // Display room status after booking
        // Console.WriteLine("Room" + room1.RoomNumber + " booked status: " + room1.isBooked);



    }


}
