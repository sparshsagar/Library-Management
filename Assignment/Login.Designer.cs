
namespace Assignment
{
    partial class frmLogin
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
            this.Login_lbl_Title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Login_btn_Signin = new System.Windows.Forms.Button();
            this.Login_txtbox_Password = new System.Windows.Forms.TextBox();
            this.Login_lbl_Password = new System.Windows.Forms.Label();
            this.Login_txtbox_Username = new System.Windows.Forms.TextBox();
            this.Login_lbl_Username = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_lbl_Title
            // 
            this.Login_lbl_Title.AutoSize = true;
            this.Login_lbl_Title.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_lbl_Title.Location = new System.Drawing.Point(60, 45);
            this.Login_lbl_Title.Name = "Login_lbl_Title";
            this.Login_lbl_Title.Size = new System.Drawing.Size(515, 29);
            this.Login_lbl_Title.TabIndex = 0;
            this.Login_lbl_Title.Text = "Discussion Room Reservation System";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Login_btn_Signin);
            this.groupBox1.Controls.Add(this.Login_txtbox_Password);
            this.groupBox1.Controls.Add(this.Login_lbl_Password);
            this.groupBox1.Controls.Add(this.Login_txtbox_Username);
            this.groupBox1.Controls.Add(this.Login_lbl_Username);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(173, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 332);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign In";
            // 
            // Login_btn_Signin
            // 
            this.Login_btn_Signin.BackColor = System.Drawing.SystemColors.Highlight;
            this.Login_btn_Signin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login_btn_Signin.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn_Signin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Login_btn_Signin.Location = new System.Drawing.Point(55, 223);
            this.Login_btn_Signin.Name = "Login_btn_Signin";
            this.Login_btn_Signin.Size = new System.Drawing.Size(119, 39);
            this.Login_btn_Signin.TabIndex = 4;
            this.Login_btn_Signin.Text = "SIGN IN";
            this.Login_btn_Signin.UseVisualStyleBackColor = false;
            this.Login_btn_Signin.Click += new System.EventHandler(this.Login_btn_Signin_Click);
            // 
            // Login_txtbox_Password
            // 
            this.Login_txtbox_Password.Location = new System.Drawing.Point(55, 150);
            this.Login_txtbox_Password.Name = "Login_txtbox_Password";
            this.Login_txtbox_Password.PasswordChar = '*';
            this.Login_txtbox_Password.Size = new System.Drawing.Size(138, 30);
            this.Login_txtbox_Password.TabIndex = 1;
            // 
            // Login_lbl_Password
            // 
            this.Login_lbl_Password.AutoSize = true;
            this.Login_lbl_Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_lbl_Password.Location = new System.Drawing.Point(51, 125);
            this.Login_lbl_Password.Name = "Login_lbl_Password";
            this.Login_lbl_Password.Size = new System.Drawing.Size(88, 22);
            this.Login_lbl_Password.TabIndex = 3;
            this.Login_lbl_Password.Text = "Password";
            // 
            // Login_txtbox_Username
            // 
            this.Login_txtbox_Username.Location = new System.Drawing.Point(55, 79);
            this.Login_txtbox_Username.Name = "Login_txtbox_Username";
            this.Login_txtbox_Username.Size = new System.Drawing.Size(138, 30);
            this.Login_txtbox_Username.TabIndex = 0;
            this.Login_txtbox_Username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Login_lbl_Username
            // 
            this.Login_lbl_Username.AutoSize = true;
            this.Login_lbl_Username.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_lbl_Username.Location = new System.Drawing.Point(51, 54);
            this.Login_lbl_Username.Name = "Login_lbl_Username";
            this.Login_lbl_Username.Size = new System.Drawing.Size(88, 22);
            this.Login_lbl_Username.TabIndex = 2;
            this.Login_lbl_Username.Text = "Username";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 558);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Login_lbl_Title);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login_lbl_Title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Login_btn_Signin;
        private System.Windows.Forms.TextBox Login_txtbox_Password;
        private System.Windows.Forms.Label Login_lbl_Password;
        private System.Windows.Forms.TextBox Login_txtbox_Username;
        private System.Windows.Forms.Label Login_lbl_Username;
    }
}

