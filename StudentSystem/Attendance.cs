using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentSystem
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
            showStudents();
        }


        private void showStudents()
        {
            string connectionstr = @"Data Source=DESKTOP-J04ALPE;Initial Catalog=STUDENTS;Integrated Security=True";
            SqlConnection c = new SqlConnection(connectionstr);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string query = "select * from StudentInformation where ClassEnrolled = '" + LoginPanel.getClassAssigned() + "'";
                
                SqlCommand cmd = new SqlCommand(query, c);
                SqlDataReader r;
                r = cmd.ExecuteReader();
                showattendanceview.Rows.Clear();
                while (r.Read())
                {
                    showattendanceview.Rows.Add(r["ID"], r["Name"],  r["ClassEnrolled"], "PRESENT");
                }
                r.Close();
                c.Close();
            }

        }

        private void showattendanceview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (showattendanceview.Columns[e.ColumnIndex].Name == "markbtn")
            {

                if (showattendanceview.Rows[e.RowIndex].Cells["markbtn"].Value == "ABSENT")
                {
                    showattendanceview.Rows[e.RowIndex].Cells["markbtn"].Value = "PRESENT";
                }
                else
                {
                    showattendanceview.Rows[e.RowIndex].Cells["markbtn"].Value = "ABSENT";
                }
            }
        }

        private void saveAttendance(int id, string classname, string status)
        {
            string connectionstr = @"Data Source=DESKTOP-J04ALPE;Initial Catalog=STUDENTS;Integrated Security=True";
            SqlConnection c = new SqlConnection(connectionstr);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string query = "insert into Attendance values('" + id + "', " +
                    "'" + classname+ "'," +
                    "'"+status+"', '" + DateTime.Now + "', '" + LoginPanel.getuadminID() + "')";
                SqlCommand cmd = new SqlCommand(query, c);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    // UNKNOWN EXCEPTION FROM DATABASE. StudentInformation Table Conflict
                }
            }
            c.Close();
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < Convert.ToInt32(showattendanceview.Rows.Count.ToString()); i++)
            {
                int id = Convert.ToInt32(showattendanceview.Rows[i].Cells["sid"].Value);
                string classname = Convert.ToString(showattendanceview.Rows[i].Cells["sclass"].Value);
                string status = Convert.ToString(showattendanceview.Rows[i].Cells["markbtn"].Value);
                saveAttendance(id, classname, status);
            }
            MainMenu.runLog("execute spSetLogs '" + LoginPanel.getuadminID() + "', '" + LoginPanel.getAdminName() + "', '" + LoginPanel.getUser() + "', 'New Record Added', 'Attendance', '" + DateTime.Now + "', 'Attendance Marked By UserName = " + LoginPanel.getCurrentUser() + "'");

            MessageBox.Show("Attendance Saved Successfully...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void updateAttendance(int id, string classname, string status)
        {
            string connectionstr = @"Data Source=DESKTOP-J04ALPE;Initial Catalog=STUDENTS;Integrated Security=True";
            SqlConnection c = new SqlConnection(connectionstr);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string query = "Update Attendance set AttendanceStatus = '"+status+"' where StudentID = '"+id+"' and " +
                    "DateOfAttendance= '"+DateTime.Now+"'";
                SqlCommand cmd = new SqlCommand(query, c);
                cmd.ExecuteNonQuery();
                
            }
            c.Close();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(showattendanceview.Rows.Count.ToString()); i++)
            {
                int id = Convert.ToInt32(showattendanceview.Rows[i].Cells["sid"].Value);
                string classname = Convert.ToString(showattendanceview.Rows[i].Cells["sclass"].Value);
                string status = Convert.ToString(showattendanceview.Rows[i].Cells["markbtn"].Value);
                updateAttendance(id, classname, status);
            }
            MainMenu.runLog("execute spSetLogs '" + LoginPanel.getuadminID() + "', '" + LoginPanel.getAdminName() + "', '" + LoginPanel.getUser() + "', 'Update', 'Attendance', '" + DateTime.Now + "', 'Attendance Updated By UserName = " + LoginPanel.getCurrentUser() + "'");
            MessageBox.Show("Attendance Updated Successfully...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        public void showPrevAttendance(string d)
        {
            string connectionstr = @"Data Source=DESKTOP-J04ALPE;Initial Catalog=STUDENTS;Integrated Security=True";
            SqlConnection c = new SqlConnection(connectionstr);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string query = "select StudentInformation.ID, StudentInformation.Name, StudentInformation.ClassEnrolled," +
                    "Attendance.AttendanceStatus from StudentInformation INNER JOIN Attendance " +
                    "on StudentInformation.ID = Attendance.StudentID where ClassID = '"+LoginPanel.getClassAssigned()+"' and " +
                    "DateOfAttendance='"+d+"'";

                SqlCommand cmd = new SqlCommand(query, c);
                SqlDataReader r;
                r = cmd.ExecuteReader();
                showattendanceview.Rows.Clear();
                while (r.Read())
                {
                    showattendanceview.Rows.Add(r["ID"], r["Name"], r["ClassEnrolled"], r["AttendanceStatus"]);
                }
                r.Close();
                c.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string prevdate = prevdatetxt.Value.ToString();
            showPrevAttendance(prevdate);
            MainMenu.runLog("execute spSetLogs '" + LoginPanel.getuadminID() + "', '" + LoginPanel.getAdminName() + "', '" + LoginPanel.getUser() + "', 'Previous Record Accessed', 'Attendance', '" + DateTime.Now + "', 'Previous Attendance of Date = "+prevdatetxt.Value.ToString()+" By UserName = " + LoginPanel.getCurrentUser() + "'");

        }
    }
}
