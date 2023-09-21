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
    public partial class lib_MonthlyReport : Form
    {
        public string name;
        public lib_MonthlyReport(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void lib_MonthlyReport_Load(object sender, EventArgs e)
        {
            LibMonthly_lbl_Month.Text = DateTime.Now.ToString("MMM/yyyy");
            string currentmonth = DateTime.Now.ToString("yyyy/MM");

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Booking where date LIKE '%" + currentmonth + "%' AND status ='reserved'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView_month.DataSource = dt;
        }

        private void LibMonth_backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibMenu f2 = new LibMenu(name);
            f2.ShowDialog();

        }

        private void LibMonth_filterbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlDataAdapter dm = new SqlDataAdapter("select * from Booking where date ='" + LibMonth_dtp.Value.ToString("yyyy/MM/dd") + "' AND status ='reserved'", con);
            DataTable dw = new DataTable();
            dm.Fill(dw);
            dataGridView_month.DataSource = dw;
        }
    }
}
