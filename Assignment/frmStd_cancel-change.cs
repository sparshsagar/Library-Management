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
    public partial class frmStd_cancel_change : Form
    {
        public static string name;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        DataTable dt = new DataTable();

        public frmStd_cancel_change(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void frmStd_cancel_change_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Booking where studentname='" + name + "'", con);
            da.Fill(dt);
            StdCancelChange_CancelChange_dataGridView.DataSource = dt;
            int count = dt.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                StdCancelChange_listbox_Reservation.Items.Add(dt.Rows[i][0]);
            }
            con.Close();
        }

        private void deleteBooking(string bookingNum)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Booking where BookingID=" + bookingNum, con);
            int delete = cmd.ExecuteNonQuery();
            con.Close();
        }

        private void StdCancelChange_btn_Proceed_Click(object sender, EventArgs e)
        {
            if ( StdCancelChange_listbox_Reservation.SelectedItem==null | (StdCancelChange_radbtn_Cancel.Checked==false && StdCancelChange_radbtn_Change.Checked==false))
            {
                MessageBox.Show("Please select a reservation, and then choose 'Cancel' or 'Change reservation'");
            }
            else
            {
                if (StdCancelChange_radbtn_Cancel.Checked==true)
                {
                    deleteBooking(StdCancelChange_listbox_Reservation.SelectedItem.ToString());
                    MessageBox.Show("Booking cancelled");
                    dt.Clear();
                    refresh();
                }
                else if (StdCancelChange_radbtn_Change.Checked==true)
                {
                    this.Hide();
                    frmStd_ChangeBooking std_ChangeBooking = new frmStd_ChangeBooking(name, StdCancelChange_listbox_Reservation.SelectedItem.ToString());
                    std_ChangeBooking.ShowDialog();
                }
            }
        }

        private void StdCancelChange_btn_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStdMenu menu = new frmStdMenu(name);
            menu.ShowDialog();
        }
    }
}
