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
    public partial class frmStdMenu : Form
    {
        public static string name;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public frmStdMenu(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void StdMenu_lbl_Title_Click(object sender, EventArgs e)
        {

        }

        private void frmStdMenu_Load(object sender, EventArgs e)
        {
            StdMenu_lbl_Title.Text = "Welcome to student reservation system, " + name;

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select room,date,timeStart,timeEnd,status from Booking where studentname='" + name + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            StdMenu_dataGridView.DataSource = dt;
            con.Close();
        }

        private void StdMenu_btn_Reserve_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStd_reserve_room std_ReserveRoom = new frmStd_reserve_room(name);
            std_ReserveRoom.ShowDialog();
        }

        private void StdMenu_btn_CancelChange_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStd_cancel_change std_CancelChange = new frmStd_cancel_change(name);
            std_CancelChange.ShowDialog();
        }
    }
}
