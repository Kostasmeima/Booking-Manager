namespace SportsClubBookingSystem
{
    partial class MainForm
    {
        // ... existing code ...

        private void InitializeComponent()
        {
            this.btnViewBookings = new System.Windows.Forms.Button();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewBookings
            // 
            this.btnViewBookings.Location = new System.Drawing.Point(260, 213);
            this.btnViewBookings.Name = "btnViewBookings";
            this.btnViewBookings.Size = new System.Drawing.Size(75, 23);
            this.btnViewBookings.TabIndex = 0;
            this.btnViewBookings.Text = "VIEW";
            this.btnViewBookings.UseVisualStyleBackColor = true;
            this.btnViewBookings.Click += new System.EventHandler(this.btnViewBookings_Click);  // Add the click event handler
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Location = new System.Drawing.Point(421, 213);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(75, 23);
            this.btnAddBooking.TabIndex = 1;
            this.btnAddBooking.Text = "ADD";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);  // Add the click event handler
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddBooking);
            this.Controls.Add(this.btnViewBookings);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        private Button btnViewBookings;
        private Button btnAddBooking;

        // Event handler for btnViewBookings click event
        private void btnViewBookings_Click(object sender, EventArgs e)
        {
            // Open the ViewBookingsForm
            ViewBookingsForm viewBookingsForm = new ViewBookingsForm(bookings);
            viewBookingsForm.ShowDialog();
        }

        // Event handler for btnAddBooking click event
        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            // Open the AddBookingForm
            AddBookingForm addBookingForm = new AddBookingForm(bookings);
            addBookingForm.ShowDialog();
        }
    }
}
