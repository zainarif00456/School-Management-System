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
using System.Data.SqlClient;

namespace StudentSystem
{
    public partial class MainMenu : Form
    {
        LoginPanel l;
        public static string user, classassigned;
        public static int adminid;
        static string connstring;
       
        public static int SendID()
        { 
            return adminid;
        }
        public static string getUserType()
        {
            return user;
        }

        public MainMenu(LoginPanel l)
        {
            InitializeComponent();
            homeGround1.Visible = true;
            this.l = l;
            adminid = LoginPanel.getuadminID();
            user = LoginPanel.getUser();
            string gender = LoginPanel.getGender();
            adminnamelbl.Text = LoginPanel.getAdminName();
            if (gender == "Female")
            {
                adminlogo.Image = Properties.Resources.fadmin;
            }
            if(user == "teacher")
            {
                registrationbtn.Visible = false;
                addnewteacherbtn.Visible = false;
                headinglbl.Text = "TEACHER PANEL";
                informationbtn.Visible = false;
                adminid = LoginPanel.getuadminID();
                user = LoginPanel.getUser();
                gender = LoginPanel.getGender();
                adminnamelbl.Text = LoginPanel.getAdminName();
                if (gender == "Female")
                {
                    adminlogo.Image = Properties.Resources.fteacher;
                }
                else
                {
                    adminlogo.Image = Properties.Resources.mteacher;
                }
                feemanagementbtn.Visible = false;
                classmanagebtn.Visible = false;
                attendancebtn.Visible = true;
                uploadmarksbtn.Visible = true;
                classassigned = LoginPanel.getClassAssigned();

            }
        }

    
        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }
        public static string getClassAssigned()
        {
            return classassigned;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            string q = "execute spSetLogs '"+LoginPanel.getuadminID()+"', '" + LoginPanel.getAdminName() + "', '"+LoginPanel.getUser()+"', 'Logged Out', 'School System Application', '" + DateTime.Now + "', 'Logged Out to UserName = " + LoginPanel.getCurrentUser() + "' ";
            runLog(q);
            this.Close();
            l.Close();
        }

        private void maxedbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maxedbtn.Visible = false;
            maxbtn.Location = maxedbtn.Location;
            maxbtn.Visible = true;
        }

        private void maxbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            maxbtn.Visible = false;
            maxedbtn.Location = maxbtn.Location;
            maxedbtn.Visible = true;
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void registrationbtn_Click(object sender, EventArgs e)
        {
            if(registrationbtn.Focused == true)
            {
                addTeacher1.Visible = false;
                registration1.Visible = true;
                registrationbtn.BackColor = Color.Navy;
                homebtn.BackColor = panel1.BackColor;
                informationbtn.BackColor = panel1.BackColor;
                profilebtn.BackColor = panel1.BackColor;
                userControl11.Visible = false;
                homeGround1.Visible = false;
                studentProfile1.Visible = false;
                informationbtn.BackColor = panel1.BackColor;
                addnewteacherbtn.BackColor = panel1.BackColor;

            }
            
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            registration1.Visible = false;
            if (homebtn.Focused == true)
            {
                addTeacher1.Visible = false;
                homeGround1.Visible = true;
                informationbtn.BackColor = panel1.BackColor;
                homebtn.BackColor = Color.Navy;
                registrationbtn.BackColor = panel1.BackColor;
                profilebtn.BackColor = panel1.BackColor;
                registration1.Visible = false;
                userControl11.Visible = false;
                addnewteacherbtn.BackColor = panel1.BackColor;

            }
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            
            if (profilebtn.Focused == true)
            {
                studentProfile1.Visible = true;
                homebtn.BackColor = panel1.BackColor;
                registrationbtn.BackColor = panel1.BackColor;
                profilebtn.BackColor = Color.Navy;
                informationbtn.BackColor = panel1.BackColor;
                addTeacher1.Visible = false;
                userControl11.Visible = false;
                homeGround1.Visible = false;
                registration1.Visible = false;
                addnewteacherbtn.BackColor = panel1.BackColor;
            }
            runLog("execute spSetLogs '" + LoginPanel.getuadminID() + "', '" + LoginPanel.getAdminName() + "', '" + LoginPanel.getUser() + "', 'Accessed All Record', 'StudentInformation', '" + DateTime.Now + "', 'Accessed All data from StudentInformation Table' ");
        }
        public static void runLog(string query)
        {
            connstring = @"Data Source=DESKTOP-J04ALPE;Initial Catalog=STUDENTS;Integrated Security=True";
            SqlConnection c = new SqlConnection(connstring);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(query, c);
                cmd.ExecuteNonQuery();
            }
            c.Close();
        }
        private void informationbtn_Click(object sender, EventArgs e)
        {
            if (informationbtn.Focused == true)
            {
                homebtn.BackColor = panel1.BackColor;
                profilebtn.BackColor = panel1.BackColor;
                registrationbtn.BackColor = panel1.BackColor;
                informationbtn.BackColor = Color.Navy;
                userControl11.Visible = true;
                studentProfile1.Visible = false;
                homeGround1.Visible = false;
                addTeacher1.Visible = false;
                addnewteacherbtn.BackColor = panel1.BackColor;
            }
            runLog("execute spSetLogs '" + LoginPanel.getuadminID() + "', '" + LoginPanel.getAdminName() + "', '" + LoginPanel.getUser() + "', 'Accessed All Record', 'StudentInformation', '" + DateTime.Now + "', 'Accessed All data from StudentInformation Table' ");
        }

        private void addnewteacherbtn_Click(object sender, EventArgs e)
        {
            addTeacher1.Visible = true;
            if (addnewteacherbtn.Focused == true)
            {
                homebtn.BackColor = panel1.BackColor;
                profilebtn.BackColor = panel1.BackColor;
                registrationbtn.BackColor = panel1.BackColor;
                informationbtn.BackColor = panel1.BackColor;
                addnewteacherbtn.BackColor = Color.Navy;
                studentProfile1.Visible = false;
                userControl11.Visible = false;
                homeGround1.Visible = false;
            }
        }

        private void classmanagebtn_Click(object sender, EventArgs e)
        {
            ClassManagement c = new ClassManagement();
            c.Show();
        }

        private void attendancebtn_Click(object sender, EventArgs e)
        {
            Attendance atd = new Attendance();
            atd.Show();
        }

        private void accountupdatebtn_Click(object sender, EventArgs e)
        {
            // Code for Updating Account
            AccountUpdate ac = new AccountUpdate();
            ac.Show();
        }

        private void uploadmarksbtn_Click(object sender, EventArgs e)
        {
            UploadResult ur = new UploadResult();
            ur.Show();
        }


        private void feemanagementbtn_Click(object sender, EventArgs e)
        {
            FeeManager f = new FeeManager();
            f.Show();
        }
    }
}
