using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_btn_Signin_Click(object sender, EventArgs e)
        {
            User obj1 = new User(Login_txtbox_Username.Text, Login_txtbox_Password.Text);
            obj1.login(Login_txtbox_Username.Text);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
