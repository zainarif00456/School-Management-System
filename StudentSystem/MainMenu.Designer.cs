
namespace StudentSystem
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.sidemenu = new System.Windows.Forms.Panel();
            this.uploadmarksbtn = new System.Windows.Forms.Button();
            this.accountupdatebtn = new System.Windows.Forms.Button();
            this.attendancebtn = new System.Windows.Forms.Button();
            this.feemanagementbtn = new System.Windows.Forms.Button();
            this.classmanagebtn = new System.Windows.Forms.Button();
            this.addnewteacherbtn = new System.Windows.Forms.Button();
            this.profilebtn = new System.Windows.Forms.Button();
            this.registrationbtn = new System.Windows.Forms.Button();
            this.informationbtn = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminnamelbl = new System.Windows.Forms.Label();
            this.adminlogo = new System.Windows.Forms.PictureBox();
            this.headpanel = new System.Windows.Forms.Panel();
            this.headinglbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.maxbtn = new System.Windows.Forms.Button();
            this.minbtn = new System.Windows.Forms.Button();
            this.maxedbtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.controlcarry = new System.Windows.Forms.Panel();
            this.addTeacher1 = new StudentSystem.AddTeacher();
            this.userControl11 = new StudentSystem.UserControl1();
            this.homeGround1 = new StudentSystem.HomeGround();
            this.studentProfile1 = new StudentSystem.StudentProfile();
            this.registration1 = new StudentSystem.Registration();
            this.sidemenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminlogo)).BeginInit();
            this.headpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.controlcarry.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidemenu
            // 
            this.sidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.sidemenu.Controls.Add(this.uploadmarksbtn);
            this.sidemenu.Controls.Add(this.accountupdatebtn);
            this.sidemenu.Controls.Add(this.attendancebtn);
            this.sidemenu.Controls.Add(this.feemanagementbtn);
            this.sidemenu.Controls.Add(this.classmanagebtn);
            this.sidemenu.Controls.Add(this.addnewteacherbtn);
            this.sidemenu.Controls.Add(this.profilebtn);
            this.sidemenu.Controls.Add(this.registrationbtn);
            this.sidemenu.Controls.Add(this.informationbtn);
            this.sidemenu.Controls.Add(this.homebtn);
            this.sidemenu.Controls.Add(this.panel1);
            this.sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenu.Location = new System.Drawing.Point(0, 0);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(206, 579);
            this.sidemenu.TabIndex = 0;
            // 
            // uploadmarksbtn
            // 
            this.uploadmarksbtn.AccessibleName = "informationbtn";
            this.uploadmarksbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.uploadmarksbtn.FlatAppearance.BorderSize = 0;
            this.uploadmarksbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.uploadmarksbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadmarksbtn.ForeColor = System.Drawing.Color.White;
            this.uploadmarksbtn.Location = new System.Drawing.Point(0, 439);
            this.uploadmarksbtn.Name = "uploadmarksbtn";
            this.uploadmarksbtn.Size = new System.Drawing.Size(206, 33);
            this.uploadmarksbtn.TabIndex = 12;
            this.uploadmarksbtn.Text = "Mark Sheet";
            this.uploadmarksbtn.UseVisualStyleBackColor = true;
            this.uploadmarksbtn.Visible = false;
            this.uploadmarksbtn.Click += new System.EventHandler(this.uploadmarksbtn_Click);
            // 
            // accountupdatebtn
            // 
            this.accountupdatebtn.AccessibleName = "informationbtn";
            this.accountupdatebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountupdatebtn.FlatAppearance.BorderSize = 0;
            this.accountupdatebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.accountupdatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountupdatebtn.ForeColor = System.Drawing.Color.White;
            this.accountupdatebtn.Location = new System.Drawing.Point(0, 406);
            this.accountupdatebtn.Name = "accountupdatebtn";
            this.accountupdatebtn.Size = new System.Drawing.Size(206, 33);
            this.accountupdatebtn.TabIndex = 10;
            this.accountupdatebtn.Text = "Update Your Account";
            this.accountupdatebtn.UseVisualStyleBackColor = true;
            this.accountupdatebtn.Click += new System.EventHandler(this.accountupdatebtn_Click);
            // 
            // attendancebtn
            // 
            this.attendancebtn.AccessibleName = "informationbtn";
            this.attendancebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.attendancebtn.FlatAppearance.BorderSize = 0;
            this.attendancebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.attendancebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.attendancebtn.ForeColor = System.Drawing.Color.White;
            this.attendancebtn.Location = new System.Drawing.Point(0, 373);
            this.attendancebtn.Name = "attendancebtn";
            this.attendancebtn.Size = new System.Drawing.Size(206, 33);
            this.attendancebtn.TabIndex = 9;
            this.attendancebtn.Text = "Student Attendance";
            this.attendancebtn.UseVisualStyleBackColor = true;
            this.attendancebtn.Visible = false;
            this.attendancebtn.Click += new System.EventHandler(this.attendancebtn_Click);
            // 
            // feemanagementbtn
            // 
            this.feemanagementbtn.AccessibleName = "informationbtn";
            this.feemanagementbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.feemanagementbtn.FlatAppearance.BorderSize = 0;
            this.feemanagementbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.feemanagementbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feemanagementbtn.ForeColor = System.Drawing.Color.White;
            this.feemanagementbtn.Location = new System.Drawing.Point(0, 340);
            this.feemanagementbtn.Name = "feemanagementbtn";
            this.feemanagementbtn.Size = new System.Drawing.Size(206, 33);
            this.feemanagementbtn.TabIndex = 8;
            this.feemanagementbtn.Text = "Fee Management";
            this.feemanagementbtn.UseVisualStyleBackColor = true;
            this.feemanagementbtn.Click += new System.EventHandler(this.feemanagementbtn_Click);
            // 
            // classmanagebtn
            // 
            this.classmanagebtn.AccessibleName = "informationbtn";
            this.classmanagebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.classmanagebtn.FlatAppearance.BorderSize = 0;
            this.classmanagebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.classmanagebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classmanagebtn.ForeColor = System.Drawing.Color.White;
            this.classmanagebtn.Location = new System.Drawing.Point(0, 307);
            this.classmanagebtn.Name = "classmanagebtn";
            this.classmanagebtn.Size = new System.Drawing.Size(206, 33);
            this.classmanagebtn.TabIndex = 7;
            this.classmanagebtn.Text = "Classes Management";
            this.classmanagebtn.UseVisualStyleBackColor = true;
            this.classmanagebtn.Click += new System.EventHandler(this.classmanagebtn_Click);
            // 
            // addnewteacherbtn
            // 
            this.addnewteacherbtn.AccessibleName = "informationbtn";
            this.addnewteacherbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addnewteacherbtn.FlatAppearance.BorderSize = 0;
            this.addnewteacherbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.addnewteacherbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addnewteacherbtn.ForeColor = System.Drawing.Color.White;
            this.addnewteacherbtn.Location = new System.Drawing.Point(0, 274);
            this.addnewteacherbtn.Name = "addnewteacherbtn";
            this.addnewteacherbtn.Size = new System.Drawing.Size(206, 33);
            this.addnewteacherbtn.TabIndex = 6;
            this.addnewteacherbtn.Text = "Teacher Management";
            this.addnewteacherbtn.UseVisualStyleBackColor = true;
            this.addnewteacherbtn.Click += new System.EventHandler(this.addnewteacherbtn_Click);
            // 
            // profilebtn
            // 
            this.profilebtn.AccessibleName = "informationbtn";
            this.profilebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.profilebtn.FlatAppearance.BorderSize = 0;
            this.profilebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.profilebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profilebtn.ForeColor = System.Drawing.Color.White;
            this.profilebtn.Location = new System.Drawing.Point(0, 241);
            this.profilebtn.Name = "profilebtn";
            this.profilebtn.Size = new System.Drawing.Size(206, 33);
            this.profilebtn.TabIndex = 5;
            this.profilebtn.Text = "Student Profile";
            this.profilebtn.UseVisualStyleBackColor = true;
            this.profilebtn.Click += new System.EventHandler(this.profilebtn_Click);
            // 
            // registrationbtn
            // 
            this.registrationbtn.AccessibleName = "informationbtn";
            this.registrationbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.registrationbtn.FlatAppearance.BorderSize = 0;
            this.registrationbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.registrationbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationbtn.ForeColor = System.Drawing.Color.White;
            this.registrationbtn.Location = new System.Drawing.Point(0, 208);
            this.registrationbtn.Name = "registrationbtn";
            this.registrationbtn.Size = new System.Drawing.Size(206, 33);
            this.registrationbtn.TabIndex = 4;
            this.registrationbtn.Text = "Registration";
            this.registrationbtn.UseVisualStyleBackColor = true;
            this.registrationbtn.Click += new System.EventHandler(this.registrationbtn_Click);
            // 
            // informationbtn
            // 
            this.informationbtn.AccessibleName = "informationbtn";
            this.informationbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.informationbtn.FlatAppearance.BorderSize = 0;
            this.informationbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.informationbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.informationbtn.ForeColor = System.Drawing.Color.White;
            this.informationbtn.Location = new System.Drawing.Point(0, 175);
            this.informationbtn.Name = "informationbtn";
            this.informationbtn.Size = new System.Drawing.Size(206, 33);
            this.informationbtn.TabIndex = 3;
            this.informationbtn.Text = "Student Information";
            this.informationbtn.UseVisualStyleBackColor = true;
            this.informationbtn.Click += new System.EventHandler(this.informationbtn_Click);
            // 
            // homebtn
            // 
            this.homebtn.AccessibleName = "homebtn";
            this.homebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.homebtn.FlatAppearance.BorderSize = 0;
            this.homebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebtn.ForeColor = System.Drawing.Color.White;
            this.homebtn.Location = new System.Drawing.Point(0, 142);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(206, 33);
            this.homebtn.TabIndex = 0;
            this.homebtn.Text = "Home";
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.homebtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.adminnamelbl);
            this.panel1.Controls.Add(this.adminlogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 142);
            this.panel1.TabIndex = 2;
            // 
            // adminnamelbl
            // 
            this.adminnamelbl.AutoSize = true;
            this.adminnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminnamelbl.ForeColor = System.Drawing.Color.DarkOrange;
            this.adminnamelbl.Location = new System.Drawing.Point(25, 112);
            this.adminnamelbl.Name = "adminnamelbl";
            this.adminnamelbl.Size = new System.Drawing.Size(60, 18);
            this.adminnamelbl.TabIndex = 1;
            this.adminnamelbl.Text = "ADMIN";
            // 
            // adminlogo
            // 
            this.adminlogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminlogo.Image = global::StudentSystem.Properties.Resources.madmin;
            this.adminlogo.Location = new System.Drawing.Point(0, 0);
            this.adminlogo.Name = "adminlogo";
            this.adminlogo.Size = new System.Drawing.Size(206, 99);
            this.adminlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adminlogo.TabIndex = 0;
            this.adminlogo.TabStop = false;
            // 
            // headpanel
            // 
            this.headpanel.Controls.Add(this.headinglbl);
            this.headpanel.Controls.Add(this.panel2);
            this.headpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headpanel.Location = new System.Drawing.Point(206, 0);
            this.headpanel.Name = "headpanel";
            this.headpanel.Size = new System.Drawing.Size(984, 39);
            this.headpanel.TabIndex = 1;
            // 
            // headinglbl
            // 
            this.headinglbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.headinglbl.AutoSize = true;
            this.headinglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headinglbl.ForeColor = System.Drawing.Color.White;
            this.headinglbl.Location = new System.Drawing.Point(387, 5);
            this.headinglbl.Name = "headinglbl";
            this.headinglbl.Size = new System.Drawing.Size(166, 31);
            this.headinglbl.TabIndex = 1;
            this.headinglbl.Text = "Admin Panel";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.maxbtn);
            this.panel2.Controls.Add(this.minbtn);
            this.panel2.Controls.Add(this.maxedbtn);
            this.panel2.Controls.Add(this.closebtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(790, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 39);
            this.panel2.TabIndex = 0;
            // 
            // maxbtn
            // 
            this.maxbtn.FlatAppearance.BorderSize = 0;
            this.maxbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.maxbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxbtn.Image = global::StudentSystem.Properties.Resources.minimize;
            this.maxbtn.Location = new System.Drawing.Point(19, 0);
            this.maxbtn.Name = "maxbtn";
            this.maxbtn.Size = new System.Drawing.Size(40, 39);
            this.maxbtn.TabIndex = 3;
            this.maxbtn.UseVisualStyleBackColor = true;
            this.maxbtn.Visible = false;
            this.maxbtn.Click += new System.EventHandler(this.maxbtn_Click);
            // 
            // minbtn
            // 
            this.minbtn.FlatAppearance.BorderSize = 0;
            this.minbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.minbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minbtn.Image = global::StudentSystem.Properties.Resources.minus_button;
            this.minbtn.Location = new System.Drawing.Point(65, 0);
            this.minbtn.Name = "minbtn";
            this.minbtn.Size = new System.Drawing.Size(40, 39);
            this.minbtn.TabIndex = 2;
            this.minbtn.UseVisualStyleBackColor = true;
            this.minbtn.Click += new System.EventHandler(this.minbtn_Click);
            // 
            // maxedbtn
            // 
            this.maxedbtn.FlatAppearance.BorderSize = 0;
            this.maxedbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.maxedbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxedbtn.Image = global::StudentSystem.Properties.Resources.fullscreen;
            this.maxedbtn.Location = new System.Drawing.Point(111, 0);
            this.maxedbtn.Name = "maxedbtn";
            this.maxedbtn.Size = new System.Drawing.Size(40, 39);
            this.maxedbtn.TabIndex = 1;
            this.maxedbtn.UseVisualStyleBackColor = true;
            this.maxedbtn.Click += new System.EventHandler(this.maxedbtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Image = global::StudentSystem.Properties.Resources.close__2_;
            this.closebtn.Location = new System.Drawing.Point(147, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(47, 39);
            this.closebtn.TabIndex = 0;
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // controlcarry
            // 
            this.controlcarry.Controls.Add(this.addTeacher1);
            this.controlcarry.Controls.Add(this.userControl11);
            this.controlcarry.Controls.Add(this.homeGround1);
            this.controlcarry.Controls.Add(this.studentProfile1);
            this.controlcarry.Controls.Add(this.registration1);
            this.controlcarry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlcarry.Location = new System.Drawing.Point(206, 39);
            this.controlcarry.Name = "controlcarry";
            this.controlcarry.Size = new System.Drawing.Size(984, 540);
            this.controlcarry.TabIndex = 2;
            // 
            // addTeacher1
            // 
            this.addTeacher1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.addTeacher1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addTeacher1.ForeColor = System.Drawing.Color.White;
            this.addTeacher1.Location = new System.Drawing.Point(0, 0);
            this.addTeacher1.Name = "addTeacher1";
            this.addTeacher1.Size = new System.Drawing.Size(984, 540);
            this.addTeacher1.TabIndex = 4;
            this.addTeacher1.Visible = false;
            // 
            // userControl11
            // 
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(984, 540);
            this.userControl11.TabIndex = 3;
            this.userControl11.Visible = false;
            // 
            // homeGround1
            // 
            this.homeGround1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeGround1.Location = new System.Drawing.Point(0, 0);
            this.homeGround1.Name = "homeGround1";
            this.homeGround1.Size = new System.Drawing.Size(984, 540);
            this.homeGround1.TabIndex = 2;
            this.homeGround1.Visible = false;
            // 
            // studentProfile1
            // 
            this.studentProfile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(17)))), ((int)(((byte)(31)))));
            this.studentProfile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentProfile1.Location = new System.Drawing.Point(0, 0);
            this.studentProfile1.Name = "studentProfile1";
            this.studentProfile1.Size = new System.Drawing.Size(984, 540);
            this.studentProfile1.TabIndex = 1;
            this.studentProfile1.Visible = false;
            // 
            // registration1
            // 
            this.registration1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.registration1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registration1.Location = new System.Drawing.Point(0, 0);
            this.registration1.Name = "registration1";
            this.registration1.Size = new System.Drawing.Size(984, 540);
            this.registration1.TabIndex = 0;
            this.registration1.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1190, 579);
            this.Controls.Add(this.controlcarry);
            this.Controls.Add(this.headpanel);
            this.Controls.Add(this.sidemenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.sidemenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminlogo)).EndInit();
            this.headpanel.ResumeLayout(false);
            this.headpanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.controlcarry.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidemenu;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel headpanel;
        private System.Windows.Forms.Button informationbtn;
        private System.Windows.Forms.Button profilebtn;
        private System.Windows.Forms.Button registrationbtn;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button maxedbtn;
        private System.Windows.Forms.Button minbtn;
        private System.Windows.Forms.Button maxbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label headinglbl;
        private System.Windows.Forms.Panel controlcarry;
        private Registration registration1;
        private StudentProfile studentProfile1;
        private HomeGround homeGround1;
        private UserControl1 userControl11;
        private System.Windows.Forms.Button addnewteacherbtn;
        private AddTeacher addTeacher1;
        private System.Windows.Forms.Button classmanagebtn;
        private System.Windows.Forms.PictureBox adminlogo;
        private System.Windows.Forms.Label adminnamelbl;
        private System.Windows.Forms.Button feemanagementbtn;
        private System.Windows.Forms.Button attendancebtn;
        private System.Windows.Forms.Button accountupdatebtn;
        private System.Windows.Forms.Button uploadmarksbtn;
    }
}