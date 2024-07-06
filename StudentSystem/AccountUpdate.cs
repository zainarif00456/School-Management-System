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
    public partial class AccountUpdate : Form
    {
        string connectionstr;
        string name, username, phone, newpass, query, oldpass;
        public AccountUpdate()
        {
            InitializeComponent();
            connectionstr = @"Data Source=DESKTOP-J04ALPE;Initial Catalog=STUDENTS;Integrated Security=True";
            sqlQuery();
        }

        private void sqlQuery()
        {
            SqlConnection c = new SqlConnection(connectionstr);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                if (LoginPanel.getUser() == "teacher")
                {
                    query = "select * from TeacherInfo where TeacherID = '" + LoginPanel.getuadminID() + "'";
                }
                else
                {
                    query = "select * from AdminPanel where AdminID = '" + LoginPanel.getuadminID() + "'";
                }
                SqlCommand cmd = new SqlCommand(query, c);
                SqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    fullnametxt.Text = r["FullName"].ToString();
                    phonetxt.Text = r["PhoneNo"].ToString();
                    usernametxt.Text = r["UserName"].ToString();
                    oldpass = r["UserPassword"].ToString();
                }
                
                r.Close();
                c.Close();

            }
        }


        private void updatebtn_Click(object sender, EventArgs e)
        {
            name = fullnametxt.Text;
            username = usernametxt.Text;
            phone = phonetxt.Text;
            newpass = newpasstxt.Text;
            SqlConnection c = new SqlConnection(connectionstr);
            c.Open();
            if (c.State == ConnectionState.Open)

                if (LoginPanel.getUser() == "teacher")
                {

                    
                    if (oldpass == oldpasstxt.Text)
                    {
                        query = "update TeacherInfo set FullName = '" + name + "', PhoneNo = '" + phone + "', " +
                            "UserName = '" + username + "', UserPassword = '" + newpass + "' " +
                            "where TeacherID = '" + LoginPanel.getuadminID() + "'";
                        SqlCommand cmd = new SqlCommand(query, c);
                        cmd.ExecuteNonQuery();
                        string type = "";
                       
                        MessageBox.Show("Information Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainMenu.runLog("execute spSetLogs '" + LoginPanel.getuadminID() + "', '" + LoginPanel.getAdminName() + "', '" + LoginPanel.getUser() + "', 'Update', 'TeacherInfo', '" + DateTime.Now + "', 'Account Information updated By UserName = " + LoginPanel.getCurrentUser() + "'");
                    }
                    else
                    {
                        MessageBox.Show("Password didn't Match. Try Again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    
                    if (oldpass == oldpasstxt.Text)
                    {
                        query = "update AdminPanel set FullName = '" + name + "', PhoneNo = '" + phone + "', " +
                            "UserName = '" + username + "', UserPassword = '" + newpass + "' " +
                            "where AdminID = '" + LoginPanel.getuadminID() + "'";
                        SqlCommand cmd = new SqlCommand(query, c);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Information Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainMenu.runLog("execute spSetLogs '" + LoginPanel.getuadminID() + "', '" + LoginPanel.getAdminName() + "', '" + LoginPanel.getUser() + "', 'Update', 'AdminPanel', '" + DateTime.Now + "', 'Account Information updated By UserName = " + LoginPanel.getCurrentUser() + "'");

                    }
                    else
                    {
                        MessageBox.Show("Password didn't Match. Try Again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
        }


    }
}
