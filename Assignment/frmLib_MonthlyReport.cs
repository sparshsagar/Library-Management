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
    public partial class frmLib_MonthlyReport : Form
    {
        public string name;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        DataTable dt = new DataTable();

        public frmLib_MonthlyReport(string n)
        {
            InitializeComponent();
            name = n;
        }
        private void refresh(string chosen_date)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Booking where date LIKE '%" + chosen_date + "%' AND status ='reserved'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            LibMonthly_dataGridView.DataSource = dt;
            con.Close();
        }
        private void lib_MonthlyReport_Load(object sender, EventArgs e)
        {
            LibMonthly_lbl_Month.Text = DateTime.Now.ToString("MMM/yyyy");
            string currentmonth = DateTime.Now.ToString("yyyy/MM");
            refresh(currentmonth);
        }

        private void LibMonth_backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLibMenu f2 = new frmLibMenu(name);
            f2.ShowDialog();
        }

        private void LibMonth_filterbtn_Click(object sender, EventArgs e)
        {
            refresh(LibMonthly_dtp.Value.ToString("yyyy/MM/dd"));
        }
    }
}
