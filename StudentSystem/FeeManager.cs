using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentSystem
{
    public partial class FeeManager : Form
    {
        string connstring;
        public FeeManager()
        {
            InitializeComponent();
            connstring = @"Data Source=DESKTOP-J04ALPE;Initial Catalog=STUDENTS;Integrated Security=True";
            SqlConnection c = new SqlConnection(connstring);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string q = "select * from Classes";
                SqlCommand cmd = new SqlCommand(q, c);
                SqlDataReader r;
                r = cmd.ExecuteReader();
                while (r.Read())
                {
                    classnametxt.Items.AddRange(new object[] { $"{r["ClassID"]}" });
                }
                r.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getData();
        }
        private void getData() {
            if (classnametxt.Text == "")
            {
                MessageBox.Show("Select Class First", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = "select StudentInformation.ID, StudentInformation.Name, StudentInformation.FatherName, StudentInformation.ClassEnrolled, FeeManagement.TotalFee, StudentInformation.FeeStatus " +
                "from StudentInformation " +
                "FULL JOIN FeeManagement " +
                "on StudentInformation.ClassEnrolled = FeeManagement.ClassID " +
                "where StudentInformation.ClassEnrolled = '" + classnametxt.Text + "'";
            if (stdnametxt.Text != "")
            {
                query += " AND StudentInformation.Name LIKE '%" + stdnametxt.Text + "%'";
            }

            SqlConnection c = new SqlConnection(connstring);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand(query, c);
                SqlDataReader r = cmd.ExecuteReader();
                showStudentsview.Rows.Clear();
                while (r.Read())
                {
                    showStudentsview.Rows.Add(r[0], r[1], r[2], r[3], r[4], r[5], "Submit");
                }
            }
        }
        private void showStudentsview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (showStudentsview.Columns[e.ColumnIndex].Name == "submitbtn")
            {
                if(MessageBox.Show("Are You sure You Want to Update Fee Status?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string q = "update StudentInformation set FeeStatus='Yes' where ID = '" + Convert.ToInt32(showStudentsview.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString()) + "'";
                        SqlConnection c = new SqlConnection(connstring);
                        c.Open();
                        if (c.State == ConnectionState.Open)
                        {
                            SqlCommand cmd = new SqlCommand(q, c);
                            cmd.ExecuteNonQuery();
                        }
                        MainMenu.runLog("execute spSetLogs '" + LoginPanel.getuadminID() + "', '" + LoginPanel.getAdminName() + "', 'Admin', 'Update', 'StudentInformation', '" + DateTime.Now + "', 'FeeStatus updated By UserName = " + LoginPanel.getCurrentUser() + " To ClassID = " + classnametxt.Text + " And StudentID = "+ Convert.ToInt32(showStudentsview.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString()) + ", Status = Submit'");
                        getData();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error Occured...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
