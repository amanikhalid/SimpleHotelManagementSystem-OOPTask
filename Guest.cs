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
        //Auto-property: Name
        public string Name
        {
            get
            { return Name; }

            set
            {
                // Validation for Name property
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Name cannot be empty or whitespace.");

                }
                else
                {
                    Name = value;
                }

            }
        }





//Auto-property: NationalID
public string NationalID
        { 
            get { return NationalID; }
            set
            {
                // Validation for NationalID property
                if (string.IsNullOrWhiteSpace(value) || value.Length != 6)
                {
                    Console.WriteLine("National ID must be exactly 6 characters long and cannot be empty or whitespace.");
                }
                else
                {
                    NationalID = value;
                }
            }


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
