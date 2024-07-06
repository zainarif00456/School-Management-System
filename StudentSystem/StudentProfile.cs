using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace StudentSystem
{
    public partial class StudentProfile : UserControl
    {
        string name, fname, fcontact, gender, address, classad, section, emcon, emname, filepath;

        private void searchbtn_Click(object sender, EventArgs e)
        {
            showStudents();
        }

        private void showStudents()
        {
            string connectionstr = @"Data Source=DESKTOP-J04ALPE;Initial Catalog=STUDENTS;Integrated Security=True";
            SqlConnection c = new SqlConnection(connectionstr);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                string query = "select * from StudentInformation";
                if (LoginPanel.getUser() == "teacher")
                {
                    query += " where ClassEnrolled = '" + LoginPanel.getClassAssigned() + "'";
                }
                SqlCommand cmd = new SqlCommand(query, c);
                SqlDataReader r;
                r = cmd.ExecuteReader();
                showStudentsview.Rows.Clear();
                while (r.Read())
                {
                    showStudentsview.Rows.Add(r["ID"], r["Name"], r["FatherName"], r["FatherCNIC"], r["FatherPhone"], r["ClassEnrolled"], r["DateOfBirth"]);

                }
                c.Close();
            }
        }

        private bool flag;
        public StudentProfile()
        {
            emname = "NONE";
            emcon = "NONE";
            flag = false;
            filepath = @"E:\INTERNSHIP WORKING\C# Practice\StudentSystem\StudentSystem\bin\Debug\profile.png";
            InitializeComponent();
            showStudents();
        }


        
    }
}
