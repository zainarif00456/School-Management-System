
namespace StudentSystem
{
    partial class HomeGround
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeGround));
            this.vplayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.vplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // vplayer
            // 
            this.vplayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vplayer.Enabled = true;
            this.vplayer.Location = new System.Drawing.Point(0, 0);
            this.vplayer.Name = "vplayer";
            this.vplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("vplayer.OcxState")));
            this.vplayer.Size = new System.Drawing.Size(891, 527);
            this.vplayer.TabIndex = 0;
            // 
            // HomeGround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vplayer);
            this.Name = "HomeGround";
            this.Size = new System.Drawing.Size(891, 527);
            ((System.ComponentModel.ISupportInitialize)(this.vplayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer vplayer;
    }
}
