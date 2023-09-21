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
    public partial class frmStd_ChangeBooking : Form
    {
        public static string name;
        public static string bookingID;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public frmStd_ChangeBooking(string n, string id)
        {
            InitializeComponent();
            name = n;
            bookingID = id;
        }

        private void frmStd_ChangeBooking_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select room, date, timeStart, timeEnd from Booking where BookingID="+bookingID, con);
            SqlDataReader dr = cmd.ExecuteReader();
            

            while (dr.Read())
            {
                frmStd_ChgBook_ComboBox_Room.Text = dr.GetString(0);
                frmStd_ChgBook_dateTimePicker.Value = Convert.ToDateTime(dr.GetString(1));

                string start = dr.GetString(2);
                string end = dr.GetString(3);
                if (Convert.ToInt32(start) <= 11 && Convert.ToInt32(start) >= 9)
                    start += "AM";
                else if (Convert.ToInt32(start) == 12)
                    start += "PM";
                else
                    start += "PM";

                if (Convert.ToInt32(end) <= 11 && Convert.ToInt32(end) >= 9)
                    end += "AM";
                else if (Convert.ToInt32(end) == 12)
                    end += "PM";
                else
                    end += "PM";
                frmStd_ChgBook_ComboBox_Start.Text = start;
                frmStd_ChgBook_ComboBox_End.Text = end;
            }
            con.Close();
        }

        private void frmStd_ChgBook_ComboBox_Start_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmStd_ChgBook_ComboBox_End.Items.Clear();
            string selectedStart = frmStd_ChgBook_ComboBox_Start.SelectedItem.ToString();
            selectedStart = selectedStart.Substring(0, selectedStart.Length - 2);
            int count = Convert.ToInt32(selectedStart);
            if (count == 11)
                frmStd_ChgBook_ComboBox_End.Items.Add((count + 1).ToString() + "PM");
            else if (count == 12)
                frmStd_ChgBook_ComboBox_End.Items.Add("1PM");
            else if (count == 9 || count == 10)
                frmStd_ChgBook_ComboBox_End.Items.Add((count + 1).ToString() + "AM");
            else
                frmStd_ChgBook_ComboBox_End.Items.Add((count + 1).ToString() + "PM");

            if (count >= 1 && count <= 5)
                count += 12;

            int hourCount = 0;
            for (int i = count + 1; i <= 17; i++)
            {
                if (hourCount <= 4)
                {
                    if (i == 11)
                        frmStd_ChgBook_ComboBox_End.Items.Add((i + 1).ToString() + "PM");
                    else if (i == 12)
                        frmStd_ChgBook_ComboBox_End.Items.Add("1PM");
                    else if (i == 9 || i == 10)
                        frmStd_ChgBook_ComboBox_End.Items.Add((i + 1).ToString() + "AM");
                    else
                        frmStd_ChgBook_ComboBox_End.Items.Add((i - 12 + 1).ToString() + "PM");
                    hourCount += 1;
                }
                else
                    break;
            }
        }

        private void frmStd_ChgBook_BtnProceed_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            if (frmStd_ChgBook_dateTimePicker.Value < today.AddDays(2))
            {
                MessageBox.Show("Please make sure the date is at least 2 days after the current day.");
            }
            else
            {
                string newRoom = frmStd_ChgBook_ComboBox_Room.SelectedItem.ToString();
                string newDate = frmStd_ChgBook_dateTimePicker.Value.ToString("yyyy/MM/dd");

                string newStartStr = frmStd_ChgBook_ComboBox_Start.SelectedItem.ToString();
                newStartStr = newStartStr.Substring(0, newStartStr.Length - 2);
                int newStartInt = Convert.ToInt32(newStartStr);

                string newEndStr = frmStd_ChgBook_ComboBox_End.SelectedItem.ToString();
                newEndStr = newEndStr.Substring(0, newEndStr.Length - 2);
                int newEndInt = Convert.ToInt32(newEndStr);

                Booking change = new Booking(newRoom, newDate, newStartInt, newEndInt);
                change.changeBooking(change, bookingID);
                MessageBox.Show("Change sent for approval");
                this.Hide();
                frmStd_cancel_change menu = new frmStd_cancel_change(name);
                menu.ShowDialog();
            }
        }

        private void frmStd_ChgBook_BtnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStdMenu menu = new frmStdMenu(name);
            menu.ShowDialog();
        }
    }
}
