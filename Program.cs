namespace SimpleHotelManagementSystem_OOPTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HotelUtils.PrintWelcomeMessage("Amani");


            // Create a room with room number (1) 
            Room room1 = new Room(101); // Room number must be 100 or above

            // Create a guest with name "Amani" and NationalID "221199"
            Guest guest = new Guest
            {
                Name = "Amani",
                NationalID = "221199",
                Password = "Blueprint2211"
            };

            // Display room status before booking
            Console.WriteLine("Room " + room1.RoomNumber + " booked status: " + room1.IsBooked);

            Booking booking = new Booking(room1, guest);
            booking.ConfirmBooking();

            // Display room status after booking
            Console.WriteLine("Room " + room1.RoomNumber + " booked status: " + room1.IsBooked);
            Console.WriteLine($"Booking Time: {booking.BookingTime}");



        }
    }
}
