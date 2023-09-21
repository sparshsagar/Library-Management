
namespace Assignment
{
    partial class frmStd_ChangeBooking
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
            this.frmStd_ChgBook_ComboBox_Room = new System.Windows.Forms.ComboBox();
            this.frmStd_ChgBook_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.frmStd_ChgBook_ComboBox_Start = new System.Windows.Forms.ComboBox();
            this.frmStd_ChgBook_ComboBox_End = new System.Windows.Forms.ComboBox();
            this.frmStd_ChgBook_lbl_Room = new System.Windows.Forms.Label();
            this.frmStd_ChgBook_lbl_Date = new System.Windows.Forms.Label();
            this.frmStd_ChgBook_lbl_Start = new System.Windows.Forms.Label();
            this.frmStd_ChgBook_lbl_End = new System.Windows.Forms.Label();
            this.frmStd_ChgBook_BtnProceed = new System.Windows.Forms.Button();
            this.frmStd_ChgBook_BtnMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // frmStd_ChgBook_ComboBox_Room
            // 
            this.frmStd_ChgBook_ComboBox_Room.FormattingEnabled = true;
            this.frmStd_ChgBook_ComboBox_Room.Items.AddRange(new object[] {
            "Amber1",
            "Amber2",
            "Amber3",
            "Amber4",
            "Amber5",
            "BlackThorn1",
            "BlackThorn2",
            "BlackThorn3",
            "BlackThorn4",
            "Cedar1",
            "Cedar2",
            "Cedar3",
            "Cedar4",
            "Cedar5",
            "Cedar6",
            "Daphne1",
            "Daphne2",
            "Daphne3",
            "Daphne4",
            "Daphne5"});
            this.frmStd_ChgBook_ComboBox_Room.Location = new System.Drawing.Point(197, 78);
            this.frmStd_ChgBook_ComboBox_Room.Name = "frmStd_ChgBook_ComboBox_Room";
            this.frmStd_ChgBook_ComboBox_Room.Size = new System.Drawing.Size(121, 24);
            this.frmStd_ChgBook_ComboBox_Room.TabIndex = 0;
            // 
            // frmStd_ChgBook_dateTimePicker
            // 
            this.frmStd_ChgBook_dateTimePicker.Location = new System.Drawing.Point(197, 120);
            this.frmStd_ChgBook_dateTimePicker.Name = "frmStd_ChgBook_dateTimePicker";
            this.frmStd_ChgBook_dateTimePicker.Size = new System.Drawing.Size(250, 22);
            this.frmStd_ChgBook_dateTimePicker.TabIndex = 1;
            // 
            // frmStd_ChgBook_ComboBox_Start
            // 
            this.frmStd_ChgBook_ComboBox_Start.FormattingEnabled = true;
            this.frmStd_ChgBook_ComboBox_Start.Items.AddRange(new object[] {
            "9AM",
            "10AM",
            "11AM",
            "12PM",
            "1PM",
            "2PM",
            "3PM",
            "4PM",
            "5PM"});
            this.frmStd_ChgBook_ComboBox_Start.Location = new System.Drawing.Point(197, 163);
            this.frmStd_ChgBook_ComboBox_Start.Name = "frmStd_ChgBook_ComboBox_Start";
            this.frmStd_ChgBook_ComboBox_Start.Size = new System.Drawing.Size(121, 24);
            this.frmStd_ChgBook_ComboBox_Start.TabIndex = 2;
            this.frmStd_ChgBook_ComboBox_Start.SelectedIndexChanged += new System.EventHandler(this.frmStd_ChgBook_ComboBox_Start_SelectedIndexChanged);
            // 
            // frmStd_ChgBook_ComboBox_End
            // 
            this.frmStd_ChgBook_ComboBox_End.FormattingEnabled = true;
            this.frmStd_ChgBook_ComboBox_End.Location = new System.Drawing.Point(197, 207);
            this.frmStd_ChgBook_ComboBox_End.Name = "frmStd_ChgBook_ComboBox_End";
            this.frmStd_ChgBook_ComboBox_End.Size = new System.Drawing.Size(121, 24);
            this.frmStd_ChgBook_ComboBox_End.TabIndex = 3;
            // 
            // frmStd_ChgBook_lbl_Room
            // 
            this.frmStd_ChgBook_lbl_Room.AutoSize = true;
            this.frmStd_ChgBook_lbl_Room.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmStd_ChgBook_lbl_Room.Location = new System.Drawing.Point(92, 78);
            this.frmStd_ChgBook_lbl_Room.Name = "frmStd_ChgBook_lbl_Room";
            this.frmStd_ChgBook_lbl_Room.Size = new System.Drawing.Size(57, 22);
            this.frmStd_ChgBook_lbl_Room.TabIndex = 4;
            this.frmStd_ChgBook_lbl_Room.Text = "Room";
            // 
            // frmStd_ChgBook_lbl_Date
            // 
            this.frmStd_ChgBook_lbl_Date.AutoSize = true;
            this.frmStd_ChgBook_lbl_Date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmStd_ChgBook_lbl_Date.Location = new System.Drawing.Point(92, 121);
            this.frmStd_ChgBook_lbl_Date.Name = "frmStd_ChgBook_lbl_Date";
            this.frmStd_ChgBook_lbl_Date.Size = new System.Drawing.Size(47, 22);
            this.frmStd_ChgBook_lbl_Date.TabIndex = 4;
            this.frmStd_ChgBook_lbl_Date.Text = "Date";
            // 
            // frmStd_ChgBook_lbl_Start
            // 
            this.frmStd_ChgBook_lbl_Start.AutoSize = true;
            this.frmStd_ChgBook_lbl_Start.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmStd_ChgBook_lbl_Start.Location = new System.Drawing.Point(92, 162);
            this.frmStd_ChgBook_lbl_Start.Name = "frmStd_ChgBook_lbl_Start";
            this.frmStd_ChgBook_lbl_Start.Size = new System.Drawing.Size(86, 22);
            this.frmStd_ChgBook_lbl_Start.TabIndex = 4;
            this.frmStd_ChgBook_lbl_Start.Text = "Start time";
            // 
            // frmStd_ChgBook_lbl_End
            // 
            this.frmStd_ChgBook_lbl_End.AutoSize = true;
            this.frmStd_ChgBook_lbl_End.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmStd_ChgBook_lbl_End.Location = new System.Drawing.Point(92, 207);
            this.frmStd_ChgBook_lbl_End.Name = "frmStd_ChgBook_lbl_End";
            this.frmStd_ChgBook_lbl_End.Size = new System.Drawing.Size(80, 22);
            this.frmStd_ChgBook_lbl_End.TabIndex = 4;
            this.frmStd_ChgBook_lbl_End.Text = "End time";
            // 
            // frmStd_ChgBook_BtnProceed
            // 
            this.frmStd_ChgBook_BtnProceed.BackColor = System.Drawing.SystemColors.Highlight;
            this.frmStd_ChgBook_BtnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.frmStd_ChgBook_BtnProceed.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmStd_ChgBook_BtnProceed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.frmStd_ChgBook_BtnProceed.Location = new System.Drawing.Point(194, 302);
            this.frmStd_ChgBook_BtnProceed.Name = "frmStd_ChgBook_BtnProceed";
            this.frmStd_ChgBook_BtnProceed.Size = new System.Drawing.Size(159, 43);
            this.frmStd_ChgBook_BtnProceed.TabIndex = 5;
            this.frmStd_ChgBook_BtnProceed.Text = "Proceed";
            this.frmStd_ChgBook_BtnProceed.UseVisualStyleBackColor = false;
            this.frmStd_ChgBook_BtnProceed.Click += new System.EventHandler(this.frmStd_ChgBook_BtnProceed_Click);
            // 
            // frmStd_ChgBook_BtnMenu
            // 
            this.frmStd_ChgBook_BtnMenu.BackColor = System.Drawing.SystemColors.Highlight;
            this.frmStd_ChgBook_BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.frmStd_ChgBook_BtnMenu.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmStd_ChgBook_BtnMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.frmStd_ChgBook_BtnMenu.Location = new System.Drawing.Point(194, 362);
            this.frmStd_ChgBook_BtnMenu.Name = "frmStd_ChgBook_BtnMenu";
            this.frmStd_ChgBook_BtnMenu.Size = new System.Drawing.Size(159, 43);
            this.frmStd_ChgBook_BtnMenu.TabIndex = 6;
            this.frmStd_ChgBook_BtnMenu.Text = "Back to menu";
            this.frmStd_ChgBook_BtnMenu.UseVisualStyleBackColor = false;
            this.frmStd_ChgBook_BtnMenu.Click += new System.EventHandler(this.frmStd_ChgBook_BtnMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(57, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 224);
            this.panel1.TabIndex = 7;
            // 
            // frmStd_ChangeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment.Properties.Resources.Uwbu7x;
            this.ClientSize = new System.Drawing.Size(548, 431);
            this.Controls.Add(this.frmStd_ChgBook_BtnMenu);
            this.Controls.Add(this.frmStd_ChgBook_BtnProceed);
            this.Controls.Add(this.frmStd_ChgBook_lbl_End);
            this.Controls.Add(this.frmStd_ChgBook_lbl_Start);
            this.Controls.Add(this.frmStd_ChgBook_lbl_Date);
            this.Controls.Add(this.frmStd_ChgBook_lbl_Room);
            this.Controls.Add(this.frmStd_ChgBook_ComboBox_End);
            this.Controls.Add(this.frmStd_ChgBook_ComboBox_Start);
            this.Controls.Add(this.frmStd_ChgBook_dateTimePicker);
            this.Controls.Add(this.frmStd_ChgBook_ComboBox_Room);
            this.Controls.Add(this.panel1);
            this.Name = "frmStd_ChangeBooking";
            this.Text = "Change Booking";
            this.Load += new System.EventHandler(this.frmStd_ChangeBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox frmStd_ChgBook_ComboBox_Room;
        private System.Windows.Forms.DateTimePicker frmStd_ChgBook_dateTimePicker;
        private System.Windows.Forms.ComboBox frmStd_ChgBook_ComboBox_Start;
        private System.Windows.Forms.ComboBox frmStd_ChgBook_ComboBox_End;
        private System.Windows.Forms.Label frmStd_ChgBook_lbl_Room;
        private System.Windows.Forms.Label frmStd_ChgBook_lbl_Date;
        private System.Windows.Forms.Label frmStd_ChgBook_lbl_Start;
        private System.Windows.Forms.Label frmStd_ChgBook_lbl_End;
        private System.Windows.Forms.Button frmStd_ChgBook_BtnProceed;
        private System.Windows.Forms.Button frmStd_ChgBook_BtnMenu;
        private System.Windows.Forms.Panel panel1;
    }
}