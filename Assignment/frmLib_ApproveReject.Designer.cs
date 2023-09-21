
namespace Assignment
{
    partial class frmLib_ApproveReject
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
            this.LibDaily_lbl_Select_Reservation = new System.Windows.Forms.Label();
            this.LibApprove_combobox_Reservation = new System.Windows.Forms.ComboBox();
            this.LibApprove_radbtn_Approve = new System.Windows.Forms.RadioButton();
            this.LibApprove_radbtn_Reject = new System.Windows.Forms.RadioButton();
            this.LibApprove_btn_Confirm = new System.Windows.Forms.Button();
            this.LibApprove_btn_Back = new System.Windows.Forms.Button();
            this.LibApprove_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LibApprove_dataGridView2 = new System.Windows.Forms.DataGridView();
            this.LibDaily_lbl_Reason = new System.Windows.Forms.Label();
            this.LibApprove_RichTxtBox_Reason = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LibApprove_dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LibApprove_dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // LibDaily_lbl_Select_Reservation
            // 
            this.LibDaily_lbl_Select_Reservation.AutoSize = true;
            this.LibDaily_lbl_Select_Reservation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibDaily_lbl_Select_Reservation.Location = new System.Drawing.Point(21, 223);
            this.LibDaily_lbl_Select_Reservation.Name = "LibDaily_lbl_Select_Reservation";
            this.LibDaily_lbl_Select_Reservation.Size = new System.Drawing.Size(165, 22);
            this.LibDaily_lbl_Select_Reservation.TabIndex = 0;
            this.LibDaily_lbl_Select_Reservation.Text = "Select Reservation:";
            // 
            // LibApprove_combobox_Reservation
            // 
            this.LibApprove_combobox_Reservation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibApprove_combobox_Reservation.FormattingEnabled = true;
            this.LibApprove_combobox_Reservation.Location = new System.Drawing.Point(183, 220);
            this.LibApprove_combobox_Reservation.Name = "LibApprove_combobox_Reservation";
            this.LibApprove_combobox_Reservation.Size = new System.Drawing.Size(121, 30);
            this.LibApprove_combobox_Reservation.TabIndex = 2;
            this.LibApprove_combobox_Reservation.SelectedIndexChanged += new System.EventHandler(this.LibApprove_combobox_Reservation_SelectedIndexChanged);
            // 
            // LibApprove_radbtn_Approve
            // 
            this.LibApprove_radbtn_Approve.AutoSize = true;
            this.LibApprove_radbtn_Approve.Location = new System.Drawing.Point(25, 260);
            this.LibApprove_radbtn_Approve.Name = "LibApprove_radbtn_Approve";
            this.LibApprove_radbtn_Approve.Size = new System.Drawing.Size(82, 21);
            this.LibApprove_radbtn_Approve.TabIndex = 3;
            this.LibApprove_radbtn_Approve.TabStop = true;
            this.LibApprove_radbtn_Approve.Text = "Approve";
            this.LibApprove_radbtn_Approve.UseVisualStyleBackColor = true;
            // 
            // LibApprove_radbtn_Reject
            // 
            this.LibApprove_radbtn_Reject.AutoSize = true;
            this.LibApprove_radbtn_Reject.Location = new System.Drawing.Point(25, 299);
            this.LibApprove_radbtn_Reject.Name = "LibApprove_radbtn_Reject";
            this.LibApprove_radbtn_Reject.Size = new System.Drawing.Size(69, 21);
            this.LibApprove_radbtn_Reject.TabIndex = 3;
            this.LibApprove_radbtn_Reject.TabStop = true;
            this.LibApprove_radbtn_Reject.Text = "Reject";
            this.LibApprove_radbtn_Reject.UseVisualStyleBackColor = true;
            // 
            // LibApprove_btn_Confirm
            // 
            this.LibApprove_btn_Confirm.BackColor = System.Drawing.SystemColors.Highlight;
            this.LibApprove_btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LibApprove_btn_Confirm.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibApprove_btn_Confirm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LibApprove_btn_Confirm.Location = new System.Drawing.Point(154, 507);
            this.LibApprove_btn_Confirm.Name = "LibApprove_btn_Confirm";
            this.LibApprove_btn_Confirm.Size = new System.Drawing.Size(174, 39);
            this.LibApprove_btn_Confirm.TabIndex = 4;
            this.LibApprove_btn_Confirm.Text = "Confirm";
            this.LibApprove_btn_Confirm.UseVisualStyleBackColor = false;
            this.LibApprove_btn_Confirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // LibApprove_btn_Back
            // 
            this.LibApprove_btn_Back.BackColor = System.Drawing.SystemColors.Highlight;
            this.LibApprove_btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LibApprove_btn_Back.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibApprove_btn_Back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LibApprove_btn_Back.Location = new System.Drawing.Point(388, 507);
            this.LibApprove_btn_Back.Name = "LibApprove_btn_Back";
            this.LibApprove_btn_Back.Size = new System.Drawing.Size(174, 39);
            this.LibApprove_btn_Back.TabIndex = 4;
            this.LibApprove_btn_Back.Text = "Back to menu";
            this.LibApprove_btn_Back.UseVisualStyleBackColor = false;
            this.LibApprove_btn_Back.Click += new System.EventHandler(this.button2_Click);
            // 
            // LibApprove_dataGridView
            // 
            this.LibApprove_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LibApprove_dataGridView.Location = new System.Drawing.Point(15, 14);
            this.LibApprove_dataGridView.Name = "LibApprove_dataGridView";
            this.LibApprove_dataGridView.RowHeadersWidth = 51;
            this.LibApprove_dataGridView.RowTemplate.Height = 24;
            this.LibApprove_dataGridView.Size = new System.Drawing.Size(648, 189);
            this.LibApprove_dataGridView.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LibApprove_dataGridView2);
            this.panel1.Controls.Add(this.LibDaily_lbl_Reason);
            this.panel1.Controls.Add(this.LibApprove_dataGridView);
            this.panel1.Controls.Add(this.LibApprove_combobox_Reservation);
            this.panel1.Controls.Add(this.LibApprove_radbtn_Reject);
            this.panel1.Controls.Add(this.LibApprove_RichTxtBox_Reason);
            this.panel1.Controls.Add(this.LibApprove_radbtn_Approve);
            this.panel1.Controls.Add(this.LibDaily_lbl_Select_Reservation);
            this.panel1.Location = new System.Drawing.Point(24, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 462);
            this.panel1.TabIndex = 6;
            // 
            // LibApprove_dataGridView2
            // 
            this.LibApprove_dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LibApprove_dataGridView2.Location = new System.Drawing.Point(324, 220);
            this.LibApprove_dataGridView2.Name = "LibApprove_dataGridView2";
            this.LibApprove_dataGridView2.RowHeadersWidth = 51;
            this.LibApprove_dataGridView2.RowTemplate.Height = 24;
            this.LibApprove_dataGridView2.Size = new System.Drawing.Size(339, 212);
            this.LibApprove_dataGridView2.TabIndex = 7;
            // 
            // LibDaily_lbl_Reason
            // 
            this.LibDaily_lbl_Reason.AutoSize = true;
            this.LibDaily_lbl_Reason.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibDaily_lbl_Reason.Location = new System.Drawing.Point(21, 343);
            this.LibDaily_lbl_Reason.Name = "LibDaily_lbl_Reason";
            this.LibDaily_lbl_Reason.Size = new System.Drawing.Size(74, 22);
            this.LibDaily_lbl_Reason.TabIndex = 6;
            this.LibDaily_lbl_Reason.Text = "Reason:";
            // 
            // LibApprove_RichTxtBox_Reason
            // 
            this.LibApprove_RichTxtBox_Reason.Location = new System.Drawing.Point(25, 369);
            this.LibApprove_RichTxtBox_Reason.Name = "LibApprove_RichTxtBox_Reason";
            this.LibApprove_RichTxtBox_Reason.Size = new System.Drawing.Size(269, 63);
            this.LibApprove_RichTxtBox_Reason.TabIndex = 0;
            this.LibApprove_RichTxtBox_Reason.Text = "";
            this.LibApprove_RichTxtBox_Reason.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // frmLib_ApproveReject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment.Properties.Resources.Uwbu7x;
            this.ClientSize = new System.Drawing.Size(736, 568);
            this.Controls.Add(this.LibApprove_btn_Back);
            this.Controls.Add(this.LibApprove_btn_Confirm);
            this.Controls.Add(this.panel1);
            this.Name = "frmLib_ApproveReject";
            this.Text = "Approve/Reject Reservation";
            this.Load += new System.EventHandler(this.lib_ApproveReject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LibApprove_dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LibApprove_dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LibDaily_lbl_Select_Reservation;
        private System.Windows.Forms.ComboBox LibApprove_combobox_Reservation;
        private System.Windows.Forms.RadioButton LibApprove_radbtn_Approve;
        private System.Windows.Forms.RadioButton LibApprove_radbtn_Reject;
        private System.Windows.Forms.Button LibApprove_btn_Confirm;
        private System.Windows.Forms.Button LibApprove_btn_Back;
        private System.Windows.Forms.DataGridView LibApprove_dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox LibApprove_RichTxtBox_Reason;
        private System.Windows.Forms.Label LibDaily_lbl_Reason;
        private System.Windows.Forms.DataGridView LibApprove_dataGridView2;
    }
}