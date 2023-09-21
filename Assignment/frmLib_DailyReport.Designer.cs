
namespace Assignment
{
    partial class frmLib_DailyReport
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
            this.LibDaily_lbl_Date = new System.Windows.Forms.Label();
            this.LibDaily_btn_Back = new System.Windows.Forms.Button();
            this.LibDaily_panel = new System.Windows.Forms.Panel();
            this.LibDaily_dataGridView = new System.Windows.Forms.DataGridView();
            this.LibDaily_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LibDaily_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LibDaily_lbl_Date
            // 
            this.LibDaily_lbl_Date.AutoSize = true;
            this.LibDaily_lbl_Date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibDaily_lbl_Date.Location = new System.Drawing.Point(20, 15);
            this.LibDaily_lbl_Date.Name = "LibDaily_lbl_Date";
            this.LibDaily_lbl_Date.Size = new System.Drawing.Size(0, 22);
            this.LibDaily_lbl_Date.TabIndex = 0;
            // 
            // LibDaily_btn_Back
            // 
            this.LibDaily_btn_Back.BackColor = System.Drawing.SystemColors.Highlight;
            this.LibDaily_btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LibDaily_btn_Back.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibDaily_btn_Back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LibDaily_btn_Back.Location = new System.Drawing.Point(447, 542);
            this.LibDaily_btn_Back.Name = "LibDaily_btn_Back";
            this.LibDaily_btn_Back.Size = new System.Drawing.Size(162, 34);
            this.LibDaily_btn_Back.TabIndex = 2;
            this.LibDaily_btn_Back.Text = "Back to menu";
            this.LibDaily_btn_Back.UseVisualStyleBackColor = false;
            this.LibDaily_btn_Back.Click += new System.EventHandler(this.LibDaily_btn_Back_Click);
            // 
            // LibDaily_panel
            // 
            this.LibDaily_panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LibDaily_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LibDaily_panel.Controls.Add(this.LibDaily_dataGridView);
            this.LibDaily_panel.Controls.Add(this.LibDaily_lbl_Date);
            this.LibDaily_panel.Location = new System.Drawing.Point(39, 48);
            this.LibDaily_panel.Name = "LibDaily_panel";
            this.LibDaily_panel.Size = new System.Drawing.Size(570, 469);
            this.LibDaily_panel.TabIndex = 4;
            // 
            // LibDaily_dataGridView
            // 
            this.LibDaily_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LibDaily_dataGridView.Location = new System.Drawing.Point(24, 65);
            this.LibDaily_dataGridView.Name = "LibDaily_dataGridView";
            this.LibDaily_dataGridView.RowHeadersWidth = 51;
            this.LibDaily_dataGridView.RowTemplate.Height = 24;
            this.LibDaily_dataGridView.Size = new System.Drawing.Size(521, 378);
            this.LibDaily_dataGridView.TabIndex = 1;
            // 
            // frmLib_DailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment.Properties.Resources.Uwbu7x;
            this.ClientSize = new System.Drawing.Size(650, 602);
            this.Controls.Add(this.LibDaily_btn_Back);
            this.Controls.Add(this.LibDaily_panel);
            this.Name = "frmLib_DailyReport";
            this.Text = "Daily Reservation Report";
            this.Load += new System.EventHandler(this.lib_DailyReport_Load);
            this.LibDaily_panel.ResumeLayout(false);
            this.LibDaily_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LibDaily_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LibDaily_lbl_Date;
        private System.Windows.Forms.Button LibDaily_btn_Back;
        private System.Windows.Forms.Panel LibDaily_panel;
        private System.Windows.Forms.DataGridView LibDaily_dataGridView;
    }
}