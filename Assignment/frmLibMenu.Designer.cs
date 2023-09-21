
namespace Assignment
{
    partial class frmLibMenu
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
            this.LibMenu_lbl_Title = new System.Windows.Forms.Label();
            this.LibMenu_btn_Approve = new System.Windows.Forms.Button();
            this.LibMenu_btn_DailyReport = new System.Windows.Forms.Button();
            this.LibMenu_btn_MonthlyReport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LibMenu_lbl_Title
            // 
            this.LibMenu_lbl_Title.AutoSize = true;
            this.LibMenu_lbl_Title.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibMenu_lbl_Title.Location = new System.Drawing.Point(108, 52);
            this.LibMenu_lbl_Title.Name = "LibMenu_lbl_Title";
            this.LibMenu_lbl_Title.Size = new System.Drawing.Size(0, 29);
            this.LibMenu_lbl_Title.TabIndex = 0;
            this.LibMenu_lbl_Title.Click += new System.EventHandler(this.LibMenu_lbl_Title_Click);
            // 
            // LibMenu_btn_Approve
            // 
            this.LibMenu_btn_Approve.BackColor = System.Drawing.SystemColors.Highlight;
            this.LibMenu_btn_Approve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LibMenu_btn_Approve.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibMenu_btn_Approve.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LibMenu_btn_Approve.Location = new System.Drawing.Point(266, 101);
            this.LibMenu_btn_Approve.Name = "LibMenu_btn_Approve";
            this.LibMenu_btn_Approve.Size = new System.Drawing.Size(235, 79);
            this.LibMenu_btn_Approve.TabIndex = 1;
            this.LibMenu_btn_Approve.Text = "Approve/Reject Reservation";
            this.LibMenu_btn_Approve.UseVisualStyleBackColor = false;
            this.LibMenu_btn_Approve.Click += new System.EventHandler(this.LibMenu_btn_Approve_Click);
            // 
            // LibMenu_btn_DailyReport
            // 
            this.LibMenu_btn_DailyReport.BackColor = System.Drawing.SystemColors.Highlight;
            this.LibMenu_btn_DailyReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LibMenu_btn_DailyReport.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibMenu_btn_DailyReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LibMenu_btn_DailyReport.Location = new System.Drawing.Point(266, 209);
            this.LibMenu_btn_DailyReport.Name = "LibMenu_btn_DailyReport";
            this.LibMenu_btn_DailyReport.Size = new System.Drawing.Size(235, 79);
            this.LibMenu_btn_DailyReport.TabIndex = 2;
            this.LibMenu_btn_DailyReport.Text = "Daily Reservation Report";
            this.LibMenu_btn_DailyReport.UseVisualStyleBackColor = false;
            this.LibMenu_btn_DailyReport.Click += new System.EventHandler(this.LibMenu_btn_DailyReport_Click);
            // 
            // LibMenu_btn_MonthlyReport
            // 
            this.LibMenu_btn_MonthlyReport.BackColor = System.Drawing.SystemColors.Highlight;
            this.LibMenu_btn_MonthlyReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LibMenu_btn_MonthlyReport.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibMenu_btn_MonthlyReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LibMenu_btn_MonthlyReport.Location = new System.Drawing.Point(266, 322);
            this.LibMenu_btn_MonthlyReport.Name = "LibMenu_btn_MonthlyReport";
            this.LibMenu_btn_MonthlyReport.Size = new System.Drawing.Size(235, 79);
            this.LibMenu_btn_MonthlyReport.TabIndex = 3;
            this.LibMenu_btn_MonthlyReport.Text = "Monthly Room Utilization Report";
            this.LibMenu_btn_MonthlyReport.UseVisualStyleBackColor = false;
            this.LibMenu_btn_MonthlyReport.Click += new System.EventHandler(this.LibMenu_btn_MonthlyReport_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(54, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 415);
            this.panel1.TabIndex = 4;
            // 
            // frmLibMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment.Properties.Resources.Uwbu7x;
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.Controls.Add(this.LibMenu_btn_MonthlyReport);
            this.Controls.Add(this.LibMenu_btn_DailyReport);
            this.Controls.Add(this.LibMenu_btn_Approve);
            this.Controls.Add(this.LibMenu_lbl_Title);
            this.Controls.Add(this.panel1);
            this.Name = "frmLibMenu";
            this.Text = "LibMenu";
            this.Load += new System.EventHandler(this.LibMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LibMenu_lbl_Title;
        private System.Windows.Forms.Button LibMenu_btn_Approve;
        private System.Windows.Forms.Button LibMenu_btn_DailyReport;
        private System.Windows.Forms.Button LibMenu_btn_MonthlyReport;
        private System.Windows.Forms.Panel panel1;
    }
}