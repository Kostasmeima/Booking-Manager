namespace UosBookingManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddBooking = new System.Windows.Forms.Button();
            this.buttonAddBooking.Click += new System.EventHandler(this.buttonAddBooking_Click);
            this.buttonEditBooking = new System.Windows.Forms.Button();
            this.buttonEditBooking.Click += new System.EventHandler(this.buttonEditBooking_Click);
            this.buttonDeleteBooking = new System.Windows.Forms.Button();
            this.buttonDeleteBooking.Click += new System.EventHandler(this.buttonDeleteBooking_Click);
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            this.radioButtonGroup = new System.Windows.Forms.RadioButton();
            this.radioButtonGroup.CheckedChanged += new System.EventHandler(this.radioButtonGroup_CheckedChanged);
            this.radioButtonIndividual = new System.Windows.Forms.RadioButton();
            this.radioButtonIndividual.CheckedChanged += new System.EventHandler(this.radioButtonIndividual_CheckedChanged);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpTopicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxFilters.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(753, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonAddBooking
            // 
            this.buttonAddBooking.Location = new System.Drawing.Point(22, 62);
            this.buttonAddBooking.Name = "buttonAddBooking";
            this.buttonAddBooking.Size = new System.Drawing.Size(99, 41);
            this.buttonAddBooking.TabIndex = 1;
            this.buttonAddBooking.Text = "Add Booking";
            this.buttonAddBooking.UseVisualStyleBackColor = true;
            // 
            // buttonEditBooking
            // 
            this.buttonEditBooking.Location = new System.Drawing.Point(145, 64);
            this.buttonEditBooking.Name = "buttonEditBooking";
            this.buttonEditBooking.Size = new System.Drawing.Size(99, 37);
            this.buttonEditBooking.TabIndex = 2;
            this.buttonEditBooking.Text = "Edit Booking";
            this.buttonEditBooking.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteBooking
            // 
            this.buttonDeleteBooking.Location = new System.Drawing.Point(270, 64);
            this.buttonDeleteBooking.Name = "buttonDeleteBooking";
            this.buttonDeleteBooking.Size = new System.Drawing.Size(99, 37);
            this.buttonDeleteBooking.TabIndex = 3;
            this.buttonDeleteBooking.Text = "Delete Booking";
            this.buttonDeleteBooking.UseVisualStyleBackColor = true;
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.radioButtonIndividual);
            this.groupBoxFilters.Controls.Add(this.radioButtonGroup);
            this.groupBoxFilters.Controls.Add(this.radioButtonAll);
            this.groupBoxFilters.Location = new System.Drawing.Point(25, 121);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(468, 50);
            this.groupBoxFilters.TabIndex = 4;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Filters";
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Location = new System.Drawing.Point(9, 20);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(123, 19);
            this.radioButtonAll.TabIndex = 0;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "Show All Bookings";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // radioButtonGroup
            // 
            this.radioButtonGroup.AutoSize = true;
            this.radioButtonGroup.Location = new System.Drawing.Point(138, 21);
            this.radioButtonGroup.Name = "radioButtonGroup";
            this.radioButtonGroup.Size = new System.Drawing.Size(142, 19);
            this.radioButtonGroup.TabIndex = 1;
            this.radioButtonGroup.TabStop = true;
            this.radioButtonGroup.Text = "Show Group Bookings";
            this.radioButtonGroup.UseVisualStyleBackColor = true;
            // 
            // radioButtonIndividual
            // 
            this.radioButtonIndividual.AutoSize = true;
            this.radioButtonIndividual.Location = new System.Drawing.Point(286, 21);
            this.radioButtonIndividual.Name = "radioButtonIndividual";
            this.radioButtonIndividual.Size = new System.Drawing.Size(161, 19);
            this.radioButtonIndividual.TabIndex = 2;
            this.radioButtonIndividual.TabStop = true;
            this.radioButtonIndividual.Text = "Show Individual Bookings";
            this.radioButtonIndividual.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpTopicsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpTopicsToolStripMenuItem
            // 
            this.helpTopicsToolStripMenuItem.Name = "helpTopicsToolStripMenuItem";
            this.helpTopicsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpTopicsToolStripMenuItem.Text = "Help Topics";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxFilters);
            this.Controls.Add(this.buttonDeleteBooking);
            this.Controls.Add(this.buttonEditBooking);
            this.Controls.Add(this.buttonAddBooking);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonAddBooking;
        private Button buttonEditBooking;
        private Button buttonDeleteBooking;
        private GroupBox groupBoxFilters;
        private RadioButton radioButtonIndividual;
        private RadioButton radioButtonGroup;
        private RadioButton radioButtonAll;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem helpTopicsToolStripMenuItem;
    }
}