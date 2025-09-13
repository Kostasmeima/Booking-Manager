namespace UosBookingManager
{
    partial class AddBookingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTittle = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.labelActivity = new System.Windows.Forms.Label();
            this.textBoxActivity = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelDuration = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.groupBoxIndividualBookings = new System.Windows.Forms.GroupBox();
            this.groupBoxGroupBookings = new System.Windows.Forms.GroupBox();
            this.radioButtonIndividualBookings = new System.Windows.Forms.RadioButton();
            this.radioButtonGroupBooking = new System.Windows.Forms.RadioButton();
            this.checkBoxGoldCardMembership = new System.Windows.Forms.CheckBox();
            this.labelMembershipNumber = new System.Windows.Forms.Label();
            this.textBoxMembershipNumber = new System.Windows.Forms.TextBox();
            this.labelParticipants = new System.Windows.Forms.Label();
            this.numericUpDownParticipants = new System.Windows.Forms.NumericUpDown();
            this.checkBoxCoachRequired = new System.Windows.Forms.CheckBox();
            this.labelCoachName = new System.Windows.Forms.Label();
            this.textBoxCoachName = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBoxIndividualBookings.SuspendLayout();
            this.groupBoxGroupBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParticipants)).BeginInit();
            this.SuspendLayout();
            this.radioButtonGroupBooking.CheckedChanged += new System.EventHandler(this.radioButtonGroupBooking_CheckedChanged);
            this.radioButtonIndividualBookings.CheckedChanged += new System.EventHandler(this.radioButtonIndividualBookings_CheckedChanged);
            // 
            // labelTittle
            // 
            this.labelTittle.AutoSize = true;
            this.labelTittle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTittle.Location = new System.Drawing.Point(36, 26);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(302, 30);
            this.labelTittle.TabIndex = 0;
            this.labelTittle.Text = "General Booking Information";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(35, 82);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(68, 15);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "Booking ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(113, 79);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 23);
            this.textBoxID.TabIndex = 2;
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Location = new System.Drawing.Point(35, 116);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(63, 15);
            this.labelStartTime.TabIndex = 3;
            this.labelStartTime.Text = "Start Time:";
            // 
            // dateTimePickerStartTime
            // 
            this.dateTimePickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerStartTime.Location = new System.Drawing.Point(113, 114);
            this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            this.dateTimePickerStartTime.Size = new System.Drawing.Size(100, 23);
            this.dateTimePickerStartTime.TabIndex = 4;
            // 
            // labelActivity
            // 
            this.labelActivity.AutoSize = true;
            this.labelActivity.Location = new System.Drawing.Point(285, 82);
            this.labelActivity.Name = "labelActivity";
            this.labelActivity.Size = new System.Drawing.Size(47, 15);
            this.labelActivity.TabIndex = 5;
            this.labelActivity.Text = "Activity";
            // 
            // textBoxActivity
            // 
            this.textBoxActivity.Location = new System.Drawing.Point(377, 79);
            this.textBoxActivity.Name = "textBoxActivity";
            this.textBoxActivity.Size = new System.Drawing.Size(151, 23);
            this.textBoxActivity.TabIndex = 6;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(35, 151);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(31, 15);
            this.labelDate.TabIndex = 7;
            this.labelDate.Text = "Date";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(113, 152);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(102, 23);
            this.dateTimePickerDate.TabIndex = 8;
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(285, 114);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(53, 15);
            this.labelDuration.TabIndex = 9;
            this.labelDuration.Text = "Duration";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(377, 114);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(63, 23);
            this.numericUpDown1.TabIndex = 10;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(285, 152);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(84, 15);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Contact Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(378, 149);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(150, 23);
            this.textBoxName.TabIndex = 12;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(377, 185);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(150, 23);
            this.textBoxEmail.TabIndex = 13;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(285, 188);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(81, 15);
            this.labelEmail.TabIndex = 14;
            this.labelEmail.Text = "Contact Email";
            // 
            // groupBoxIndividualBookings
            // 
            this.groupBoxIndividualBookings.Controls.Add(this.textBoxMembershipNumber);
            this.groupBoxIndividualBookings.Controls.Add(this.labelMembershipNumber);
            this.groupBoxIndividualBookings.Controls.Add(this.checkBoxGoldCardMembership);
            this.groupBoxIndividualBookings.Location = new System.Drawing.Point(62, 263);
            this.groupBoxIndividualBookings.Name = "groupBoxIndividualBookings";
            this.groupBoxIndividualBookings.Size = new System.Drawing.Size(304, 161);
            this.groupBoxIndividualBookings.TabIndex = 15;
            this.groupBoxIndividualBookings.TabStop = false;
            this.groupBoxIndividualBookings.Text = "Details";
            // 
            // groupBoxGroupBookings
            // 
            this.groupBoxGroupBookings.Controls.Add(this.textBoxCoachName);
            this.groupBoxGroupBookings.Controls.Add(this.labelCoachName);
            this.groupBoxGroupBookings.Controls.Add(this.checkBoxCoachRequired);
            this.groupBoxGroupBookings.Controls.Add(this.numericUpDownParticipants);
            this.groupBoxGroupBookings.Controls.Add(this.labelParticipants);
            this.groupBoxGroupBookings.Location = new System.Drawing.Point(452, 263);
            this.groupBoxGroupBookings.Name = "groupBoxGroupBookings";
            this.groupBoxGroupBookings.Size = new System.Drawing.Size(298, 161);
            this.groupBoxGroupBookings.TabIndex = 16;
            this.groupBoxGroupBookings.TabStop = false;
            this.groupBoxGroupBookings.Text = "Details";
            // 
            // radioButtonIndividualBookings
            // 
            this.radioButtonIndividualBookings.AutoSize = true;
            this.radioButtonIndividualBookings.Location = new System.Drawing.Point(62, 238);
            this.radioButtonIndividualBookings.Name = "radioButtonIndividualBookings";
            this.radioButtonIndividualBookings.Size = new System.Drawing.Size(124, 19);
            this.radioButtonIndividualBookings.TabIndex = 17;
            this.radioButtonIndividualBookings.TabStop = true;
            this.radioButtonIndividualBookings.Text = "Individual Booking";
            this.radioButtonIndividualBookings.UseVisualStyleBackColor = true;
            // 
            // radioButtonGroupBooking
            // 
            this.radioButtonGroupBooking.AutoSize = true;
            this.radioButtonGroupBooking.Location = new System.Drawing.Point(452, 238);
            this.radioButtonGroupBooking.Name = "radioButtonGroupBooking";
            this.radioButtonGroupBooking.Size = new System.Drawing.Size(105, 19);
            this.radioButtonGroupBooking.TabIndex = 18;
            this.radioButtonGroupBooking.TabStop = true;
            this.radioButtonGroupBooking.Text = "Group Booking";
            this.radioButtonGroupBooking.UseVisualStyleBackColor = true;
            // 
            // checkBoxGoldCardMembership
            // 
            this.checkBoxGoldCardMembership.AutoSize = true;
            this.checkBoxGoldCardMembership.Location = new System.Drawing.Point(14, 34);
            this.checkBoxGoldCardMembership.Name = "checkBoxGoldCardMembership";
            this.checkBoxGoldCardMembership.Size = new System.Drawing.Size(127, 19);
            this.checkBoxGoldCardMembership.TabIndex = 0;
            this.checkBoxGoldCardMembership.Text = "Gold Card Member";
            this.checkBoxGoldCardMembership.UseVisualStyleBackColor = true;
            // 
            // labelMembershipNumber
            // 
            this.labelMembershipNumber.AutoSize = true;
            this.labelMembershipNumber.Location = new System.Drawing.Point(14, 65);
            this.labelMembershipNumber.Name = "labelMembershipNumber";
            this.labelMembershipNumber.Size = new System.Drawing.Size(96, 15);
            this.labelMembershipNumber.TabIndex = 1;
            this.labelMembershipNumber.Text = "Membership No.";
            // 
            // textBoxMembershipNumber
            // 
            this.textBoxMembershipNumber.Location = new System.Drawing.Point(116, 59);
            this.textBoxMembershipNumber.Name = "textBoxMembershipNumber";
            this.textBoxMembershipNumber.Size = new System.Drawing.Size(133, 23);
            this.textBoxMembershipNumber.TabIndex = 2;
            // 
            // labelParticipants
            // 
            this.labelParticipants.AutoSize = true;
            this.labelParticipants.Location = new System.Drawing.Point(16, 36);
            this.labelParticipants.Name = "labelParticipants";
            this.labelParticipants.Size = new System.Drawing.Size(69, 15);
            this.labelParticipants.TabIndex = 0;
            this.labelParticipants.Text = "Participants";
            // 
            // numericUpDownParticipants
            // 
            this.numericUpDownParticipants.Location = new System.Drawing.Point(91, 36);
            this.numericUpDownParticipants.Name = "numericUpDownParticipants";
            this.numericUpDownParticipants.Size = new System.Drawing.Size(71, 23);
            this.numericUpDownParticipants.TabIndex = 1;
            // 
            // checkBoxCoachRequired
            // 
            this.checkBoxCoachRequired.AutoSize = true;
            this.checkBoxCoachRequired.Location = new System.Drawing.Point(20, 73);
            this.checkBoxCoachRequired.Name = "checkBoxCoachRequired";
            this.checkBoxCoachRequired.Size = new System.Drawing.Size(110, 19);
            this.checkBoxCoachRequired.TabIndex = 2;
            this.checkBoxCoachRequired.Text = "Coach Required";
            this.checkBoxCoachRequired.UseVisualStyleBackColor = true;
            // 
            // labelCoachName
            // 
            this.labelCoachName.AutoSize = true;
            this.labelCoachName.Location = new System.Drawing.Point(21, 104);
            this.labelCoachName.Name = "labelCoachName";
            this.labelCoachName.Size = new System.Drawing.Size(76, 15);
            this.labelCoachName.TabIndex = 3;
            this.labelCoachName.Text = "Coach Name";
            // 
            // textBoxCoachName
            // 
            this.textBoxCoachName.Location = new System.Drawing.Point(103, 101);
            this.textBoxCoachName.Name = "textBoxCoachName";
            this.textBoxCoachName.Size = new System.Drawing.Size(165, 23);
            this.textBoxCoachName.TabIndex = 4;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(632, 82);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 40);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;

            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(632, 134);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 41);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // AddBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.radioButtonGroupBooking);
            this.Controls.Add(this.radioButtonIndividualBookings);
            this.Controls.Add(this.groupBoxGroupBookings);
            this.Controls.Add(this.groupBoxIndividualBookings);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxActivity);
            this.Controls.Add(this.labelActivity);
            this.Controls.Add(this.dateTimePickerStartTime);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelTittle);
            this.Name = "AddBookingForm";
            this.Text = "AddBooking";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBoxIndividualBookings.ResumeLayout(false);
            this.groupBoxIndividualBookings.PerformLayout();
            this.groupBoxGroupBookings.ResumeLayout(false);
            this.groupBoxGroupBookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownParticipants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTittle;
        private Label labelID;
        private TextBox textBoxID;
        private Label labelStartTime;
        private DateTimePicker dateTimePickerStartTime;
        private Label labelActivity;
        private TextBox textBoxActivity;
        private Label labelDate;
        private DateTimePicker dateTimePickerDate;
        private Label labelDuration;
        private NumericUpDown numericUpDown1;
        private Label labelName;
        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private GroupBox groupBoxIndividualBookings;
        private TextBox textBoxMembershipNumber;
        private Label labelMembershipNumber;
        private CheckBox checkBoxGoldCardMembership;
        private GroupBox groupBoxGroupBookings;
        private TextBox textBoxCoachName;
        private Label labelCoachName;
        private CheckBox checkBoxCoachRequired;
        private NumericUpDown numericUpDownParticipants;
        private Label labelParticipants;
        private RadioButton radioButtonIndividualBookings;
        private RadioButton radioButtonGroupBooking;
        private Button buttonSave;
        private Button buttonCancel;
    }
}