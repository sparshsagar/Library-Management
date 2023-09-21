
namespace Assignment
{
    partial class lib_ApproveReject
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
            this.label1 = new System.Windows.Forms.Label();
            this.LibApprove_combobox_Reservation = new System.Windows.Forms.ComboBox();
            this.Libapprove_radbtn = new System.Windows.Forms.RadioButton();
            this.Libreject_radbtn = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Lib_approve_grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Lib_approve_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Reservation";
            // 
            // LibApprove_combobox_Reservation
            // 
            this.LibApprove_combobox_Reservation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibApprove_combobox_Reservation.FormattingEnabled = true;
            this.LibApprove_combobox_Reservation.Location = new System.Drawing.Point(263, 218);
            this.LibApprove_combobox_Reservation.Name = "LibApprove_combobox_Reservation";
            this.LibApprove_combobox_Reservation.Size = new System.Drawing.Size(121, 30);
            this.LibApprove_combobox_Reservation.TabIndex = 2;
            // 
            // Libapprove_radbtn
            // 
            this.Libapprove_radbtn.AutoSize = true;
            this.Libapprove_radbtn.Location = new System.Drawing.Point(90, 271);
            this.Libapprove_radbtn.Name = "Libapprove_radbtn";
            this.Libapprove_radbtn.Size = new System.Drawing.Size(82, 21);
            this.Libapprove_radbtn.TabIndex = 3;
            this.Libapprove_radbtn.TabStop = true;
            this.Libapprove_radbtn.Text = "Approve";
            this.Libapprove_radbtn.UseVisualStyleBackColor = true;
            // 
            // Libreject_radbtn
            // 
            this.Libreject_radbtn.AutoSize = true;
            this.Libreject_radbtn.Location = new System.Drawing.Point(90, 319);
            this.Libreject_radbtn.Name = "Libreject_radbtn";
            this.Libreject_radbtn.Size = new System.Drawing.Size(69, 21);
            this.Libreject_radbtn.TabIndex = 3;
            this.Libreject_radbtn.TabStop = true;
            this.Libreject_radbtn.Text = "Reject";
            this.Libreject_radbtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(157, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(374, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Back to menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lib_approve_grid
            // 
            this.Lib_approve_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lib_approve_grid.Location = new System.Drawing.Point(90, 12);
            this.Lib_approve_grid.Name = "Lib_approve_grid";
            this.Lib_approve_grid.RowHeadersWidth = 51;
            this.Lib_approve_grid.RowTemplate.Height = 24;
            this.Lib_approve_grid.Size = new System.Drawing.Size(505, 189);
            this.Lib_approve_grid.TabIndex = 5;
            // 
            // lib_ApproveReject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 465);
            this.Controls.Add(this.Lib_approve_grid);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Libreject_radbtn);
            this.Controls.Add(this.Libapprove_radbtn);
            this.Controls.Add(this.LibApprove_combobox_Reservation);
            this.Controls.Add(this.label1);
            this.Name = "lib_ApproveReject";
            this.Text = "Approve/Reject Reservation";
            this.Load += new System.EventHandler(this.lib_ApproveReject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Lib_approve_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox LibApprove_combobox_Reservation;
        private System.Windows.Forms.RadioButton Libapprove_radbtn;
        private System.Windows.Forms.RadioButton Libreject_radbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView Lib_approve_grid;
    }
}