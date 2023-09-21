
namespace Assignment
{
    partial class frmLib_MonthlyReport
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
            this.LibMonthly_Panel = new System.Windows.Forms.Panel();
            this.LibMonthly_btn_filter = new System.Windows.Forms.Button();
            this.LibMonthly_dtp = new System.Windows.Forms.DateTimePicker();
            this.LibMonthly_dataGridView = new System.Windows.Forms.DataGridView();
            this.LibMonthly_lbl_Date = new System.Windows.Forms.Label();
            this.LibMonthly_lbl_Month = new System.Windows.Forms.Label();
            this.LibMonthly_btn_back = new System.Windows.Forms.Button();
            this.LibMonthly_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LibMonthly_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LibMonthly_Panel
            // 
            this.LibMonthly_Panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LibMonthly_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LibMonthly_Panel.Controls.Add(this.LibMonthly_btn_filter);
            this.LibMonthly_Panel.Controls.Add(this.LibMonthly_dtp);
            this.LibMonthly_Panel.Controls.Add(this.LibMonthly_dataGridView);
            this.LibMonthly_Panel.Controls.Add(this.LibMonthly_lbl_Date);
            this.LibMonthly_Panel.Controls.Add(this.LibMonthly_lbl_Month);
            this.LibMonthly_Panel.Location = new System.Drawing.Point(40, 29);
            this.LibMonthly_Panel.Name = "LibMonthly_Panel";
            this.LibMonthly_Panel.Size = new System.Drawing.Size(719, 510);
            this.LibMonthly_Panel.TabIndex = 5;
            // 
            // LibMonthly_btn_filter
            // 
            this.LibMonthly_btn_filter.BackColor = System.Drawing.SystemColors.Highlight;
            this.LibMonthly_btn_filter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LibMonthly_btn_filter.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibMonthly_btn_filter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LibMonthly_btn_filter.Location = new System.Drawing.Point(130, 120);
            this.LibMonthly_btn_filter.Name = "LibMonthly_btn_filter";
            this.LibMonthly_btn_filter.Size = new System.Drawing.Size(116, 32);
            this.LibMonthly_btn_filter.TabIndex = 6;
            this.LibMonthly_btn_filter.Text = "Filter";
            this.LibMonthly_btn_filter.UseVisualStyleBackColor = false;
            this.LibMonthly_btn_filter.Click += new System.EventHandler(this.LibMonth_filterbtn_Click);
            // 
            // LibMonthly_dtp
            // 
            this.LibMonthly_dtp.Location = new System.Drawing.Point(130, 82);
            this.LibMonthly_dtp.Name = "LibMonthly_dtp";
            this.LibMonthly_dtp.Size = new System.Drawing.Size(200, 22);
            this.LibMonthly_dtp.TabIndex = 5;
            // 
            // LibMonthly_dataGridView
            // 
            this.LibMonthly_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LibMonthly_dataGridView.Location = new System.Drawing.Point(28, 158);
            this.LibMonthly_dataGridView.Name = "LibMonthly_dataGridView";
            this.LibMonthly_dataGridView.RowHeadersWidth = 51;
            this.LibMonthly_dataGridView.RowTemplate.Height = 24;
            this.LibMonthly_dataGridView.Size = new System.Drawing.Size(672, 330);
            this.LibMonthly_dataGridView.TabIndex = 4;
            // 
            // LibMonthly_lbl_Date
            // 
            this.LibMonthly_lbl_Date.AutoSize = true;
            this.LibMonthly_lbl_Date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibMonthly_lbl_Date.Location = new System.Drawing.Point(39, 83);
            this.LibMonthly_lbl_Date.Name = "LibMonthly_lbl_Date";
            this.LibMonthly_lbl_Date.Size = new System.Drawing.Size(47, 22);
            this.LibMonthly_lbl_Date.TabIndex = 1;
            this.LibMonthly_lbl_Date.Text = "Date";
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
            // LibMonthly_btn_back
            // 
            this.LibMonthly_btn_back.BackColor = System.Drawing.SystemColors.Highlight;
            this.LibMonthly_btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LibMonthly_btn_back.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibMonthly_btn_back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LibMonthly_btn_back.Location = new System.Drawing.Point(589, 557);
            this.LibMonthly_btn_back.Name = "LibMonthly_btn_back";
            this.LibMonthly_btn_back.Size = new System.Drawing.Size(170, 36);
            this.LibMonthly_btn_back.TabIndex = 6;
            this.LibMonthly_btn_back.Text = "Back to menu";
            this.LibMonthly_btn_back.UseVisualStyleBackColor = false;
            this.LibMonthly_btn_back.Click += new System.EventHandler(this.LibMonth_backbtn_Click);
            // 
            // frmLib_MonthlyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment.Properties.Resources.Uwbu7x;
            this.ClientSize = new System.Drawing.Size(805, 605);
            this.Controls.Add(this.LibMonthly_btn_back);
            this.Controls.Add(this.LibMonthly_Panel);
            this.Name = "frmLib_MonthlyReport";
            this.Text = "Monthly Room Utilization Report";
            this.Load += new System.EventHandler(this.lib_MonthlyReport_Load);
            this.LibMonthly_Panel.ResumeLayout(false);
            this.LibMonthly_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LibMonthly_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LibMonthly_Panel;
        private System.Windows.Forms.Label LibMonthly_lbl_Month;
        private System.Windows.Forms.Button LibMonthly_btn_back;
        private System.Windows.Forms.DataGridView LibMonthly_dataGridView;
        private System.Windows.Forms.DateTimePicker LibMonthly_dtp;
        private System.Windows.Forms.Button LibMonthly_btn_filter;
        private System.Windows.Forms.Label LibMonthly_lbl_Date;
    }
}