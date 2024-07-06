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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            getData();
        }
        string name, fname, fcontact, gender, address, classad, cnic, emname, emcontact, imglocation;

        public void getData()
        {

            try
            {
                string connectionstr = @"Data Source=DESKTOP-J04ALPE;Initial Catalog=STUDENTS;Integrated Security=True";
                SqlConnection c = new SqlConnection(connectionstr);
                c.Open();
                if (c.State == ConnectionState.Open)
                {
                    string query = "select * from StudentInformation";
                    query = query.ToString();
                    SqlCommand cmd = new SqlCommand(query, c);
                    SqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        name = r["Name"].ToString();
                        fname = r["FatherName"].ToString();
                        fcontact = r["FatherPhone"].ToString();
                        gender = r["Gender"].ToString();
                        address = r["HomeAddress"].ToString();
                        cnic = r["FatherCNIC"].ToString();
                        emname = r["EmergencyName"].ToString();
                        emcontact = r["EmergencyContact"].ToString();
                        imglocation = r["FilePath"].ToString();
                        classad = r["ClassEnrolled"].ToString();
                        runTimeComponents(name, fname, fcontact, gender, address, classad, cnic, emname, emcontact, imglocation);

                    }
                }
            }
            catch (Exception)
            {
                //  UNKNOWN EXCEPTION


                // MessageBox.Show("ERROR OCCURED...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void runTimeComponents(string n, string fn, string fc, string g, string ad, string c, string s, string emn, string emc, string loc)
        {
            Panel infopanel;
            Label shownamelbl;
            Label showfnamelbl;
            Label showgenderlbl;
            Label showfcontactlbl;
            Label showclasslbl;
            Label showaddlbl;
            PictureBox showprofileimg;
            GroupBox groupBox1;
            Label showemcontactlbl;
            Label showemnamelbl;
            Label showsectionlbl;
            


            infopanel = new System.Windows.Forms.Panel();
            shownamelbl = new System.Windows.Forms.Label();
            showfnamelbl = new System.Windows.Forms.Label();
            showfcontactlbl = new System.Windows.Forms.Label();
            showgenderlbl = new System.Windows.Forms.Label();
            showaddlbl = new System.Windows.Forms.Label();
            showclasslbl = new System.Windows.Forms.Label();
            showsectionlbl = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            showemnamelbl = new System.Windows.Forms.Label();
            showemcontactlbl = new System.Windows.Forms.Label();
            showprofileimg = new CircularPictureBox();
            panel1.SuspendLayout();
            infopanel.SuspendLayout();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)(showprofileimg)).BeginInit();

            
            infopanel.Controls.Add(showprofileimg);
            infopanel.Controls.Add(groupBox1);
            infopanel.Controls.Add(showsectionlbl);
            infopanel.Controls.Add(showclasslbl);
            infopanel.Controls.Add(showaddlbl);
            infopanel.Controls.Add(showgenderlbl);
            infopanel.Controls.Add(showfcontactlbl);
            infopanel.Controls.Add(showfnamelbl);
            infopanel.Controls.Add(shownamelbl);
            infopanel.Padding = new Padding(10, 50, 10, 10);
            infopanel.Dock = DockStyle.Top;
            infopanel.Location = new Point(3, 3);
            infopanel.Name = "infopanel";
            infopanel.Size = new Size(777, 282);
            infopanel.TabIndex = 0;
            // 
            // shownamelbl
            // 
            shownamelbl.AutoSize = true;
            shownamelbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            shownamelbl.Location = new System.Drawing.Point(3, 15);
            shownamelbl.Name = "shownamelbl";
            shownamelbl.Size = new System.Drawing.Size(125, 22);
            shownamelbl.TabIndex = 0;
            shownamelbl.Text = "Student Name";
            // 
            // showfnamelbl
            // 
            showfnamelbl.AutoSize = true;
            showfnamelbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            showfnamelbl.Location = new System.Drawing.Point(3, 58);
            showfnamelbl.Name = "showfnamelbl";
            showfnamelbl.Size = new System.Drawing.Size(131, 22);
            showfnamelbl.TabIndex = 1;
            showfnamelbl.Text = "Father\'s Name";
            // 
            // showfcontactlbl
            // 
            showfcontactlbl.AutoSize = true;
            showfcontactlbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            showfcontactlbl.Location = new System.Drawing.Point(3, 100);
            showfcontactlbl.Name = "showfcontactlbl";
            showfcontactlbl.Size = new System.Drawing.Size(148, 22);
            showfcontactlbl.TabIndex = 2;
            showfcontactlbl.Text = "Father\'s Contact";
            // 
            // showgenderlbl
            // 
            showgenderlbl.AutoSize = true;
            showgenderlbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            showgenderlbl.Location = new System.Drawing.Point(3, 149);
            showgenderlbl.Name = "showgenderlbl";
            showgenderlbl.Size = new System.Drawing.Size(71, 22);
            showgenderlbl.TabIndex = 3;
            showgenderlbl.Text = "Gender";
            // 
            // showaddlbl
            // 
            showaddlbl.AutoSize = true;
            showaddlbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            showaddlbl.Location = new System.Drawing.Point(322, 12);
            showaddlbl.Name = "showaddlbl";
            showaddlbl.Size = new System.Drawing.Size(76, 22);
            showaddlbl.TabIndex = 4;
            showaddlbl.Text = "Address";
            // 
            // showclasslbl
            // 
            showclasslbl.AutoSize = true;
            showclasslbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            showclasslbl.Location = new System.Drawing.Point(322, 58);
            showclasslbl.Name = "showclasslbl";
            showclasslbl.Size = new System.Drawing.Size(55, 22);
            showclasslbl.TabIndex = 5;
            showclasslbl.Text = "Class";
            // 
            // showsectionlbl
            // 
            showsectionlbl.AutoSize = true;
            showsectionlbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            showsectionlbl.Location = new System.Drawing.Point(322, 100);
            showsectionlbl.Name = "showsectionlbl";
            showsectionlbl.Size = new System.Drawing.Size(70, 22);
            showsectionlbl.TabIndex = 6;
            showsectionlbl.Text = "Section";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(showemcontactlbl);
            groupBox1.Controls.Add(showemnamelbl);
            groupBox1.Location = new System.Drawing.Point(326, 149);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(219, 130);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Emergency Contact";
            // 
            // showemnamelbl
            // 
            showemnamelbl.AutoSize = true;
            showemnamelbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            showemnamelbl.Location = new System.Drawing.Point(6, 25);
            showemnamelbl.Name = "showemnamelbl";
            showemnamelbl.Size = new System.Drawing.Size(58, 22);
            showemnamelbl.TabIndex = 8;
            showemnamelbl.Text = "Name";
            // 
            // showemcontactlbl
            // 
            showemcontactlbl.AutoSize = true;
            showemcontactlbl.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            showemcontactlbl.Location = new System.Drawing.Point(8, 58);
            showemcontactlbl.Name = "showemcontactlbl";
            showemcontactlbl.Size = new System.Drawing.Size(75, 22);
            showemcontactlbl.TabIndex = 9;
            showemcontactlbl.Text = "Contact";
            // 
            // showprofileimg
            // 
            showprofileimg.Location = new System.Drawing.Point(630, 3);
            showprofileimg.Name = "showprofileimg";
            showprofileimg.Size = new System.Drawing.Size(200, 200);
            showprofileimg.TabIndex = 8;
            showprofileimg.TabStop = false;
            showprofileimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;


            infopanel.ResumeLayout(false);
            infopanel.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            flowLayoutPanel1.Controls.Add(infopanel);
            Controls.Add(flowLayoutPanel1);
            ((System.ComponentModel.ISupportInitialize)(showprofileimg)).EndInit();


            shownamelbl.Text = $"{n}";
            showfnamelbl.Text = $"FATHER'S NAME: {fn}";
            showfcontactlbl.Text = $"FATHER'S Phone: {fc}";
            showgenderlbl.Text = $"Gender: {g}";
            showaddlbl.Text = $"Address: {ad}";
            showclasslbl.Text = $"Class: {c}";
            showsectionlbl.Text = $"Father's CNIC: {s}";
            showemnamelbl.Text = $"Name: {emn}";
            showemcontactlbl.Text = $"Contact: {emc}";
            showprofileimg.ImageLocation = loc;




            

            





        }
    }
}
