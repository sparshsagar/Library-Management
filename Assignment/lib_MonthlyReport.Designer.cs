
namespace Assignment
{
    partial class lib_MonthlyReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LibMonth_filterbtn = new System.Windows.Forms.Button();
            this.LibMonth_dtp = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_month = new System.Windows.Forms.DataGridView();
            this.LibMonthly_lbl_Month = new System.Windows.Forms.Label();
            this.LibMonth_backbtn = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_month)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LibMonth_filterbtn);
            this.panel1.Controls.Add(this.LibMonth_dtp);
            this.panel1.Controls.Add(this.dataGridView_month);
            this.panel1.Controls.Add(this.Date);
            this.panel1.Controls.Add(this.LibMonthly_lbl_Month);
            this.panel1.Location = new System.Drawing.Point(40, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 510);
            this.panel1.TabIndex = 5;
            // 
            // LibMonth_filterbtn
            // 
            this.LibMonth_filterbtn.Location = new System.Drawing.Point(130, 120);
            this.LibMonth_filterbtn.Name = "LibMonth_filterbtn";
            this.LibMonth_filterbtn.Size = new System.Drawing.Size(116, 32);
            this.LibMonth_filterbtn.TabIndex = 6;
            this.LibMonth_filterbtn.Text = "Filter";
            this.LibMonth_filterbtn.UseVisualStyleBackColor = true;
            this.LibMonth_filterbtn.Click += new System.EventHandler(this.LibMonth_filterbtn_Click);
            // 
            // LibMonth_dtp
            // 
            this.LibMonth_dtp.Location = new System.Drawing.Point(130, 82);
            this.LibMonth_dtp.Name = "LibMonth_dtp";
            this.LibMonth_dtp.Size = new System.Drawing.Size(200, 22);
            this.LibMonth_dtp.TabIndex = 5;
            // 
            // dataGridView_month
            // 
            this.dataGridView_month.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_month.Location = new System.Drawing.Point(28, 158);
            this.dataGridView_month.Name = "dataGridView_month";
            this.dataGridView_month.RowHeadersWidth = 51;
            this.dataGridView_month.RowTemplate.Height = 24;
            this.dataGridView_month.Size = new System.Drawing.Size(672, 330);
            this.dataGridView_month.TabIndex = 4;
            // 
            // LibMonthly_lbl_Month
            // 
            this.LibMonthly_lbl_Month.AutoSize = true;
            this.LibMonthly_lbl_Month.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibMonthly_lbl_Month.Location = new System.Drawing.Point(39, 20);
            this.LibMonthly_lbl_Month.Name = "LibMonthly_lbl_Month";
            this.LibMonthly_lbl_Month.Size = new System.Drawing.Size(0, 22);
            this.LibMonthly_lbl_Month.TabIndex = 0;
            // 
            // LibMonth_backbtn
            // 
            this.LibMonth_backbtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibMonth_backbtn.Location = new System.Drawing.Point(589, 557);
            this.LibMonth_backbtn.Name = "LibMonth_backbtn";
            this.LibMonth_backbtn.Size = new System.Drawing.Size(152, 36);
            this.LibMonth_backbtn.TabIndex = 6;
            this.LibMonth_backbtn.Text = "Back to menu";
            this.LibMonth_backbtn.UseVisualStyleBackColor = true;
            this.LibMonth_backbtn.Click += new System.EventHandler(this.LibMonth_backbtn_Click);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(39, 83);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(47, 22);
            this.Date.TabIndex = 1;
            this.Date.Text = "Date";
            // 
            // lib_MonthlyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 605);
            this.Controls.Add(this.LibMonth_backbtn);
            this.Controls.Add(this.panel1);
            this.Name = "lib_MonthlyReport";
            this.Text = "Monthly Room Utilization Report";
            this.Load += new System.EventHandler(this.lib_MonthlyReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_month)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LibMonthly_lbl_Month;
        private System.Windows.Forms.Button LibMonth_backbtn;
        private System.Windows.Forms.DataGridView dataGridView_month;
        private System.Windows.Forms.DateTimePicker LibMonth_dtp;
        private System.Windows.Forms.Button LibMonth_filterbtn;
        private System.Windows.Forms.Label Date;
    }
}