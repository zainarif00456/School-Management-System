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
    public partial class AddTeacher : UserControl
    {
        public AddTeacher()
        {
            InitializeComponent();
            connstring = @"Data Source=DESKTOP-J04ALPE;Initial Catalog=STUDENTS;Integrated Security=True";
        }
        string fname, phone, cnic, gender, username, password, age, majorsubject, dateofentry;

        private void tcnictxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (tcnictxt.Text.Length > 12)
            {
                if (!(e.KeyChar == (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }
        private void tagetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (tagetxt.Text.Length > 12)
            {
                if (!(e.KeyChar == (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }

        }

        private void tagetxt_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tagetxt.Text, out int x))
            {
                if (Convert.ToInt32(tagetxt.Text.ToString()) > 80)
                {
                    MessageBox.Show("Age is Invalid", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tagetxt.Text = "";
                }
            }
        }

        private void tphonetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (tphonetxt.Text.Length > 12)
            {
                if (!(e.KeyChar == (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void tfullnametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (searchIDtxt.Text == "")
            {
                MessageBox.Show("Search Field Empty...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (tfullnametxt.Text == "" || tphonetxt.Text == "" || tcnictxt.Text == "" || tagetxt.Text=="" || usernametxt.Text == "" || password=="")
            {
                MessageBox.Show("No Data Available...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            else
            {
                SqlConnection c = new SqlConnection(connstring);
                c.Open();
                if (c.State == ConnectionState.Open)
                {
                    string query = "delete from TeacherInfo where TeacherID = @tID";

                    SqlCommand cmd = new SqlCommand(query, c);
                    cmd.Parameters.AddWithValue("@tID", searchIDtxt.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Data Deleted from the Database...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainMenu.runLog("execute spSetLogs '" + LoginPanel.getuadminID() + "', '" + LoginPanel.getAdminName() + "', 'Admin', 'Delete', 'TeacherInfo', '" + DateTime.Now + "', 'Record Deleted from TeacherInfo Table By UserName = " + LoginPanel.getCurrentUser() + "' ");
                    c.Close();
                    tfullnametxt.Text = "";
                    tphonetxt.Text = "";
                    tcnictxt.Text = "";
                    usernametxt.Text = "";
                    userpasswordtxt.Text = "";
                    tagetxt.Text = "";
                    majorsubjecttxt.Text = "";

                }
                else
                {
                    MessageBox.Show("CONNECTION ERROR!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            
            if (searchIDtxt.Text == "")
            {
                MessageBox.Show("Search Field Empty...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string id = searchIDtxt.Text;
                SqlConnection c = new SqlConnection(connstring);
                c.Open();
                if (c.State == ConnectionState.Open)
                {
                    string q = "select * from TeacherInfo where TeacherID=@TeacherID";
                    SqlCommand cmd = new SqlCommand(q, c);
                    cmd.Parameters.AddWithValue("TeacherID", id);
                    SqlDataReader r;
                    r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        tfullnametxt.Text = r["FullName"].ToString();
                        tphonetxt.Text = r["PhoneNo"].ToString();
                        tcnictxt.Text = r["CNIC"].ToString();
                        majorsubjecttxt.Text = r["MajorSubject"].ToString();
                        if(r["Gender"].ToString() == "Male")
                        {
                            malerb.Checked = true;
                        }
                        else
                        {
                            femalerb.Checked = true;
                        }
                        tagetxt.Text = r["Age"].ToString();
                        usernametxt.Text = r["UserName"].ToString();
                        userpasswordtxt.Text = r["UserPassword"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No Data Available...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
                MainMenu.runLog("execute spSetLogs '" + LoginPanel.getuadminID() + "', '" + LoginPanel.getAdminName() + "', '" + LoginPanel.getUser() + "', 'Search by ID = "+id+"', 'TeacherInfo', '" + DateTime.Now + "', 'Data Searched By UserName = " + LoginPanel.getCurrentUser() + "' ");

            }
        }

        private void updatedatabtn_Click(object sender, EventArgs e)
        {
            if (searchIDtxt.Text == "")
            {
                MessageBox.Show("Search Field Empty...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tfullnametxt.Text == "" || tphonetxt.Text == "" || tcnictxt.Text == "" || tagetxt.Text == "" || usernametxt.Text == "" || password == "")
            {
                MessageBox.Show("No Data Available...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            admitby = MainMenu.SendID();
            fname = tfullnametxt.Text;
            phone = tphonetxt.Text;
            cnic = tcnictxt.Text;
            username = usernametxt.Text;
            password = userpasswordtxt.Text;
            age = tagetxt.Text;
            majorsubject = majorsubjecttxt.Text;
            dateofentry = DateTime.Now.ToString();

            if (malerb.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            SqlConnection c = new SqlConnection(connstring);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string query = "update TeacherInfo set FullName = @fname, CNIC = @cnic, PhoneNo = @phone, " +
                    "Gender = @gender, MajorSubject = @majorsubject, Age = @age, UserName = @username, UserPassword = @password," +
                    "AdmitBy = @admitby, DateOfEntry = @dateofentry where TeacherID = @tID";

                SqlCommand cmd = new SqlCommand(query, c);
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@cnic", cnic);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@majorsubject", majorsubject);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@admitby", admitby);
                cmd.Parameters.AddWithValue("@tID", searchIDtxt.Text);
                cmd.Parameters.AddWithValue("@dateofentry", DateTime.Now.ToString());
                
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Data Saved Updated in Database...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenu.runLog("execute spSetLogs '" + LoginPanel.getuadminID() + "', '" + LoginPanel.getAdminName() + "', 'Admin', 'Update', 'TeacherInfo', '" + DateTime.Now + "', 'Record Updated in TeacherInfo By UserName = " + LoginPanel.getCurrentUser() + "' ");
                c.Close();
                tfullnametxt.Text = "";
                tphonetxt.Text = "";
                tcnictxt.Text = "";
                usernametxt.Text = "";
                userpasswordtxt.Text = "";
                tagetxt.Text = "";
                majorsubjecttxt.Text = "";

            }
            else
            {
                MessageBox.Show("CONNECTION ERROR!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        static int admitby;
        string connstring;

        private void savedatabtn_Click(object sender, EventArgs e)
        {
            if (tfullnametxt.Text == "" || tphonetxt.Text == "" || tcnictxt.Text == "" || tagetxt.Text == "" || usernametxt.Text == "" || password == "")
            {
                MessageBox.Show("Fill all fields...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            admitby = MainMenu.SendID();
            fname = tfullnametxt.Text;
            phone = tphonetxt.Text;
            cnic = tcnictxt.Text;
            username = usernametxt.Text;
            password = userpasswordtxt.Text;
            age = tagetxt.Text;
            majorsubject = majorsubjecttxt.Text;
            dateofentry = DateTime.Now.ToString();

            if (malerb.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            SqlConnection c = new SqlConnection(connstring);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string query = "insert into TeacherInfo values('" + fname + "', '" + cnic + "', '" + phone + "', " +
                    "'" + gender + "', '" + majorsubject + "', '" + age + "', '" + username + "', '" + password + "', " +
                    "'" + admitby + "', '" + dateofentry + "', 'Active')";
                SqlCommand cmd = new SqlCommand(query, c);
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Data Saved Successfully in Database..." , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainMenu.runLog("execute spSetLogs '" + LoginPanel.getuadminID() + "', '" + LoginPanel.getAdminName() + "', 'Admin', 'New Row Added', 'TeacherInfo', '" + DateTime.Now + "', 'New Record Added in TeacherInfo By UserName = " + LoginPanel.getCurrentUser() + "' ");
                c.Close();
                tfullnametxt.Text = "";
                tphonetxt.Text = "";
                tcnictxt.Text = "";
                usernametxt.Text = "";
                userpasswordtxt.Text = "";
                tagetxt.Text = "";
                majorsubjecttxt.Text = "";

            }
            else
            {
                MessageBox.Show("CONNECTION ERROR!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
