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
    public partial class frmLib_DailyReport : Form
    {
        public string name;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public frmLib_DailyReport(string n)
        {
            InitializeComponent();
            name = n;
        }
        private void lib_DailyReport_Load(object sender, EventArgs e)
        {
            LibDaily_lbl_Date.Text = DateTime.Now.ToLongDateString();
            string currentdate = DateTime.Now.ToString("yyyy/MM/dd");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Booking where date ='"+ currentdate +"' AND status ='reserved'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            LibDaily_dataGridView.DataSource = dt;
            con.Close();
        }

        private void LibDaily_btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLibMenu f2 = new frmLibMenu(name);
            f2.ShowDialog();
        }
    }
}
