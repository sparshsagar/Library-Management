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
    public partial class frmStd_reserve_room : Form
    {
        public static string name;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public IDictionary<int, string> timetableDict = new Dictionary<int, string>();

        public frmStd_reserve_room(string n)
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

        private void StdReserve_Combobox_Room_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmStd_reserve_room_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StdReserve_btn_Proceed_Click(object sender, EventArgs e)
        {
            if (StdReserve_Combobox_Room.SelectedItem==null | StdReserve_comboStartTime.SelectedItem==null | StdReserve_comboEndTime.SelectedItem==null | string.IsNullOrEmpty(StdReserve_RichTxtBox_Reason.Text))
            {
                MessageBox.Show("Please make sure you have selected a room, date, start time, end time, and fill in the reason.");
            }
            else
            {
                string a = name;
                string b = StdReserve_Combobox_Room.SelectedItem.ToString();
                string c = StdReserve_dateTimePicker.Value.ToString("yyyy/MM/dd");
                string d = StdReserve_comboStartTime.SelectedItem.ToString();
                d = d.Substring(0, d.Length - 2);
                string f = StdReserve_comboEndTime.SelectedItem.ToString();
                f = f.Substring(0, f.Length - 2);
                string r = StdReserve_RichTxtBox_Reason.Text;
                Booking newBooking = new Booking(a, b, c, Convert.ToInt32(d), Convert.ToInt32(f), r);
                newBooking.addBookingToDatabase(newBooking);
                MessageBox.Show("Booking successful");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void comboEndTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboStartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            StdReserve_comboEndTime.Items.Clear();
            string selectedStart = StdReserve_comboStartTime.SelectedItem.ToString();
            selectedStart = selectedStart.Substring(0,selectedStart.Length-2);
            int count = Convert.ToInt32(selectedStart);
            if (count==11)
                StdReserve_comboEndTime.Items.Add((count+1).ToString()+"PM");
            else if (count==12)
                StdReserve_comboEndTime.Items.Add("1PM");
            else if (count==9 || count==10)
                StdReserve_comboEndTime.Items.Add((count + 1).ToString() + "AM");
            else
                StdReserve_comboEndTime.Items.Add((count + 1).ToString() + "PM");

            if (count >= 1 && count <= 5)
                count += 12;

            int hourCount = 0;
            for (int i=count+1;i<=17;i++)
            {
                if ((timetableDict[i]=="Available") && (hourCount<=4))
                {
                    if (i == 11)
                        StdReserve_comboEndTime.Items.Add((i + 1).ToString() + "PM");
                    else if (i == 12)
                        StdReserve_comboEndTime.Items.Add("1PM");
                    else if (i == 9 || i == 10)
                        StdReserve_comboEndTime.Items.Add((i + 1).ToString() + "AM");
                    else
                        StdReserve_comboEndTime.Items.Add((i - 12 + 1).ToString() + "PM");
                    hourCount += 1;
                }
                else
                    break;
            }
        }

        private void StdReserve_btn_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStdMenu menu = new frmStdMenu(name);
            menu.ShowDialog();
        }


        /* btn Check time*/
        private void StdReserve_btnCheckTimes_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            StdReserve_comboStartTime.Items.Clear();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            if (StdReserve_Combobox_Room.SelectedItem == null)
            {
                MessageBox.Show("Please make sure you have selected a room.");
            }
            else if (StdReserve_dateTimePicker.Value < today.AddDays(2))
            {
                MessageBox.Show("Please make sure the date is at least 2 days after the current day.");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select count(BookingID) from Booking where date='" + StdReserve_dateTimePicker.Value.ToString("yyyy/MM/dd") + "'" + "and room='" + StdReserve_Combobox_Room.SelectedItem.ToString() + "' and status='reserved'", con);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count >= 1)
                {
                    SqlCommand cmd2 = new SqlCommand("select timeStart, timeEnd from Booking where date='" + StdReserve_dateTimePicker.Value.ToString("yyyy/MM/dd") + "'" + "and room='" + StdReserve_Combobox_Room.SelectedItem.ToString() + "' and status='reserved'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    for (int i = 0; i < count; i++)
                    {
                        int timeStart = Convert.ToInt32(dt.Rows[i][0]);
                        if (1 <= timeStart && timeStart <= 5)
                            timeStart += 12;
                        int timeEnd = Convert.ToInt32(dt.Rows[i][1]);
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

                StdReserve_dataGridView_available_time.DataSource = availableTime;
                StdReserve_dataGridView_available_time.Visible = true;
                con.Close();

                for (int l = 9; l <= 17; l++)
                {
                    if (timetableDict[l] == "Available")
                    {
                        if (l >= 13 && l <= 17)
                            StdReserve_comboStartTime.Items.Add((l - 12).ToString() + "PM");
                        else if (l == 12)
                            StdReserve_comboStartTime.Items.Add((l).ToString() + "PM");
                        else
                            StdReserve_comboStartTime.Items.Add(l.ToString() + "AM");
                    }
                }
            }
        }
    }
}
