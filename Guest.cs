using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SimpleHotelManagementSystem_OOPTask
{
    class Guest
    {
        private string name;
        private string nationalID;
        private string password;

        //Auto-property: Name
        public string Name
        {
            get 
            { 
                return name;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= 3)
                    name = value;
                else
                    Console.WriteLine("Name must be at least 3 characters and not empty.");
            }
        }





        //Auto-property: NationalID
        public string NationalID
        {
            get { return nationalID; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length == 6)
                    nationalID = value;
                else
                    Console.WriteLine("National ID must be exactly 6 characters.");
            }
        }

        public string Password
        {
            set { password = value; }
        }

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

   



    }


}
