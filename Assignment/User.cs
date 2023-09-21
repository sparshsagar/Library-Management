using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    class User
    {
        private string username;
        private string password;
        private string role;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }

        public User(string un, string pass)
        {
            username = un;
            password = pass;
        }

        public void login(string un)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from Users where username='" + username + "' and password='" + password + "'", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());


            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("Select role from users where Username = '" + username + "'", con);
                string userRole = cmd2.ExecuteScalar().ToString();
                if (userRole == "librarian")
                {
                    frmLibMenu a = new frmLibMenu(un);
                    a.ShowDialog();
                }
                else if (userRole == "student")
                {
                    frmStdMenu s = new frmStdMenu(un);
                    s.ShowDialog();
                }
            }
            else
                MessageBox.Show("Incorrect username/password");
            con.Close();
        }
    }
}
