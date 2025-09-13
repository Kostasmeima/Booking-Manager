namespace SportsClubBookingSystem
{
    partial class ViewBookingsForm
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
            this.listBoxBookings = new System.Windows.Forms.ListBox();
            this.btnFilterIndividualBookings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxBookings
            // 
            this.listBoxBookings.FormattingEnabled = true;
            this.listBoxBookings.ItemHeight = 15;
            this.listBoxBookings.Location = new System.Drawing.Point(125, 27);
            this.listBoxBookings.Name = "listBoxBookings";
            this.listBoxBookings.Size = new System.Drawing.Size(545, 334);
            this.listBoxBookings.TabIndex = 0;
            // 
            // btnFilterIndividualBookings
            // 
            this.btnFilterIndividualBookings.Location = new System.Drawing.Point(336, 388);
            this.btnFilterIndividualBookings.Name = "btnFilterIndividualBookings";
            this.btnFilterIndividualBookings.Size = new System.Drawing.Size(140, 31);
            this.btnFilterIndividualBookings.TabIndex = 1;
            this.btnFilterIndividualBookings.Text = "Filtered bookings";
            this.btnFilterIndividualBookings.UseVisualStyleBackColor = true;
            // 
            // ViewBookingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFilterIndividualBookings);
            this.Controls.Add(this.listBoxBookings);
            this.Name = "ViewBookingsForm";
            this.Text = "ViewBookingsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBoxBookings;
        private Button btnFilterIndividualBookings;
    }
}