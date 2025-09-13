using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UosBookingManager.classes;
using UosBookingManager.Utilities;

namespace UosBookingManager
{
    public partial class MainForm : Form
    {
        private List<Booking> bookingsList = new List<Booking>();

        public MainForm()
        {
            InitializeComponent();
            LoadBookings();  // Load bookings on startup
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DisplayBookings();
        }

        private void buttonAddBooking_Click(object sender, EventArgs e)
        {
            AddBookingForm addForm = new AddBookingForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                bookingsList.Add(addForm.NewBooking);
                BookingUtilities.SaveBookings(bookingsList);
                DisplayBookings();
            }
        }

        private void buttonEditBooking_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var booking = dataGridView1.SelectedRows[0].DataBoundItem as Booking;
                if (booking != null)
                {
                    AddBookingForm editForm = new AddBookingForm(booking);
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        int index = bookingsList.IndexOf(booking);
                        bookingsList[index] = editForm.NewBooking;
                        BookingUtilities.SaveBookings(bookingsList);
                        DisplayBookings();
                    }
                }
            }
        }

        private void buttonDeleteBooking_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var booking = dataGridView1.SelectedRows[0].DataBoundItem as Booking;
                if (booking != null)
                {
                    bookingsList.Remove(booking);
                    BookingUtilities.SaveBookings(bookingsList);
                    DisplayBookings();
                }
            }
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAll.Checked)
                DisplayBookings();
        }

        private void radioButtonGroup_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGroup.Checked)
                dataGridView1.DataSource = bookingsList.OfType<GroupBooking>().ToList();
        }

        private void radioButtonIndividual_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonIndividual.Checked)
                dataGridView1.DataSource = bookingsList.OfType<IndividualBooking>().ToList();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookingUtilities.SaveBookings(bookingsList);
            MessageBox.Show("Bookings saved successfully.");
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DisplayBookings()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bookingsList;
            dataGridView1.AutoGenerateColumns = false;  // Assuming you have set up columns manually
            dataGridView1.Refresh();
        }

        private void LoadBookings()
        {
            bookingsList = BookingUtilities.LoadBookings();
            DisplayBookings();
        }
    }
}
