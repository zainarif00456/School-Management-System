
namespace StudentSystem
{
    partial class UploadResult
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.examtype = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calculatebtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resultpanel = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.updatebtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.examdatetxt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.totalmarkstxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.publishbtn = new System.Windows.Forms.Button();
            this.stdid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnamecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urducol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mathcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computercol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sciencecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalmarkscol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obtmarkscol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultpanel)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.examtype);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.calculatebtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 70);
            this.panel1.TabIndex = 1;
            // 
            // examtype
            // 
            this.examtype.FormattingEnabled = true;
            this.examtype.Items.AddRange(new object[] {
            "Mid-Term",
            "Final Term"});
            this.examtype.Location = new System.Drawing.Point(374, 21);
            this.examtype.Name = "examtype";
            this.examtype.Size = new System.Drawing.Size(193, 21);
            this.examtype.TabIndex = 2;
            this.examtype.Text = "Mid-Term";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Select Exam Type";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mark Sheet";
            // 
            // calculatebtn
            // 
            this.calculatebtn.BackColor = System.Drawing.Color.Blue;
            this.calculatebtn.FlatAppearance.BorderSize = 0;
            this.calculatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatebtn.Location = new System.Drawing.Point(573, 15);
            this.calculatebtn.Name = "calculatebtn";
            this.calculatebtn.Size = new System.Drawing.Size(106, 30);
            this.calculatebtn.TabIndex = 1;
            this.calculatebtn.Text = "Calculate";
            this.calculatebtn.UseVisualStyleBackColor = false;
            this.calculatebtn.Click += new System.EventHandler(this.calculatebtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.resultpanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1344, 326);
            this.panel2.TabIndex = 2;
            // 
            // resultpanel
            // 
            this.resultpanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.resultpanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultpanel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stdid,
            this.namecol,
            this.fnamecol,
            this.classcol,
            this.engcol,
            this.urducol,
            this.mathcol,
            this.computercol,
            this.islcol,
            this.sciencecol,
            this.totalmarkscol,
            this.obtmarkscol,
            this.percentcol});
            this.resultpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultpanel.Location = new System.Drawing.Point(0, 0);
            this.resultpanel.Name = "resultpanel";
            this.resultpanel.Size = new System.Drawing.Size(1344, 326);
            this.resultpanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.updatebtn);
            this.panel3.Controls.Add(this.searchbtn);
            this.panel3.Controls.Add(this.examdatetxt);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.totalmarkstxt);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.publishbtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 396);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1344, 96);
            this.panel3.TabIndex = 4;
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.updatebtn.FlatAppearance.BorderSize = 0;
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(1152, 27);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(107, 30);
            this.updatebtn.TabIndex = 9;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.searchbtn.FlatAppearance.BorderSize = 0;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(832, 28);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(107, 30);
            this.searchbtn.TabIndex = 8;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // examdatetxt
            // 
            this.examdatetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examdatetxt.Location = new System.Drawing.Point(573, 35);
            this.examdatetxt.Name = "examdatetxt";
            this.examdatetxt.Size = new System.Drawing.Size(241, 22);
            this.examdatetxt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(477, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Exam Date";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(182, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 1);
            this.panel4.TabIndex = 5;
            // 
            // totalmarkstxt
            // 
            this.totalmarkstxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.totalmarkstxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalmarkstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalmarkstxt.ForeColor = System.Drawing.Color.White;
            this.totalmarkstxt.Location = new System.Drawing.Point(182, 33);
            this.totalmarkstxt.Name = "totalmarkstxt";
            this.totalmarkstxt.Size = new System.Drawing.Size(233, 17);
            this.totalmarkstxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Marks of Exam";
            // 
            // publishbtn
            // 
            this.publishbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.publishbtn.FlatAppearance.BorderSize = 0;
            this.publishbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.publishbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishbtn.Location = new System.Drawing.Point(1265, 27);
            this.publishbtn.Name = "publishbtn";
            this.publishbtn.Size = new System.Drawing.Size(75, 30);
            this.publishbtn.TabIndex = 0;
            this.publishbtn.Text = "Publish";
            this.publishbtn.UseVisualStyleBackColor = false;
            this.publishbtn.Click += new System.EventHandler(this.publishbtn_Click);
            // 
            // stdid
            // 
            this.stdid.HeaderText = "Student ID";
            this.stdid.Name = "stdid";
            // 
            // namecol
            // 
            this.namecol.HeaderText = "Full Name";
            this.namecol.Name = "namecol";
            // 
            // fnamecol
            // 
            this.fnamecol.HeaderText = "Father\'s Name";
            this.fnamecol.Name = "fnamecol";
            // 
            // classcol
            // 
            this.classcol.HeaderText = "Class";
            this.classcol.Name = "classcol";
            // 
            // engcol
            // 
            this.engcol.HeaderText = "English";
            this.engcol.Name = "engcol";
            // 
            // urducol
            // 
            this.urducol.HeaderText = "Urdu";
            this.urducol.Name = "urducol";
            // 
            // mathcol
            // 
            this.mathcol.HeaderText = "Math";
            this.mathcol.Name = "mathcol";
            // 
            // computercol
            // 
            this.computercol.HeaderText = "Computer";
            this.computercol.Name = "computercol";
            // 
            // islcol
            // 
            this.islcol.HeaderText = "Islamyat";
            this.islcol.Name = "islcol";
            // 
            // sciencecol
            // 
            this.sciencecol.HeaderText = "Science";
            this.sciencecol.Name = "sciencecol";
            // 
            // totalmarkscol
            // 
            this.totalmarkscol.HeaderText = "Total Marks";
            this.totalmarkscol.Name = "totalmarkscol";
            // 
            // obtmarkscol
            // 
            this.obtmarkscol.HeaderText = "Obt. Marks";
            this.obtmarkscol.Name = "obtmarkscol";
            // 
            // percentcol
            // 
            this.percentcol.HeaderText = "Percentage (%)";
            this.percentcol.Name = "percentcol";
            // 
            // UploadResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1344, 492);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UploadResult";
            this.Text = "UploadResult";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultpanel)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView resultpanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button publishbtn;
        private System.Windows.Forms.Button calculatebtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox totalmarkstxt;
        private System.Windows.Forms.DateTimePicker examdatetxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox examtype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdid;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnamecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn classcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn engcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn urducol;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn computercol;
        private System.Windows.Forms.DataGridViewTextBoxColumn islcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sciencecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalmarkscol;
        private System.Windows.Forms.DataGridViewTextBoxColumn obtmarkscol;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentcol;
    }
}