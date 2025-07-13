namespace SimpleHotelManagementSystem_OOPTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Create a room with room number (1) 
           Room room1 = new Room(1);

            // Create a guest with name "Amani" and NationalID "221199"
            Guest guest = new Guest
            {
                Name = "Amani",
                NationalID = "221199"
            };

            // Display room status before booking
            Console.WriteLine("Room " + room1.RoomNumber + " booked status: " + room1.IsBooked);

            // Book the Room
            room1.Book();




        }
    }
}
