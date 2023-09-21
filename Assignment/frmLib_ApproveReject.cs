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
    public partial class frmLib_ApproveReject : Form
    {
        public string name;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public IDictionary<int, string> timetableDict = new Dictionary<int, string>();
        DataTable dt = new DataTable();

        public frmLib_ApproveReject(string n)
        {
            InitializeComponent();
            name = n;
            timetableDict.Add(9, "Available");
            timetableDict.Add(10, "Available");
            timetableDict.Add(11, "Available");
            timetableDict.Add(12, "Available");
            timetableDict.Add(13, "Available");
            timetableDict.Add(14, "Available");
            timetableDict.Add(15, "Available");
            timetableDict.Add(16, "Available");
            timetableDict.Add(17, "Available");
            
        }

        private void refresh()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select BookingID,studentname,room,date,timeStart,timeEnd,status from Booking where status = 'processing'", con);
            da.Fill(dt);
            LibApprove_combobox_Reservation.Items.Clear();
            LibApprove_dataGridView.DataSource = dt;
            int dtCount = dt.Rows.Count;
            for (int i = 0; i < dtCount; i++)
            {
                LibApprove_combobox_Reservation.Items.Add(dt.Rows[i][0]);
            }
            con.Close();
        }

        private void approve(string decission, string book)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(" UPDATE Booking SET status ='" + decission + "' WHERE BookingID=" + book + "", con);
            int update = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Booking Updated");
        }

        private void lib_ApproveReject_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLibMenu f2 = new frmLibMenu(name);
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string book = LibApprove_combobox_Reservation.SelectedItem.ToString();
            if (LibApprove_radbtn_Approve.Checked == true)
            {
                string decision = "reserved";
                approve(decision, book);
                dt.Clear();
                refresh();
                
            }
            else if (LibApprove_radbtn_Reject.Checked == true)
            {
                string decision = "rejected";
                approve(decision, book);
                dt.Clear();
                refresh();
            }
            else
            {
                MessageBox.Show("No option selected");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LibApprove_combobox_Reservation_SelectedIndexChanged(object sender, EventArgs e)
        {
            string book = LibApprove_combobox_Reservation.SelectedItem.ToString();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand comm = new SqlCommand("select reason from Booking where BookingID =" + book , con);
            string reason = comm.ExecuteScalar().ToString();
            LibApprove_RichTxtBox_Reason.Text = reason;

            
            //populate data grid available time
            string dateCheck = "";
            string roomCheck = "";
            for (int z=0;z<dt.Rows.Count;z++)
            {
                if (dt.Rows[z][0].ToString() == LibApprove_combobox_Reservation.SelectedItem.ToString())
                {
                    dateCheck = dt.Rows[z][3].ToString();
                    roomCheck = dt.Rows[z][2].ToString();
                }
            }

            SqlCommand cmd = new SqlCommand("select timeStart, timeEnd from Booking where date='" + dateCheck + "'" + "and room='" + roomCheck + "' and status='reserved'", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count >= 1)
            {
                SqlCommand cmd2 = new SqlCommand("select timeStart, timeEnd from Booking where date='" + dateCheck + "'" + "and room='" + roomCheck + "' and status='reserved'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                sda.Fill(dt2);

                for (int i = 0; i < count; i++)
                {
                    int timeStart = Convert.ToInt32(dt2.Rows[i][0]);
                    if (1 <= timeStart && timeStart <= 5)
                        timeStart += 12;
                    int timeEnd = Convert.ToInt32(dt2.Rows[i][1]);
                    if (1 <= timeEnd && timeEnd <= 5)
                        timeEnd += 12;
                    int duration = timeEnd - timeStart;
                    for (int j = timeStart; j < timeEnd; j++)
                    {
                        timetableDict[j] = "Reserved";
                    }
                }
            }

            DataTable availableTime = new DataTable();
            availableTime.Clear();
            availableTime.Columns.Add("Time");
            availableTime.Columns.Add("Availability");
            for (int k = 9; k <= 17; k++)
            {
                string start, end;
                if (13 <= k && k <= 17)
                {
                    start = (k - 12).ToString() + "PM";
                    end = (k - 11).ToString() + "PM";
                    availableTime.Rows.Add(new object[] { start + "-" + end, timetableDict[k] });
                }

                else
                {
                    if (k == 11)
                    {
                        start = k.ToString() + "AM";
                        end = (k + 1).ToString() + "PM";
                    }
                    else if (k == 12)
                    {
                        start = k.ToString() + "PM";
                        end = "1PM";
                    }
                    else
                    {
                        start = k.ToString() + "AM";
                        end = (k + 1).ToString() + "AM";
                    }
                    availableTime.Rows.Add(new object[] { start + "-" + end, timetableDict[k] });
                }
            }

            LibApprove_dataGridView2.DataSource = availableTime;
            LibApprove_dataGridView2.Visible = true;
            con.Close();
            
        }
    }
}
