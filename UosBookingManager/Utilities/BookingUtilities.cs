using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using UosBookingManager.classes;


namespace UosBookingManager.Utilities
{
    public static class BookingUtilities
    {
        // Method to save the bookings to a file
        public static void SaveBookings(List<Booking> bookings)
        {
            string fileName = "bookings.json";
            string jsonString = JsonSerializer.Serialize(bookings);
            File.WriteAllText(fileName, jsonString);
        }

        public static List<Booking> LoadBookings()
        {
            string fileName = "bookings.json";
            if (File.Exists(fileName))
            {
                string jsonString = File.ReadAllText(fileName);
                return JsonSerializer.Deserialize<List<Booking>>(jsonString) ?? new List<Booking>();
            }
            return new List<Booking>();
        }
    }

}
