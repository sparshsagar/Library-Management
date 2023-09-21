using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    class Booking
    {
        //attributes
        private string studentname;
        private string room;
        private string date;
        private int timeStart;
        private int timeEnd;
        private string status;
        private string reason;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());


        //get set
        public string Studentname { get => studentname; set => studentname = value; }
        public string Room { get => room; set => room = value; }
        public string Date { get => date; set => date = value; }
        public int Start { get => timeStart; set => timeStart = value; }
        public int End { get => timeEnd; set => timeEnd = value; }
        public string Status { get => status; set => status = value; }
        public string Reason { get => reason; set => reason = value; }

        //constructor
        public Booking(string a, string b, string c, int d, int e, string r)
        {
            studentname = a;
            room = b;
            date = c;
            timeStart = d;
            timeEnd = e;
            status = "reserved";
            reason = r;
        }

        public Booking(string r, string d, int s, int e)
        {
            room = r;
            date = d;
            timeStart = s;
            timeEnd = e;
            status = "processing";
        }

        public void addBookingToDatabase(Booking a)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Booking (studentName, room, date, timeStart, timeEnd, status, reason)" +
                " values ('" + a.Studentname + "','" + a.Room + "','" + a.Date + "','" + a.Start.ToString() + "','" + a.End.ToString() + "','" + a.Status + "','" +a.Reason+ "')", con);
            int add = cmd.ExecuteNonQuery();
            con.Close();
        }

        public void changeBooking(Booking a, string id)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("update Booking set room ='" + a.Room + "', date ='" + a.Date + "', timeStart=" + a.Start + ", timeEnd=" + a.End + ",status='" + a.Status + "'where BookingID='" + id +"'" , con);
            int update = cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
