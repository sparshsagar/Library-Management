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
    public partial class LibMenu : Form
    {
        public static string name;
        public LibMenu(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void LibMenu_lbl_Title_Click(object sender, EventArgs e)
        {

        }

        private void LibMenu_Load(object sender, EventArgs e)
        {
            LibMenu_lbl_Title.Text = "Welcome to librarian menu page, " + name;
        }

        private void LibMenu_btn_Approve_Click(object sender, EventArgs e)
        {
            this.Hide();
            lib_ApproveReject lib_AR = new lib_ApproveReject(name);
            lib_AR.ShowDialog();
        }

        private void LibMenu_btn_DailyReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            lib_DailyReport lib_Daily_Report = new lib_DailyReport(name);
            lib_Daily_Report.ShowDialog();
        }

        private void LibMenu_btn_MonthlyReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            lib_MonthlyReport lib_Monthly_Report = new lib_MonthlyReport(name);
            lib_Monthly_Report.ShowDialog();
        }
    }
}
