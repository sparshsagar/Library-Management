using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class lib_ApproveReject : Form
    {
        public string name;
        public lib_ApproveReject(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void lib_ApproveReject_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Booking where status = 'processing'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Lib_approve_grid.DataSource = dt;

            int count = dt.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                LibApprove_combobox_Reservation.Items.Add(dt.Rows[i][0]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibMenu f2 = new LibMenu(name);
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Libapprove_radbtn.Checked == true)
            {
                int book = int.Parse(LibApprove_combobox_Reservation.SelectedItem.ToString());
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(" UPDATE Booking SET status ='reserved' WHERE BookingID=" + book + "", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                MessageBox.Show("Booking Updated");
            }
            else if (Libreject_radbtn.Checked == true)
            {
                int book = int.Parse(LibApprove_combobox_Reservation.SelectedItem.ToString());
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(" UPDATE Booking SET status ='rejected' WHERE BookingID=" + book + "", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                MessageBox.Show("Booking Updated");
            }
            else
            {
                MessageBox.Show("No option selected");
            }
        }
    }
}
