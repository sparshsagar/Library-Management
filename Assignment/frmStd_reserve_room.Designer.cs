
namespace Assignment
{
    partial class frmStd_reserve_room
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
            this.StdReserve_lbl_Title = new System.Windows.Forms.Label();
            this.StdReserve_lbl_Room = new System.Windows.Forms.Label();
            this.StdReserve_lbl_Date = new System.Windows.Forms.Label();
            this.StdReserve_lbl_TimeStart = new System.Windows.Forms.Label();
            this.StdReserve_lbl_TimeEnd = new System.Windows.Forms.Label();
            this.StdReserve_Combobox_Room = new System.Windows.Forms.ComboBox();
            this.StdReserve_btn_Proceed = new System.Windows.Forms.Button();
            this.StdReserve_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StdReserve_room_table = new System.Windows.Forms.TableLayoutPanel();
            this.StdReserve_lbl_Room_Name = new System.Windows.Forms.Label();
            this.StdReserve_lbl_Room_Capacity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.StdReserve_dataGridView_available_time = new System.Windows.Forms.DataGridView();
            this.StdReserve_comboStartTime = new System.Windows.Forms.ComboBox();
            this.StdReserve_comboEndTime = new System.Windows.Forms.ComboBox();
            this.StdReserve_btn_Menu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StdReserve_btnCheckTimes = new System.Windows.Forms.Button();
            this.StdReserve_lbl_Reason = new System.Windows.Forms.Label();
            this.StdReserve_RichTxtBox_Reason = new System.Windows.Forms.RichTextBox();
            this.StdReserve_room_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StdReserve_dataGridView_available_time)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StdReserve_lbl_Title
            // 
            this.StdReserve_lbl_Title.AutoSize = true;
            this.StdReserve_lbl_Title.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdReserve_lbl_Title.Location = new System.Drawing.Point(33, 36);
            this.StdReserve_lbl_Title.Name = "StdReserve_lbl_Title";
            this.StdReserve_lbl_Title.Size = new System.Drawing.Size(394, 29);
            this.StdReserve_lbl_Title.TabIndex = 0;
            this.StdReserve_lbl_Title.Text = "Discussion room reservation";
            // 
            // StdReserve_lbl_Room
            // 
            this.StdReserve_lbl_Room.AutoSize = true;
            this.StdReserve_lbl_Room.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdReserve_lbl_Room.Location = new System.Drawing.Point(20, 76);
            this.StdReserve_lbl_Room.Name = "StdReserve_lbl_Room";
            this.StdReserve_lbl_Room.Size = new System.Drawing.Size(63, 22);
            this.StdReserve_lbl_Room.TabIndex = 1;
            this.StdReserve_lbl_Room.Text = "Room:";
            // 
            // StdReserve_lbl_Date
            // 
            this.StdReserve_lbl_Date.AutoSize = true;
            this.StdReserve_lbl_Date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdReserve_lbl_Date.Location = new System.Drawing.Point(20, 115);
            this.StdReserve_lbl_Date.Name = "StdReserve_lbl_Date";
            this.StdReserve_lbl_Date.Size = new System.Drawing.Size(53, 22);
            this.StdReserve_lbl_Date.TabIndex = 2;
            this.StdReserve_lbl_Date.Text = "Date:";
            // 
            // StdReserve_lbl_TimeStart
            // 
            this.StdReserve_lbl_TimeStart.AutoSize = true;
            this.StdReserve_lbl_TimeStart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdReserve_lbl_TimeStart.Location = new System.Drawing.Point(20, 348);
            this.StdReserve_lbl_TimeStart.Name = "StdReserve_lbl_TimeStart";
            this.StdReserve_lbl_TimeStart.Size = new System.Drawing.Size(143, 22);
            this.StdReserve_lbl_TimeStart.TabIndex = 3;
            this.StdReserve_lbl_TimeStart.Text = "Select start time:";
            // 
            // StdReserve_lbl_TimeEnd
            // 
            this.StdReserve_lbl_TimeEnd.AutoSize = true;
            this.StdReserve_lbl_TimeEnd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdReserve_lbl_TimeEnd.Location = new System.Drawing.Point(23, 382);
            this.StdReserve_lbl_TimeEnd.Name = "StdReserve_lbl_TimeEnd";
            this.StdReserve_lbl_TimeEnd.Size = new System.Drawing.Size(137, 22);
            this.StdReserve_lbl_TimeEnd.TabIndex = 4;
            this.StdReserve_lbl_TimeEnd.Text = "Select end time:";
            // 
            // StdReserve_Combobox_Room
            // 
            this.StdReserve_Combobox_Room.FormattingEnabled = true;
            this.StdReserve_Combobox_Room.Items.AddRange(new object[] {
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
            this.StdReserve_Combobox_Room.Location = new System.Drawing.Point(88, 76);
            this.StdReserve_Combobox_Room.Name = "StdReserve_Combobox_Room";
            this.StdReserve_Combobox_Room.Size = new System.Drawing.Size(134, 24);
            this.StdReserve_Combobox_Room.TabIndex = 5;
            this.StdReserve_Combobox_Room.Text = "<select a room>";
            this.StdReserve_Combobox_Room.SelectedIndexChanged += new System.EventHandler(this.StdReserve_Combobox_Room_SelectedIndexChanged);
            // 
            // StdReserve_btn_Proceed
            // 
            this.StdReserve_btn_Proceed.BackColor = System.Drawing.SystemColors.Highlight;
            this.StdReserve_btn_Proceed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StdReserve_btn_Proceed.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdReserve_btn_Proceed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StdReserve_btn_Proceed.Location = new System.Drawing.Point(689, 485);
            this.StdReserve_btn_Proceed.Name = "StdReserve_btn_Proceed";
            this.StdReserve_btn_Proceed.Size = new System.Drawing.Size(164, 41);
            this.StdReserve_btn_Proceed.TabIndex = 10;
            this.StdReserve_btn_Proceed.Text = "Proceed";
            this.StdReserve_btn_Proceed.UseVisualStyleBackColor = false;
            this.StdReserve_btn_Proceed.Click += new System.EventHandler(this.StdReserve_btn_Proceed_Click);
            // 
            // StdReserve_dateTimePicker
            // 
            this.StdReserve_dateTimePicker.Location = new System.Drawing.Point(88, 114);
            this.StdReserve_dateTimePicker.Name = "StdReserve_dateTimePicker";
            this.StdReserve_dateTimePicker.Size = new System.Drawing.Size(229, 22);
            this.StdReserve_dateTimePicker.TabIndex = 11;
            // 
            // StdReserve_room_table
            // 
            this.StdReserve_room_table.BackColor = System.Drawing.Color.White;
            this.StdReserve_room_table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.StdReserve_room_table.ColumnCount = 2;
            this.StdReserve_room_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StdReserve_room_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.StdReserve_room_table.Controls.Add(this.StdReserve_lbl_Room_Name, 0, 0);
            this.StdReserve_room_table.Controls.Add(this.StdReserve_lbl_Room_Capacity, 1, 0);
            this.StdReserve_room_table.Controls.Add(this.label3, 0, 1);
            this.StdReserve_room_table.Controls.Add(this.label4, 0, 2);
            this.StdReserve_room_table.Controls.Add(this.label5, 0, 3);
            this.StdReserve_room_table.Controls.Add(this.label6, 0, 4);
            this.StdReserve_room_table.Controls.Add(this.label7, 1, 1);
            this.StdReserve_room_table.Controls.Add(this.label8, 1, 2);
            this.StdReserve_room_table.Controls.Add(this.label9, 1, 3);
            this.StdReserve_room_table.Controls.Add(this.label10, 1, 4);
            this.StdReserve_room_table.Location = new System.Drawing.Point(437, 69);
            this.StdReserve_room_table.Name = "StdReserve_room_table";
            this.StdReserve_room_table.RowCount = 5;
            this.StdReserve_room_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.StdReserve_room_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.StdReserve_room_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.StdReserve_room_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.StdReserve_room_table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.StdReserve_room_table.Size = new System.Drawing.Size(382, 111);
            this.StdReserve_room_table.TabIndex = 12;
            this.StdReserve_room_table.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // StdReserve_lbl_Room_Name
            // 
            this.StdReserve_lbl_Room_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.StdReserve_lbl_Room_Name.Location = new System.Drawing.Point(2, 2);
            this.StdReserve_lbl_Room_Name.Margin = new System.Windows.Forms.Padding(0);
            this.StdReserve_lbl_Room_Name.Name = "StdReserve_lbl_Room_Name";
            this.StdReserve_lbl_Room_Name.Size = new System.Drawing.Size(161, 20);
            this.StdReserve_lbl_Room_Name.TabIndex = 0;
            this.StdReserve_lbl_Room_Name.Text = "Room Name";
            // 
            // StdReserve_lbl_Room_Capacity
            // 
            this.StdReserve_lbl_Room_Capacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.StdReserve_lbl_Room_Capacity.Location = new System.Drawing.Point(165, 2);
            this.StdReserve_lbl_Room_Capacity.Margin = new System.Windows.Forms.Padding(0);
            this.StdReserve_lbl_Room_Capacity.Name = "StdReserve_lbl_Room_Capacity";
            this.StdReserve_lbl_Room_Capacity.Size = new System.Drawing.Size(215, 20);
            this.StdReserve_lbl_Room_Capacity.TabIndex = 1;
            this.StdReserve_lbl_Room_Capacity.Text = "Capacity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "BlackThorn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cedar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Daphne";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(168, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(168, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "2";
            // 
            // StdReserve_dataGridView_available_time
            // 
            this.StdReserve_dataGridView_available_time.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StdReserve_dataGridView_available_time.Location = new System.Drawing.Point(24, 190);
            this.StdReserve_dataGridView_available_time.Name = "StdReserve_dataGridView_available_time";
            this.StdReserve_dataGridView_available_time.RowHeadersWidth = 51;
            this.StdReserve_dataGridView_available_time.RowTemplate.Height = 24;
            this.StdReserve_dataGridView_available_time.Size = new System.Drawing.Size(363, 150);
            this.StdReserve_dataGridView_available_time.TabIndex = 19;
            this.StdReserve_dataGridView_available_time.Visible = false;
            // 
            // StdReserve_comboStartTime
            // 
            this.StdReserve_comboStartTime.FormattingEnabled = true;
            this.StdReserve_comboStartTime.Location = new System.Drawing.Point(166, 346);
            this.StdReserve_comboStartTime.Name = "StdReserve_comboStartTime";
            this.StdReserve_comboStartTime.Size = new System.Drawing.Size(121, 24);
            this.StdReserve_comboStartTime.TabIndex = 20;
            this.StdReserve_comboStartTime.SelectedIndexChanged += new System.EventHandler(this.comboStartTime_SelectedIndexChanged);
            // 
            // StdReserve_comboEndTime
            // 
            this.StdReserve_comboEndTime.FormattingEnabled = true;
            this.StdReserve_comboEndTime.Location = new System.Drawing.Point(166, 382);
            this.StdReserve_comboEndTime.Name = "StdReserve_comboEndTime";
            this.StdReserve_comboEndTime.Size = new System.Drawing.Size(121, 24);
            this.StdReserve_comboEndTime.TabIndex = 21;
            this.StdReserve_comboEndTime.SelectedIndexChanged += new System.EventHandler(this.comboEndTime_SelectedIndexChanged);
            // 
            // StdReserve_btn_Menu
            // 
            this.StdReserve_btn_Menu.BackColor = System.Drawing.SystemColors.Highlight;
            this.StdReserve_btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StdReserve_btn_Menu.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdReserve_btn_Menu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StdReserve_btn_Menu.Location = new System.Drawing.Point(689, 542);
            this.StdReserve_btn_Menu.Name = "StdReserve_btn_Menu";
            this.StdReserve_btn_Menu.Size = new System.Drawing.Size(164, 41);
            this.StdReserve_btn_Menu.TabIndex = 22;
            this.StdReserve_btn_Menu.Text = "Back to menu";
            this.StdReserve_btn_Menu.UseVisualStyleBackColor = false;
            this.StdReserve_btn_Menu.Click += new System.EventHandler(this.StdReserve_btn_Menu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.StdReserve_btnCheckTimes);
            this.panel1.Controls.Add(this.StdReserve_lbl_Reason);
            this.panel1.Controls.Add(this.StdReserve_room_table);
            this.panel1.Controls.Add(this.StdReserve_lbl_Date);
            this.panel1.Controls.Add(this.StdReserve_comboEndTime);
            this.panel1.Controls.Add(this.StdReserve_lbl_Room);
            this.panel1.Controls.Add(this.StdReserve_dateTimePicker);
            this.panel1.Controls.Add(this.StdReserve_RichTxtBox_Reason);
            this.panel1.Controls.Add(this.StdReserve_comboStartTime);
            this.panel1.Controls.Add(this.StdReserve_Combobox_Room);
            this.panel1.Controls.Add(this.StdReserve_dataGridView_available_time);
            this.panel1.Controls.Add(this.StdReserve_lbl_TimeStart);
            this.panel1.Controls.Add(this.StdReserve_lbl_TimeEnd);
            this.panel1.Location = new System.Drawing.Point(21, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 437);
            this.panel1.TabIndex = 23;
            // 
            // StdReserve_btnCheckTimes
            // 
            this.StdReserve_btnCheckTimes.BackColor = System.Drawing.SystemColors.Highlight;
            this.StdReserve_btnCheckTimes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StdReserve_btnCheckTimes.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdReserve_btnCheckTimes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StdReserve_btnCheckTimes.Location = new System.Drawing.Point(24, 154);
            this.StdReserve_btnCheckTimes.Name = "StdReserve_btnCheckTimes";
            this.StdReserve_btnCheckTimes.Size = new System.Drawing.Size(136, 30);
            this.StdReserve_btnCheckTimes.TabIndex = 25;
            this.StdReserve_btnCheckTimes.Text = "Check Time";
            this.StdReserve_btnCheckTimes.UseVisualStyleBackColor = false;
            this.StdReserve_btnCheckTimes.Click += new System.EventHandler(this.StdReserve_btnCheckTimes_Click);
            // 
            // StdReserve_lbl_Reason
            // 
            this.StdReserve_lbl_Reason.AutoSize = true;
            this.StdReserve_lbl_Reason.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdReserve_lbl_Reason.Location = new System.Drawing.Point(438, 241);
            this.StdReserve_lbl_Reason.Name = "StdReserve_lbl_Reason";
            this.StdReserve_lbl_Reason.Size = new System.Drawing.Size(74, 22);
            this.StdReserve_lbl_Reason.TabIndex = 24;
            this.StdReserve_lbl_Reason.Text = "Reason:";
            // 
            // StdReserve_RichTxtBox_Reason
            // 
            this.StdReserve_RichTxtBox_Reason.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdReserve_RichTxtBox_Reason.Location = new System.Drawing.Point(442, 266);
            this.StdReserve_RichTxtBox_Reason.Name = "StdReserve_RichTxtBox_Reason";
            this.StdReserve_RichTxtBox_Reason.Size = new System.Drawing.Size(306, 138);
            this.StdReserve_RichTxtBox_Reason.TabIndex = 24;
            this.StdReserve_RichTxtBox_Reason.Text = "";
            // 
            // frmStd_reserve_room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Assignment.Properties.Resources.Uwbu7x;
            this.ClientSize = new System.Drawing.Size(879, 602);
            this.Controls.Add(this.StdReserve_btn_Menu);
            this.Controls.Add(this.StdReserve_btn_Proceed);
            this.Controls.Add(this.StdReserve_lbl_Title);
            this.Controls.Add(this.panel1);
            this.Name = "frmStd_reserve_room";
            this.Text = "Reserve room";
            this.Load += new System.EventHandler(this.frmStd_reserve_room_Load);
            this.StdReserve_room_table.ResumeLayout(false);
            this.StdReserve_room_table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StdReserve_dataGridView_available_time)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StdReserve_lbl_Title;
        private System.Windows.Forms.Label StdReserve_lbl_Room;
        private System.Windows.Forms.Label StdReserve_lbl_Date;
        private System.Windows.Forms.Label StdReserve_lbl_TimeStart;
        private System.Windows.Forms.Label StdReserve_lbl_TimeEnd;
        private System.Windows.Forms.ComboBox StdReserve_Combobox_Room;
        private System.Windows.Forms.Button StdReserve_btn_Proceed;
        private System.Windows.Forms.DateTimePicker StdReserve_dateTimePicker;
        private System.Windows.Forms.TableLayoutPanel StdReserve_room_table;
        private System.Windows.Forms.Label StdReserve_lbl_Room_Name;
        private System.Windows.Forms.Label StdReserve_lbl_Room_Capacity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView StdReserve_dataGridView_available_time;
        private System.Windows.Forms.ComboBox StdReserve_comboStartTime;
        private System.Windows.Forms.ComboBox StdReserve_comboEndTime;
        private System.Windows.Forms.Button StdReserve_btn_Menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox StdReserve_RichTxtBox_Reason;
        private System.Windows.Forms.Label StdReserve_lbl_Reason;
        private System.Windows.Forms.Button StdReserve_btnCheckTimes;
    }
}