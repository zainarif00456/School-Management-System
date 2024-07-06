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

    public partial class Registration : UserControl
    {
       
        string name, fathername, fphone, address, classad, cnic, emergencyname, emergencycontact, gender, dob;
        string imglocation;
        private void uploadpic_Click(object sender, EventArgs e)
        {
            setImageLocation();
        }

        public Registration()
        {
            imglocation = "";
            emergencycontact = "NONE";
            emergencyname = "NONE";
            InitializeComponent();
            gender = "";
        }

        private void setImageLocation()
        {
            try
            {
                OpenFileDialog d = new OpenFileDialog();
                d.Filter = "jpg Files(*.jpg)|*.jpg|png Files(*.png)|*.png|jpeg Files(*.jpeg)|*.jpeg|All Files(*.*)|*.*";

                if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imglocation = d.FileName;
                    img.ImageLocation = imglocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR OCCURED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setName()
        {
            name = nametxt.Text;
        }

        private void setFname()
        {
            fathername = fathernametxt.Text;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (searchtxt.Text == "")
            {
                MessageBox.Show("Field Empty...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = Convert.ToInt32(searchtxt.Text);
                string connectionstr = @"Data Source=DESKTOP-J04ALPE;Initial Catalog=STUDENTS;Integrated Security=True";
                SqlConnection c = new SqlConnection(connectionstr);
                c.Open();
                if (c.State == ConnectionState.Open)
                {
                    string query = "select * from StudentInformation where ID = '" + id + "' " +
                        "execute spSetLogs '"+LoginPanel.getuadminID()+"', '"+LoginPanel.getAdminName()+"', 'Admin', 'Search ID = "+ id + "', 'StudentInformation', '"+DateTime.Now+ "', 'Searched Student from StudentInformation Table  By UserName = " + LoginPanel.getCurrentUser() + "' ";
                    query = query.ToString();
                    SqlCommand cmd = new SqlCommand(query, c);
                    SqlDataReader r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        nametxt.Text = r["Name"].ToString();
                        fathernametxt.Text = r["FatherName"].ToString();
                        fathercontacttxt.Text = r["FatherPhone"].ToString();
                        cnictxt.Text = r["FatherCNIC"].ToString();
                        addresstxt.Text = r["HomeAddress"].ToString();
                        classcb.Text = r["ClassEnrolled"].ToString();
                        dobtxt.Text = r["DateOfBirth"].ToString();
                        emergencynametxt.Text = r["EmergencyName"].ToString();
                        emergencycontacttxt.Text = r["EmergencyContact"].ToString();
                        img.ImageLocation = r["FilePath"].ToString();
                        imglocation = r["FilePath"].ToString();
                        gender = r["Gender"].ToString();
                        if (gender == "Male")
                        {
                            malerb.Checked = true;
                        }
                        else
                        {
                            femalerb.Checked = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Data Not Found...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    c.Close();
                }
            }
        }

        private void updatedatabtn_Click(object sender, EventArgs e)
        {
            if (name == "" || fathername == "" || address == "" || classad == "" || cnic == "" || gender == "" || imglocation == "")
            {
                MessageBox.Show("Fill All Entries", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (searchtxt.Text == "")
            {
                MessageBox.Show("Field Empty...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                setName();
                setFname();
                setFPhone();
                setAddress();
                setClassName();
                setCNIC();
                setGender();
                setDoB();
                setEmergencyContact();
                setEmergencyName();

                string connectionstr = @"Data Source=DESKTOP-J04ALPE;Initial Catalog=STUDENTS;Integrated Security=True";
                SqlConnection c = new SqlConnection(connectionstr);
                c.Open();
                if (c.State == ConnectionState.Open)
                {
                    string query = "update StudentInformation " +
                        "set Name='" + name + "', Gender='" + gender + "', FatherName='" + fathername + "'" +
                        ", FatherPhone='" + fphone + "', FatherCNIC='" + cnic + "', HomeAddress='" + address + "', " +
                        "ClassEnrolled='" + classad + "', " +
                        "DateOfBirth='" + dob + "'," +
                        "EmergencyName='" + emergencyname + "'," +
                        "EmergencyContact='" + emergencycontact + "', FilePath='" + imglocation + "', AdmitBy='" + MainMenu.SendID() + "', EntryDate='" + DateTime.Now + "', FeeStatus='No' where ID = '" + Convert.ToInt32(searchtxt.Text) + "' " +
                        "execute spSetLogs '" + LoginPanel.getuadminID() + "', '" + LoginPanel.getAdminName() + "', 'Admin', 'Updated Student Data ID = "+ Convert.ToInt32(searchtxt.Text) + "', 'StudentInformation', '" + DateTime.Now + "', 'Updated Student details from StudentInformation Table  By UserName = " + LoginPanel.getCurrentUser() + "' ";
                    query = query.ToString();
                    SqlCommand cmd = new SqlCommand(query, c);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Data Updated Successfully in Database...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    c.Close();
                    nametxt.Text = "";
                    fathercontacttxt.Text = "";
                    fathernametxt.Text = "";
                    emergencycontacttxt.Text = "";
                    emergencynametxt.Text = "";
                    addresstxt.Text = "";
                    classcb.Text = "";
                    cnictxt.Text = "";
                }

            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (searchtxt.Text == "")
            {
                MessageBox.Show("Field Empty...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string connectionstr = @"Data Source=DESKTOP-J04ALPE;Initial Catalog=STUDENTS;Integrated Security=True";
                SqlConnection c = new SqlConnection(connectionstr);
                c.Open();
                if (c.State == ConnectionState.Open)
                {
                    string query = "delete from StudentInformation where ID = '" + Convert.ToInt32(searchtxt.Text) + "' " +
                        "execute spSetLogs '" + LoginPanel.getuadminID() + "', '" + LoginPanel.getAdminName() + "', 'Admin', 'Delete Row ID = "+ Convert.ToInt32(searchtxt.Text) + "', 'StudentInformation', '" + DateTime.Now + "', 'Student Deleted from StudentInformation Table  By UserName = " + LoginPanel.getCurrentUser() + "' ";
                    query = query.ToString();
                    SqlCommand cmd = new SqlCommand(query, c);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Data Deleted Successfully in Database...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    c.Close();
                    nametxt.Text = "";
                    fathercontacttxt.Text = "";
                    fathernametxt.Text = "";
                    emergencycontacttxt.Text = "";
                    emergencynametxt.Text = "";
                    addresstxt.Text = "";
                    classcb.Text = "";
                    cnictxt.Text = "";
                }
            }
        }


        private void nametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void fathernametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void emergencynametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void fathercontacttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar)) 
            {
                e.Handled = true;
            }
            else if(fathercontacttxt.Text.Length > 12)
            {
                if(!(e.KeyChar == (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
            
        }

        private void cnictxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (cnictxt.Text.Length > 12)
            {
                if (!(e.KeyChar == (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void emergencycontacttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (emergencycontacttxt.Text.Length > 12)
            {
                if (!(e.KeyChar == (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void setFPhone()
        {

            fphone = fathercontacttxt.Text;

        }

        private void setAddress()
        {
            address = addresstxt.Text;
        }

        private void setClassName()
        {
            classad = classcb.Text;
        }

        private void setCNIC()
        {
            cnic = cnictxt.Text;
        }

        private void setEmergencyContact()
        {
            emergencycontact = emergencycontacttxt.Text;
        }

        private void setEmergencyName()
        {
            emergencyname = emergencynametxt.Text;
        }

        private void setGender()
        {
            if (malerb.Checked == true)
            {
                gender = "Male";
            }
            else if (femalerb.Checked == true)
            {
                gender = "Female";
            }
        }


        private void setDoB()
        {
            dob = dobtxt.Text;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            Int64 fk;
            if (!Int64.TryParse(fathercontacttxt.Text, out fk) || !Int64.TryParse(cnictxt.Text, out fk))
            {
                MessageBox.Show("Invalid Phone Number OR CNIC");
                return;
            }

            if (Int64.TryParse(nametxt.Text, out fk) || Int64.TryParse(fathernametxt.Text, out fk))
            {
                MessageBox.Show("Invalid Entries...");
                return;
            }

            // Setters for Student Information

            setName();
            setFname();
            setFPhone();
            setAddress();
            setClassName();
            setCNIC();
            setGender();
            setDoB();
            setEmergencyContact();
            setEmergencyName();
            if(dobtxt.Value.Year > DateTime.Now.Year || DateTime.Now.Year - dobtxt.Value.Year<0 || DateTime.Now.Year - dobtxt.Value.Year < 4)
            {
                MessageBox.Show("Invalid Date of Birth", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (name == "" || fathername == "" || address == "" || classad == "" || cnic == "" || gender == "" ||imglocation == "")
            {
                MessageBox.Show("Fill All Entries", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionstr = @"Data Source=DESKTOP-J04ALPE;Initial Catalog=STUDENTS;Integrated Security=True";
                SqlConnection c = new SqlConnection(connectionstr);
                c.Open();
                if (c.State == ConnectionState.Open)
                {
                    string query = "insert into StudentInformation(Name, Gender, FatherName, FatherPhone, FatherCNIC, HomeAddress, ClassEnrolled, " +
                        "DateOfBirth," +
                        "EmergencyName," +
                        "EmergencyContact, FilePath, AdmitBy, EntryDate, FeeStatus)" +
                        "values('"+name+ "', '" + gender+ "', '" + fathername+ "', '" + fphone + "','" + cnic + "', '" + address + "', " +
                        "'" + classad + "', '" + dob+ "', '" + emergencyname + "', '" + emergencycontact + "', '" + imglocation + "', " +
                        "'" + MainMenu.SendID() + "', '" + DateTime.Now + "', 'No') " +
                        "execute spSetLogs '" + LoginPanel.getuadminID() + "', '" + LoginPanel.getAdminName() + "', 'Admin', 'New Row Added', 'StudentInformation', '" + DateTime.Now + "', 'New Record Added in StudentInformation Table in ClassEnrolled = " + classad + " By UserName = " + LoginPanel.getCurrentUser() + "' ";

                    query = query.ToString();
                    SqlCommand cmd = new SqlCommand(query, c);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Data Saved Successfully in Database...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    c.Close();
                }
                else
                {
                    MessageBox.Show($"Data Failed to save in Database...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                /*
                FileStream f = new FileStream("studentinfo.txt", FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(f);
                writer.WriteLine($"Name {name}");
                writer.WriteLine(fathername);
                writer.WriteLine(fphone);
                writer.WriteLine(cnic);
                writer.WriteLine(gender);
                writer.WriteLine(address);
                writer.WriteLine(classad);
                writer.WriteLine(dob);
                writer.WriteLine(emergencyname);
                writer.WriteLine(emergencycontact);
                writer.WriteLine(imglocation);
                writer.Close();
                */

                
                nametxt.Text = "";
                fathercontacttxt.Text = "";
                fathernametxt.Text = "";
                emergencycontacttxt.Text = "";
                emergencynametxt.Text = "";
                addresstxt.Text = "";
                classcb.Text = "";
                cnictxt.Text = "";
            }
        }
    }
}
