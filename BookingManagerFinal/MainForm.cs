using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsClubBookingSystem
{
    public partial class MainForm : Form
    {
        private List<Booking> bookings = new List<Booking>();
        public MainForm()
        {
            InitializeComponent();
            LoadBookingsFromFile("bookings.dat");
        }

        private void LoadBookingsFromFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        bookings = (List<Booking>)formatter.Deserialize(fs);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading bookings from file: {ex.Message}");
            }
        }


        // Property to access bookings
        public List<Booking> Bookings
        {
            get { return bookings; }
            set { bookings = value; }
        }
    }
}
