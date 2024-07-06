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
using System.IO;

namespace StudentSystem
{
    public partial class LoginPanel : Form
    {
        static string user, gender, adminname, assigned_class, currentuser;
        public LoginPanel()
        {
            user = "admin";
            InitializeComponent();
            connstring= @"Data Source=DESKTOP-J04ALPE;Initial Catalog=STUDENTS;Integrated Security=True";
            try
            {
                FileInfo f = new FileInfo("savefile.dat");
                if (f.Exists)
                {
                    FileStream file = new FileStream("savefile.dat", FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(file);
                    usertxt.Text = reader.ReadLine().ToString();
                    passwordtxt.Text = reader.ReadLine().ToString();
                    file.Close();
                }
            }
            catch (Exception)
            {
                //Pass
            }
        }
        string username, userpassword, connstring;
        public static int adminid;

        public static int getuadminID()
        {
            return adminid;
        }

        public static string getCurrentUser()
        {
            return currentuser;
        }

        public static string getClassAssigned()
        {
            return assigned_class;
        }
        private void checkClassAssigned(int id)
        {
            //  Function to get ClassID from database for future use.

            SqlConnection c = new SqlConnection(connstring);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string q = "select ClassID from Classes where ClassTeacher=@classteacher";
                SqlCommand cmd = new SqlCommand(q, c);
                cmd.Parameters.AddWithValue("classteacher", id);
                SqlDataReader r;
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    assigned_class = r["ClassID"].ToString();
                }
                r.Close();
                c.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            user = "teacher";
            username = usertxt.Text;
            userpassword = passwordtxt.Text;
            SqlConnection c = new SqlConnection(connstring);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string q = "select * from TeacherInfo where UserName=@UserName and UserPassword=@UserPassword";
                SqlCommand cmd = new SqlCommand(q, c);
                cmd.Parameters.AddWithValue("UserName", username);
                cmd.Parameters.AddWithValue("UserPassword", userpassword);

                SqlDataReader r;
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    adminid = Convert.ToInt32(r["TeacherID"]);
                    gender = r["Gender"].ToString();
                    adminname = r["FullName"].ToString();
                    currentuser = usertxt.Text;
                    if (r["AccountStatus"].ToString() == "$")
                    {
                        MessageBox.Show("This USER is Not Active. Contact Admin...", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    checkClassAssigned(adminid);
                    if (savecb.Checked)
                    {
                        try
                        {
                            FileStream f = new FileStream("savefile.dat", FileMode.Create, FileAccess.Write);
                            StreamWriter w = new StreamWriter(f);
                            w.WriteLine(username);
                            w.WriteLine(userpassword);
                            w.Close();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("File Error Occured");
                        }
                    }
                    MessageBox.Show("LOGIN SUCCESSFUL...", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MainMenu.runLog("execute spSetLogs '"+adminid+"', '" + adminname + "', 'Teacher', 'Login Performed', 'TeacherInfo', '" + DateTime.Now + "', 'Logged in By UserName = " + usertxt.Text + "' ");
                    c.Close();
                    this.Hide();
                    MainMenu m = new MainMenu(this);
                    m.Show();

                }
                else
                {
                    MessageBox.Show("USER DOES NOT EXISTS OR INVALID USERNAME OR PASSWORD.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        public static string getUser() { return user; }
        private void button2_Click(object sender, EventArgs e)
        {
            if(usertxt.Text=="" || passwordtxt.Text == "")
            {
                this.Close();
            }
            MainMenu.runLog("execute spSetLogs '" + getuadminID() + "', '" + getAdminName() + "', '" + getUser() + "', 'Logged Out', 'School System Application', '" + DateTime.Now + "', 'Logged Out to UserName = " + getCurrentUser() + "' ");
            this.Close();
        }
        public static string getGender()
        {
            return gender;
        }

        public static string getAdminName()
        {
            return adminname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = "admin";
            username = usertxt.Text;
            userpassword = passwordtxt.Text;
            SqlConnection c = new SqlConnection(connstring);
            c.Open();
            if(c.State == ConnectionState.Open)
            {
                string q = "select * from AdminPanel where UserName=@UserName and UserPassword=@UserPassword";
                SqlCommand cmd = new SqlCommand(q, c);
                cmd.Parameters.AddWithValue("UserName", username);
                cmd.Parameters.AddWithValue("UserPassword", userpassword);
                SqlDataReader r;
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    adminid = Convert.ToInt32(r["AdminID"]);
                    gender = r["Gender"].ToString();
                    adminname = r["FullName"].ToString();
                    currentuser = usertxt.Text;
                    if (r["AdminStatus"].ToString() == "$")
                    {
                        MessageBox.Show("Admin is Not Active. Contact Management...", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    
                    if (savecb.Checked)
                    {
                        FileStream f = new FileStream("savefile.dat", FileMode.Create, FileAccess.Write);
                        StreamWriter w = new StreamWriter(f);
                        w.WriteLine(username);
                        w.WriteLine(userpassword);
                        w.Close();
                    }
                    MessageBox.Show("LOGIN SUCCESSFUL...", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MainMenu.runLog("execute spSetLogs '" + adminid + "', '" + adminname + "', 'Admin', 'Login Performed', 'AdminPanel', '" + DateTime.Now + "', 'Logged in By UserName = " + usertxt.Text + "' ");
                    c.Close();
                    this.Hide();
                    MainMenu m = new MainMenu(this);
                    m.Show();
                }
                else
                {
                    MessageBox.Show("USER DOES NOT EXISTS OR INVALID USERNAME OR PASSWORD.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
