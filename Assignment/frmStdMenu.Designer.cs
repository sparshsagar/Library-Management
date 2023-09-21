
namespace Assignment
{
    partial class frmStdMenu
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
            this.StdMenu_lbl_Title = new System.Windows.Forms.Label();
            this.StdMenu_btn_Reserve = new System.Windows.Forms.Button();
            this.StdMenu_btn_CancelChange = new System.Windows.Forms.Button();
            this.StdMenu_dataGridView = new System.Windows.Forms.DataGridView();
            this.StdMenu_lbl_Current_reservation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.StdMenu_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StdMenu_lbl_Title
            // 
            this.StdMenu_lbl_Title.AutoSize = true;
            this.StdMenu_lbl_Title.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdMenu_lbl_Title.Location = new System.Drawing.Point(26, 53);
            this.StdMenu_lbl_Title.Name = "StdMenu_lbl_Title";
            this.StdMenu_lbl_Title.Size = new System.Drawing.Size(0, 29);
            this.StdMenu_lbl_Title.TabIndex = 0;
            this.StdMenu_lbl_Title.Click += new System.EventHandler(this.StdMenu_lbl_Title_Click);
            // 
            // StdMenu_btn_Reserve
            // 
            this.StdMenu_btn_Reserve.BackColor = System.Drawing.SystemColors.Highlight;
            this.StdMenu_btn_Reserve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StdMenu_btn_Reserve.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdMenu_btn_Reserve.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StdMenu_btn_Reserve.Location = new System.Drawing.Point(267, 394);
            this.StdMenu_btn_Reserve.Name = "StdMenu_btn_Reserve";
            this.StdMenu_btn_Reserve.Size = new System.Drawing.Size(203, 64);
            this.StdMenu_btn_Reserve.TabIndex = 6;
            this.StdMenu_btn_Reserve.Text = "Reserve a room ";
            this.StdMenu_btn_Reserve.UseVisualStyleBackColor = false;
            this.StdMenu_btn_Reserve.Click += new System.EventHandler(this.StdMenu_btn_Reserve_Click);
            // 
            // StdMenu_btn_CancelChange
            // 
            this.StdMenu_btn_CancelChange.BackColor = System.Drawing.SystemColors.Highlight;
            this.StdMenu_btn_CancelChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StdMenu_btn_CancelChange.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdMenu_btn_CancelChange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StdMenu_btn_CancelChange.Location = new System.Drawing.Point(267, 484);
            this.StdMenu_btn_CancelChange.Name = "StdMenu_btn_CancelChange";
            this.StdMenu_btn_CancelChange.Size = new System.Drawing.Size(203, 64);
            this.StdMenu_btn_CancelChange.TabIndex = 7;
            this.StdMenu_btn_CancelChange.Text = "Cancel/Change reservation";
            this.StdMenu_btn_CancelChange.UseVisualStyleBackColor = false;
            this.StdMenu_btn_CancelChange.Click += new System.EventHandler(this.StdMenu_btn_CancelChange_Click);
            // 
            // StdMenu_dataGridView
            // 
            this.StdMenu_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StdMenu_dataGridView.Location = new System.Drawing.Point(101, 127);
            this.StdMenu_dataGridView.Name = "StdMenu_dataGridView";
            this.StdMenu_dataGridView.RowHeadersWidth = 51;
            this.StdMenu_dataGridView.RowTemplate.Height = 24;
            this.StdMenu_dataGridView.Size = new System.Drawing.Size(542, 201);
            this.StdMenu_dataGridView.TabIndex = 8;
            // 
            // StdMenu_lbl_Current_reservation
            // 
            this.StdMenu_lbl_Current_reservation.AutoSize = true;
            this.StdMenu_lbl_Current_reservation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdMenu_lbl_Current_reservation.Location = new System.Drawing.Point(101, 104);
            this.StdMenu_lbl_Current_reservation.Name = "StdMenu_lbl_Current_reservation";
            this.StdMenu_lbl_Current_reservation.Size = new System.Drawing.Size(169, 22);
            this.StdMenu_lbl_Current_reservation.TabIndex = 9;
            this.StdMenu_lbl_Current_reservation.Text = "Current Reservation";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 330);
            this.panel1.TabIndex = 10;
            // 
            // frmStdMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment.Properties.Resources.Uwbu7x;
            this.ClientSize = new System.Drawing.Size(736, 631);
            this.Controls.Add(this.StdMenu_lbl_Current_reservation);
            this.Controls.Add(this.StdMenu_dataGridView);
            this.Controls.Add(this.StdMenu_btn_CancelChange);
            this.Controls.Add(this.StdMenu_btn_Reserve);
            this.Controls.Add(this.StdMenu_lbl_Title);
            this.Controls.Add(this.panel1);
            this.Name = "frmStdMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmStdMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StdMenu_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StdMenu_lbl_Title;
        private System.Windows.Forms.Button StdMenu_btn_Reserve;
        private System.Windows.Forms.Button StdMenu_btn_CancelChange;
        private System.Windows.Forms.DataGridView StdMenu_dataGridView;
        private System.Windows.Forms.Label StdMenu_lbl_Current_reservation;
        private System.Windows.Forms.Panel panel1;
    }
}