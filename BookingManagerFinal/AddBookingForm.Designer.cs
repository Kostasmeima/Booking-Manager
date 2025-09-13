using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsClubBookingSystem
{
    public partial class AddBookingForm : Form
    {
        public AddBookingForm()
        {
            InitializeComponent();
        }

        private Label lblId;

        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.lblDuration = new System.Windows.Forms.Label();
            this.numericUpDownDuration = new System.Windows.Forms.NumericUpDown();
            this.lblActivity = new System.Windows.Forms.Label();
            this.txtActivity = new System.Windows.Forms.TextBox();
            this.lblContactName = new System.Windows.Forms.Label();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.lblContactEmail = new System.Windows.Forms.Label();
            this.txtContactEmail = new System.Windows.Forms.TextBox();
            this.lblParticipants = new System.Windows.Forms.Label();
            this.numericUpDownParticipants = new System.Windows.Forms.NumericUpDown();
            this.lblCoachRequired = new System.Windows.Forms.Label();
            this.checkBoxCoach = new System.Windows.Forms.CheckBox();
            this.lblCoachName = new System.Windows.Forms.Label();
            this.txtCoachName = new System.Windows.Forms.TextBox();
            this.lblGoldCardMember = new System.Windows.Forms.Label();
            this.checkBoxGoldCardMember = new System.Windows.Forms.CheckBox();
            this.lbltxtMembershipNumber = new System.Windows.Forms.Label();
            this.txtMembershipNumber = new System.Windows.Forms.TextBox();
            this.btnAddBooking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParticipants)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(70, 80);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(174, 77);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(70, 122);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(31, 15);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(174, 116);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerDate.TabIndex = 3;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(70, 161);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(63, 15);
            this.lblStartTime.TabIndex = 4;
            this.lblStartTime.Text = "Start Time:";
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(174, 153);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerTime.TabIndex = 5;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(67, 209);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(97, 15);
            this.lblDuration.TabIndex = 6;
            this.lblDuration.Text = "Duration (hours):";
            // 
            // numericUpDownDuration
            // 
            this.numericUpDownDuration.Location = new System.Drawing.Point(175, 204);
            this.numericUpDownDuration.Name = "numericUpDownDuration";
            this.numericUpDownDuration.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownDuration.TabIndex = 7;
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Location = new System.Drawing.Point(67, 249);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(50, 15);
            this.lblActivity.TabIndex = 8;
            this.lblActivity.Text = "Activity:";
            // 
            // txtActivity
            // 
            this.txtActivity.Location = new System.Drawing.Point(174, 246);
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Size = new System.Drawing.Size(100, 23);
            this.txtActivity.TabIndex = 9;
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Location = new System.Drawing.Point(67, 293);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(87, 15);
            this.lblContactName.TabIndex = 10;
            this.lblContactName.Text = "Contact Name:";
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(175, 290);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(100, 23);
            this.txtContactName.TabIndex = 11;
            // 
            // lblContactEmail
            // 
            this.lblContactEmail.AutoSize = true;
            this.lblContactEmail.Location = new System.Drawing.Point(67, 334);
            this.lblContactEmail.Name = "lblContactEmail";
            this.lblContactEmail.Size = new System.Drawing.Size(84, 15);
            this.lblContactEmail.TabIndex = 12;
            this.lblContactEmail.Text = "Contact email:";
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.Location = new System.Drawing.Point(174, 331);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.Size = new System.Drawing.Size(100, 23);
            this.txtContactEmail.TabIndex = 13;
            // 
            // lblParticipants
            // 
            this.lblParticipants.AutoSize = true;
            this.lblParticipants.Location = new System.Drawing.Point(67, 382);
            this.lblParticipants.Name = "lblParticipants";
            this.lblParticipants.Size = new System.Drawing.Size(72, 15);
            this.lblParticipants.TabIndex = 14;
            this.lblParticipants.Text = "Participants:";
            // 
            // numericUpDownParticipants
            // 
            this.numericUpDownParticipants.Location = new System.Drawing.Point(174, 380);
            this.numericUpDownParticipants.Name = "numericUpDownParticipants";
            this.numericUpDownParticipants.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownParticipants.TabIndex = 15;
            // 
            // lblCoachRequired
            // 
            this.lblCoachRequired.AutoSize = true;
            this.lblCoachRequired.Location = new System.Drawing.Point(455, 80);
            this.lblCoachRequired.Name = "lblCoachRequired";
            this.lblCoachRequired.Size = new System.Drawing.Size(97, 15);
            this.lblCoachRequired.TabIndex = 16;
            this.lblCoachRequired.Text = "Coach requeired:";
            // 
            // checkBoxCoach
            // 
            this.checkBoxCoach.AutoSize = true;
            this.checkBoxCoach.Location = new System.Drawing.Point(558, 81);
            this.checkBoxCoach.Name = "checkBoxCoach";
            this.checkBoxCoach.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCoach.TabIndex = 17;
            this.checkBoxCoach.UseVisualStyleBackColor = true;
            // 
            // lblCoachName
            // 
            this.lblCoachName.AutoSize = true;
            this.lblCoachName.Location = new System.Drawing.Point(455, 116);
            this.lblCoachName.Name = "lblCoachName";
            this.lblCoachName.Size = new System.Drawing.Size(77, 15);
            this.lblCoachName.TabIndex = 18;
            this.lblCoachName.Text = "Coach name:";
            // 
            // txtCoachName
            // 
            this.txtCoachName.Location = new System.Drawing.Point(544, 116);
            this.txtCoachName.Name = "txtCoachName";
            this.txtCoachName.Size = new System.Drawing.Size(153, 23);
            this.txtCoachName.TabIndex = 19;
            // 
            // lblGoldCardMember
            // 
            this.lblGoldCardMember.AutoSize = true;
            this.lblGoldCardMember.Location = new System.Drawing.Point(455, 161);
            this.lblGoldCardMember.Name = "lblGoldCardMember";
            this.lblGoldCardMember.Size = new System.Drawing.Size(111, 15);
            this.lblGoldCardMember.TabIndex = 20;
            this.lblGoldCardMember.Text = "Gold Card Member:";
            // 
            // checkBoxGoldCardMember
            // 
            this.checkBoxGoldCardMember.AutoSize = true;
            this.checkBoxGoldCardMember.Location = new System.Drawing.Point(572, 162);
            this.checkBoxGoldCardMember.Name = "checkBoxGoldCardMember";
            this.checkBoxGoldCardMember.Size = new System.Drawing.Size(15, 14);
            this.checkBoxGoldCardMember.TabIndex = 21;
            this.checkBoxGoldCardMember.UseVisualStyleBackColor = true;
            // 
            // lbltxtMembershipNumber
            // 
            this.lbltxtMembershipNumber.AutoSize = true;
            this.lbltxtMembershipNumber.Location = new System.Drawing.Point(604, 162);
            this.lbltxtMembershipNumber.Name = "lbltxtMembershipNumber";
            this.lbltxtMembershipNumber.Size = new System.Drawing.Size(124, 15);
            this.lbltxtMembershipNumber.TabIndex = 22;
            this.lbltxtMembershipNumber.Text = "Membership Number:";
            // 
            // txtMembershipNumber
            // 
            this.txtMembershipNumber.Location = new System.Drawing.Point(734, 162);
            this.txtMembershipNumber.Name = "txtMembershipNumber";
            this.txtMembershipNumber.Size = new System.Drawing.Size(58, 23);
            this.txtMembershipNumber.TabIndex = 23;
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Location = new System.Drawing.Point(622, 285);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(75, 23);
            this.btnAddBooking.TabIndex = 24;
            this.btnAddBooking.Text = "Save";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            // 
            // AddBookingForm
            // 
            this.ClientSize = new System.Drawing.Size(869, 463);
            this.Controls.Add(this.btnAddBooking);
            this.Controls.Add(this.txtMembershipNumber);
            this.Controls.Add(this.lbltxtMembershipNumber);
            this.Controls.Add(this.checkBoxGoldCardMember);
            this.Controls.Add(this.lblGoldCardMember);
            this.Controls.Add(this.txtCoachName);
            this.Controls.Add(this.lblCoachName);
            this.Controls.Add(this.checkBoxCoach);
            this.Controls.Add(this.lblCoachRequired);
            this.Controls.Add(this.numericUpDownParticipants);
            this.Controls.Add(this.lblParticipants);
            this.Controls.Add(this.txtContactEmail);
            this.Controls.Add(this.lblContactEmail);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(this.lblContactName);
            this.Controls.Add(this.txtActivity);
            this.Controls.Add(this.lblActivity);
            this.Controls.Add(this.numericUpDownDuration);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.dateTimePickerTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Name = "AddBookingForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParticipants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private TextBox txtId;
        private Label lblDate;
        private DateTimePicker dateTimePickerDate;
        private Label lblStartTime;
        private DateTimePicker dateTimePickerTime;
        private Label lblDuration;
        private NumericUpDown numericUpDownDuration;
        private Label lblActivity;
        private TextBox txtActivity;
        private Label lblContactName;
        private TextBox txtContactName;
        private Label lblContactEmail;
        private TextBox txtContactEmail;
        private Label lblParticipants;
        private NumericUpDown numericUpDownParticipants;
        private Label lblCoachRequired;
        private CheckBox checkBoxCoach;
        private Label lblCoachName;
        private TextBox txtCoachName;
        private Label lblGoldCardMember;
        private CheckBox checkBoxGoldCardMember;
    }
}
