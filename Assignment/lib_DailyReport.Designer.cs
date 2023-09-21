
namespace Assignment
{
    partial class lib_DailyReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.LibDaily_btn_Back.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibDaily_btn_Back.Location = new System.Drawing.Point(447, 542);
            this.LibDaily_btn_Back.Name = "LibDaily_btn_Back";
            this.LibDaily_btn_Back.Size = new System.Drawing.Size(162, 30);
            this.LibDaily_btn_Back.TabIndex = 2;
            this.LibDaily_btn_Back.Text = "Back to menu";
            this.LibDaily_btn_Back.UseVisualStyleBackColor = true;
            this.LibDaily_btn_Back.Click += new System.EventHandler(this.LibDaily_btn_Back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.LibDaily_lbl_Date);
            this.panel1.Location = new System.Drawing.Point(39, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 469);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(521, 378);
            this.dataGridView1.TabIndex = 1;
            // 
            // lib_DailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 621);
            this.Controls.Add(this.LibDaily_btn_Back);
            this.Controls.Add(this.panel1);
            this.Name = "lib_DailyReport";
            this.Text = "Daily Reservation Report";
            this.Load += new System.EventHandler(this.lib_DailyReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LibDaily_lbl_Date;
        private System.Windows.Forms.Button LibDaily_btn_Back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}