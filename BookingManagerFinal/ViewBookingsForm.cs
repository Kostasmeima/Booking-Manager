// ViewBookingsForm.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SportsClubBookingSystem
{
    public partial class ViewBookingsForm : Form
    {
        private List<Booking> bookings;

        public ViewBookingsForm(List<Booking> bookings)
        {
            InitializeComponent();
            this.bookings = bookings;
            DisplayBookings();
        }

        private void DisplayBookings()
        {
            // Display all bookings in the ListBox
            listBoxBookings.Items.Clear();
            foreach (var booking in bookings)
            {
                listBoxBookings.Items.Add($"{booking.Id} - {booking.Date.ToShortDateString()} {booking.StartTime} - {booking.Activity}");
            }
        }

        private void btnFilterGroupBookings_Click(object sender, EventArgs e)
        {
            // Display a list of group bookings
            var groupBookings = bookings.Where(b => b.Participants > 0).ToList();
            DisplayFilteredBookings(groupBookings);
        }

        private void btnFilterIndividualBookings_Click(object sender, EventArgs e)
        {
            // Display a list of individual bookings
            var individualBookings = bookings.Where(b => b.GoldCardMember).ToList();
            DisplayFilteredBookings(individualBookings);
        }

        private void DisplayFilteredBookings(List<Booking> filteredBookings)
        {
            listBoxBookings.Items.Clear();
            foreach (var booking in filteredBookings)
            {
                listBoxBookings.Items.Add($"{booking.Id} - {booking.Date.ToShortDateString()} {booking.StartTime} - {booking.Activity}");
            }
        }
    }
}
