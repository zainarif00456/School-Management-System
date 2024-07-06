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
    public partial class UploadResult : Form
    {
        string connstring, query, dateofexam, type;
        double eng, urdu, math, comp, sci, isl, total, obt;

        private void updatebtn_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(connstring);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                dateofexam = examdatetxt.Value.ToString();
                for (int i = 0; i < resultpanel.Rows.Count - 1; i++)
                {
                    dateofexam = examdatetxt.Value.ToString();
                    query = "Update MarkSheet set ExamType = '"+examtype.Text.ToString()+"'," +
                        "English='" + Convert.ToInt32(resultpanel.Rows[i].Cells["engcol"].Value) + "'," +
                    "Urdu='" + Convert.ToInt32(resultpanel.Rows[i].Cells["urducol"].Value) + "'," +
                    "Math='" + Convert.ToInt32(resultpanel.Rows[i].Cells["mathcol"].Value) + "'," +
                    "Computer='" + Convert.ToInt32(resultpanel.Rows[i].Cells["computercol"].Value) + "'," +
                    "Islamyat='" + Convert.ToInt32(resultpanel.Rows[i].Cells["islcol"].Value) + "'," +
                    "Science='" + Convert.ToInt32(resultpanel.Rows[i].Cells["sciencecol"].Value) + "'," +
                    "TotalMarks='" + Convert.ToInt32(resultpanel.Rows[i].Cells["totalmarkscol"].Value) + "'," +
                    "ObtainedMarks='" + Convert.ToInt32(resultpanel.Rows[i].Cells["obtmarkscol"].Value) + "'," +
                    "PercentAge='" + Convert.ToDouble(resultpanel.Rows[i].Cells["percentcol"].Value) + "'," +
                    "PublishedBy='" + LoginPanel.getuadminID() + "'," +
                    "DateOfUpload='" + DateTime.Now + "' where DateOfExam = '" + dateofexam + "'";
                    SqlCommand cmd = new SqlCommand(query, c);
                    cmd.ExecuteNonQuery();
                    MainMenu.runLog("execute spSetLogs '" + LoginPanel.getuadminID() + "', '" + LoginPanel.getAdminName() + "', '" + LoginPanel.getUser() + "', 'Update', 'MarkSheet', '" + DateTime.Now + "', 'Updated MarkSheet By UserName = " + LoginPanel.getCurrentUser() + ", DateOfExam = " + examdatetxt.Value + "'");

                }
                c.Close();
                MessageBox.Show("Marks Updated Successfully...!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        List<string> l;

        private List<string> getStudentData(int id)
        {
            l = new List<string>();
            connstring = @"Data Source=DESKTOP-J04ALPE;Initial Catalog=STUDENTS;Integrated Security=True";
            SqlConnection c = new SqlConnection(connstring);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                query = "select ID, Name, FatherName, ClassEnrolled from StudentInformation where " +
                    "ClassEnrolled = '" + LoginPanel.getClassAssigned() + "' and ID = '"+id+"'";
                SqlCommand cmd = new SqlCommand(query, c);
                SqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    l.Add(r["ID"].ToString());
                    l.Add(r["Name"].ToString());
                    l.Add(r["FatherName"].ToString());

                }
                r.Close();
                c.Close();
                
            }
            return l;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            resultpanel.Rows.Clear();
            List<string> names = new List<string>();
            connstring = @"Data Source=DESKTOP-J04ALPE;Initial Catalog=STUDENTS;Integrated Security=True";
            SqlConnection c = new SqlConnection(connstring);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                query = "select * from MarkSheet where DateOfExam = '" + examdatetxt.Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(query, c);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    names = getStudentData(Convert.ToInt32(r["StudentID"]));
                    total = Convert.ToInt32(r["TotalMarks"]);
                    type = r["ExamType"].ToString();
                    resultpanel.Rows.Add(names[0],names[1], names[2], r["ClassID"], r["English"], r["Urdu"], r["Math"], r["Computer"], r["Islamyat"], r["Science"], r["TotalMarks"], r["ObtainedMarks"], r["PercentAge"]);
                }
                totalmarkstxt.Text = total+"";
                examtype.Text = type;
                MainMenu.runLog("execute spSetLogs '" + LoginPanel.getuadminID() + "', '" + LoginPanel.getAdminName() + "', '" + LoginPanel.getUser() + "', 'Search', 'MarkSheet', '" + DateTime.Now + "', 'Result Sheet Searched By UserName = " + LoginPanel.getCurrentUser() + ", DateOfExam = "+examdatetxt.Value+"'");
                r.Close();
                c.Close();
            }
        }

        private void publishbtn_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(connstring);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                dateofexam = examdatetxt.Value.ToString();
                for (int i = 0; i < resultpanel.Rows.Count - 1; i++)
                {
                    
                    query = "insert into MarkSheet values(" +
                    "'" + resultpanel.Rows[i].Cells["stdid"].Value + "', " +
                    "'" + resultpanel.Rows[i].Cells["classcol"].Value + "'," +
                    "'" + examtype.Text.ToString() + "'," +
                    "'" + Convert.ToInt32(resultpanel.Rows[i].Cells["engcol"].Value) + "'," +
                    "'" + Convert.ToInt32(resultpanel.Rows[i].Cells["urducol"].Value) + "'," +
                    "'" + Convert.ToInt32(resultpanel.Rows[i].Cells["mathcol"].Value) + "'," +
                    "'" + Convert.ToInt32(resultpanel.Rows[i].Cells["computercol"].Value) + "'," +
                    "'" + Convert.ToInt32(resultpanel.Rows[i].Cells["islcol"].Value) + "'," +
                    "'" + Convert.ToInt32(resultpanel.Rows[i].Cells["sciencecol"].Value) + "'," +
                    "'" + Convert.ToInt32(resultpanel.Rows[i].Cells["totalmarkscol"].Value) + "'," +
                    "'" + Convert.ToInt32(resultpanel.Rows[i].Cells["obtmarkscol"].Value) + "'," +
                    "'" + Convert.ToDouble(resultpanel.Rows[i].Cells["percentcol"].Value) + "'," +
                    "'" + dateofexam + "'," +
                    "'" + LoginPanel.getuadminID()+ "'," +
                    "'" + DateTime.Now + "')";
                    SqlCommand cmd = new SqlCommand(query, c);
                    cmd.ExecuteNonQuery();
                    
                }
                MainMenu.runLog("execute spSetLogs '" + LoginPanel.getuadminID() + "', '" + LoginPanel.getAdminName() + "', '" + LoginPanel.getUser() + "', 'New Record Added', 'MarkSheet', '" + DateTime.Now + "', 'Result Uploaded By UserName = " + LoginPanel.getCurrentUser() + ", DateOfExam = " + examdatetxt.Value + "'");
                c.Close();
                MessageBox.Show("Marks Published Successfully...!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        double percentage;

        private void calculatebtn_Click(object sender, EventArgs e)
        {
            int k;
            if(totalmarkstxt.Text == "" || !int.TryParse(totalmarkstxt.Text, out k))
            {
                MessageBox.Show("Add Total Marks...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            total = Convert.ToDouble(totalmarkstxt.Text);
            for(int i=0; i<resultpanel.Rows.Count-1; i++)
            {
                eng = Convert.ToDouble(resultpanel.Rows[i].Cells["engcol"].Value);
                urdu = Convert.ToDouble(resultpanel.Rows[i].Cells["urducol"].Value);
                math = Convert.ToDouble(resultpanel.Rows[i].Cells["mathcol"].Value);
                comp = Convert.ToDouble(resultpanel.Rows[i].Cells["computercol"].Value);
                sci = Convert.ToDouble(resultpanel.Rows[i].Cells["sciencecol"].Value);
                isl = Convert.ToDouble(resultpanel.Rows[i].Cells["islcol"].Value);
                resultpanel.Rows[i].Cells["totalmarkscol"].Value = total;
                obt = eng + urdu + math + comp + sci + isl;
                if (total <= 0)
                {
                    MessageBox.Show("Math Error...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                percentage = (obt / total) * 100;
                percentage = Math.Round(percentage, 2);
                resultpanel.Rows[i].Cells["obtmarkscol"].Value = obt;
                resultpanel.Rows[i].Cells["percentcol"].Value = percentage;
            }
        }

        public UploadResult()
        {
            connstring = @"Data Source=DESKTOP-J04ALPE;Initial Catalog=STUDENTS;Integrated Security=True";
            InitializeComponent();
            SqlConnection c = new SqlConnection(connstring);
            c.Open();
            if (c.State == ConnectionState.Open)
            {
                query = "select ID, Name, FatherName, ClassEnrolled from StudentInformation where " +
                    "ClassEnrolled = '"+LoginPanel.getClassAssigned()+"'";
                SqlCommand cmd = new SqlCommand(query, c);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    resultpanel.Rows.Add(r["ID"], r["Name"], r["FatherName"], r["ClassEnrolled"]);
                }
                r.Close();
                c.Close();
            }

        }
    }
}
