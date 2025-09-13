using System;
using System.Windows.Forms;
using UosBookingManager.classes;

namespace UosBookingManager
{
    public partial class AddBookingForm : Form
    {
        public Booking NewBooking { get; private set; }

        // Default constructor for new bookings
        public AddBookingForm()
        {
            InitializeComponent();
            radioButtonIndividualBookings.Checked = true; // Set default to individual bookings
            ToggleBookingDetails();
        }

        // Constructor for editing an existing booking
        public AddBookingForm(Booking booking) : this()
        {
            if (booking is GroupBooking groupBooking)
            {
                radioButtonGroupBooking.Checked = true;
                textBoxID.Text = groupBooking.Id.ToString();
                dateTimePickerDate.Value = groupBooking.Date;
                dateTimePickerStartTime.Value = DateTime.Today.Add(groupBooking.StartTime);
                numericUpDown1.Value = groupBooking.Duration;
                textBoxActivity.Text = groupBooking.Activity;
                textBoxName.Text = groupBooking.ContactName;
                textBoxEmail.Text = groupBooking.ContactEmail;
                numericUpDownParticipants.Value = groupBooking.Participants;
                checkBoxCoachRequired.Checked = groupBooking.CoachRequired;
                textBoxCoachName.Text = groupBooking.CoachName ?? "";
            }
            else if (booking is IndividualBooking individualBooking)
            {
                radioButtonIndividualBookings.Checked = true;
                textBoxID.Text = individualBooking.Id.ToString();
                dateTimePickerDate.Value = individualBooking.Date;
                dateTimePickerStartTime.Value = DateTime.Today.Add(individualBooking.StartTime);
                numericUpDown1.Value = individualBooking.Duration;
                textBoxActivity.Text = individualBooking.Activity;
                textBoxName.Text = individualBooking.ContactName;
                textBoxEmail.Text = individualBooking.ContactEmail;
                checkBoxGoldCardMembership.Checked = individualBooking.GoldCardMember;
                textBoxMembershipNumber.Text = individualBooking.MembershipNumber ?? "";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxID.Text) || string.IsNullOrWhiteSpace(textBoxActivity.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                int id, duration;
                int participants = 0; // Initialize participants here

                // Use TryParse for safe conversion from numericUpDown to int
                if (!int.TryParse(textBoxID.Text, out id) ||
                    !int.TryParse(numericUpDown1.Value.ToString(), out duration))
                {
                    MessageBox.Show("Please enter valid numbers in numeric fields.");
                    return;
                }

                // Only attempt to parse participants if it's a group booking
                if (radioButtonGroupBooking.Checked)
                {
                    if (!int.TryParse(numericUpDownParticipants.Value.ToString(), out participants))
                    {
                        MessageBox.Show("Please enter a valid number for participants.");
                        return;
                    }
                }

                if (radioButtonGroupBooking.Checked)
                {
                    var groupBooking = new GroupBooking
                    {
                        Id = id,
                        Date = dateTimePickerDate.Value,
                        StartTime = dateTimePickerStartTime.Value.TimeOfDay,
                        Duration = duration,
                        Activity = textBoxActivity.Text,
                        ContactName = textBoxName.Text,
                        ContactEmail = textBoxEmail.Text,
                        Participants = participants,
                        CoachRequired = checkBoxCoachRequired.Checked,
                        CoachName = checkBoxCoachRequired.Checked ? textBoxCoachName.Text : string.Empty
                    };
                    NewBooking = groupBooking;
                }
                else if (radioButtonIndividualBookings.Checked)
                {
                    var individualBooking = new IndividualBooking
                    {
                        Id = id,
                        Date = dateTimePickerDate.Value,
                        StartTime = dateTimePickerStartTime.Value.TimeOfDay,
                        Duration = duration,
                        Activity = textBoxActivity.Text,
                        ContactName = textBoxName.Text,
                        ContactEmail = textBoxEmail.Text,
                        GoldCardMember = checkBoxGoldCardMembership.Checked,
                        MembershipNumber = checkBoxGoldCardMembership.Checked ? textBoxMembershipNumber.Text : string.Empty
                    };
                    NewBooking = individualBooking;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void radioButtonGroupBooking_CheckedChanged(object sender, EventArgs e)
        {
            ToggleBookingDetails();
        }

        private void radioButtonIndividualBookings_CheckedChanged(object sender, EventArgs e)
        {
            ToggleBookingDetails();
        }

        private void ToggleBookingDetails()
        {
            groupBoxGroupBookings.Visible = radioButtonGroupBooking.Checked;
            groupBoxIndividualBookings.Visible = radioButtonIndividualBookings.Checked;
        }
    }
}
