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
    public partial class ClassManagement : Form
    {
        SqlDataReader r2;
        string connstring;
        int temp;
        List<KeyValuePair<int, string>> teachers;
        public ClassManagement()
        {
            connstring = @"Data Source=DESKTOP-J04ALPE;Initial Catalog=STUDENTS;Integrated Security=True";
            InitializeComponent();
            checkData();
            teachers = new List<KeyValuePair<int, string>>();
            SqlConnection c = new SqlConnection(connstring);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string q = "select * from Classes where ClassTeacher is null";
                SqlCommand cmd = new SqlCommand(q, c);
                SqlDataReader r;
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    classnametxt.Items.AddRange(new object[] { $"{r["ClassID"]}" });
                }
                r.Close();
                // Classes With no fee Upload Status
                q = "select ClassID from Classes where ClassID NOT IN (select ClassID from FeeManagement)";
                SqlCommand cm = new SqlCommand(q, c);
                SqlDataReader r_2;
                r_2 = cm.ExecuteReader();
                while (r_2.Read())
                {
                    classnametxt2.Items.AddRange(new object[] { $"{r_2["ClassID"]}" });
                }
                r_2.Close();


                q = "select * from TeacherInfo  Left JOIN Classes on TeacherInfo.TeacherID = Classes.ClassTeacher " +
                    "where Classes.ClassTeacher is null";
                SqlCommand cmd2 = new SqlCommand(q, c);
                r2 = cmd2.ExecuteReader();

                while (r2.Read())
                {
                    teachers.Add(new KeyValuePair<int, string>(Convert.ToInt32(r2["TeacherID"]), r2["FullName"].ToString()));
                    classteachertxt.Items.AddRange(new object[] { $"{r2["FullName"]}" });

                }



            }
            r2.Close();
            c.Close();

        }

        public void checkData()
        {

            SqlConnection c = new SqlConnection(connstring);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string q = "delete from FeeManagement where TotalStrength = TotalSubmission and TotalStrength > 0";
                SqlCommand cmd = new SqlCommand(q, c);
                cmd.ExecuteNonQuery();
            }
        }




        private void savebtn_Click(object sender, EventArgs e)
        {
            assignTeacher();
        }

        public void assignTeacher()
        {
            string teachername = classteachertxt.Text;
            foreach (var i in teachers)
            {
                if (i.Value.ToString() == teachername)
                {
                    temp = Convert.ToInt32(i.Key);
                }
            }
            SqlConnection c = new SqlConnection(connstring);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                int totalstd = executeQueryFunction(c, "select count(ID) as TotalStudents from StudentInformation where ClassEnrolled = '" + classnametxt.Text.ToString() + "'");
                string q = "update Classes set ClassTeacher='" + temp + "', TotalStudents='" + totalstd + "' where ClassID = '" + classnametxt.Text + "'";
                SqlCommand cmd = new SqlCommand(q, c);
                cmd.ExecuteNonQuery();
            }
            c.Close();
            MessageBox.Show("Teacher Assigned Successfully Successfully...", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            MainMenu.runLog("execute spSetLogs '" + LoginPanel.getuadminID() + "', '" + LoginPanel.getAdminName() + "', 'Admin', 'Update', 'Classes', '" + DateTime.Now + "', 'Teacher Assigned By UserName = " + LoginPanel.getCurrentUser() + " To ClassID = " + classnametxt.Text + ", TeacherID = " + temp + "'");
        }



        private void updatebtn_Click(object sender, EventArgs e)
        {
            assignTeacher();
        }

        private int executeQueryFunction(SqlConnection c, string q)
        {

            SqlCommand cmd = new SqlCommand(q, c);
            Int32 n = Convert.ToInt32(cmd.ExecuteScalar());
            return n;
        }

        private void uploadbtn_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(connstring);
            c.Open();
            
            if (c.State == ConnectionState.Open)
            {
                // For Counting students in Class

                int totalstd = executeQueryFunction(c, "select count(ID) as TotalStudents from StudentInformation where ClassEnrolled = '"+ classnametxt2.Text.ToString() + "'");
                int totalsub = executeQueryFunction(c, "select count(ID) as TotalSubmissions from StudentInformation where FeeStatus = 'Yes' and ClassEnrolled = '" + classnametxt2.Text.ToString() + "'");

                

                string q = "insert into FeeManagement values('"+classnametxt2.Text.ToString()+ "', " +
                    "'" +Convert.ToInt32(totalfeetxt.Text)+ "', '"+totalstd+ "', '" + totalsub + "', '" + MainMenu.SendID()+ "'," +
                    "'" + DateTime.Now + "')";

                SqlCommand cmd = new SqlCommand(q, c);
                cmd.ExecuteNonQuery();
                q = "update StudentInformation set FeeStatus = 'No' where ClassEnrolled = '" + classnametxt2.Text.ToString() + "'";
                SqlCommand cmd1 = new SqlCommand(q, c);
                cmd1.ExecuteNonQuery();
                MainMenu.runLog("execute spSetLogs '" + LoginPanel.getuadminID() + "', '" + LoginPanel.getAdminName() + "', 'Admin', 'New Record Added', 'FeeManagement', '" + DateTime.Now + "', 'Fee Uploaded By UserName = " + LoginPanel.getCurrentUser() + " To ClassID = " + classnametxt.Text + "'");
                MessageBox.Show("Fee Uploaded Successfully...", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



            }
            c.Close();
        }
    }
}
