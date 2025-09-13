// AddBookingForm.cs
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace SportsClubBookingSystem
{
    public partial class AddBookingForm : Form
    {
        private List<Booking> bookings;

        public AddBookingForm(List<Booking> bookings)
        {
            InitializeComponent();
            this.bookings = bookings;
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            // Validate and add booking details here
            // Ensure no duplicate Ids

            int id = int.Parse(txtId.Text);
            if (bookings.Any(b => b.Id == id))
            {
                MessageBox.Show("Duplicate booking Id. Please enter a unique Id.");
                return;
            }

            // Create a new Booking object and set its properties
            Booking newBooking = new Booking
            {
                Id = id,
                Date = dateTimePickerDate.Value,
                StartTime = dateTimePickerTime.Value.TimeOfDay,
                Duration = (int)numericUpDownDuration.Value,
                Activity = txtActivity.Text,
                ContactName = txtContactName.Text,
                ContactEmail = txtContactEmail.Text,
                Participants = (int)numericUpDownParticipants.Value,
                CoachRequired = checkBoxCoach.Checked,
                CoachName = txtCoachName.Text,
                GoldCardMember = checkBoxGoldCardMember.Checked,
                MembershipNumber = checkBoxGoldCardMember.Checked ? int.Parse(txtMembershipNumber.Text) : 0
            };

            // Add the new booking to the list
            bookings.Add(newBooking);

            // Save to file
            SaveBookingsToFile("bookings.dat");

            MessageBox.Show("Booking added successfully!");
            this.Close();
        }

        private void SaveBookingsToFile(string filePath)
        {
            try
            {
                // Ensure the directory exists
                string directory = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                // Serialize the bookings list and save to a file
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, bookings);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving bookings to file: {ex.Message}");
            }
        }




        private Label lbltxtMembershipNumber;
        private TextBox txtMembershipNumber;
        private Button btnAddBooking;
    }
}
