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
    public partial class lib_DailyReport : Form
    {
        public string name;
        public lib_DailyReport(string n)
        {
            InitializeComponent();
            name = n;
        }
        private void lib_DailyReport_Load(object sender, EventArgs e)
        {
            LibDaily_lbl_Date.Text = DateTime.Now.ToLongDateString();
            string currentdate = DateTime.Now.ToString("yyyy/MM/dd");
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Booking where date ='"+ currentdate +"' AND status ='reserved'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void LibDaily_btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            LibMenu f2 = new LibMenu(name);
            f2.ShowDialog();
        }
    }
}
