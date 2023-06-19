namespace Al_Madiina_Hotel
{
    partial class splashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splashScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pb1 = new Bunifu.UI.WinForms.BunifuProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(630, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pb1
            // 
            this.pb1.AllowAnimations = false;
            this.pb1.Animation = 0;
            this.pb1.AnimationSpeed = 220;
            this.pb1.AnimationStep = 10;
            this.pb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(86)))), ((int)(((byte)(189)))));
            this.pb1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb1.BackgroundImage")));
            this.pb1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(86)))), ((int)(((byte)(180)))));
            this.pb1.BorderRadius = 9;
            this.pb1.BorderThickness = 1;
            this.pb1.Location = new System.Drawing.Point(-10, 321);
            this.pb1.Maximum = 100;
            this.pb1.MaximumValue = 100;
            this.pb1.Minimum = 0;
            this.pb1.MinimumValue = 0;
            this.pb1.Name = "pb1";
            this.pb1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.pb1.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(86)))), ((int)(((byte)(189)))));
            this.pb1.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(86)))), ((int)(((byte)(180)))));
            this.pb1.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pb1.Size = new System.Drawing.Size(650, 20);
            this.pb1.TabIndex = 2;
            this.pb1.Value = 50;
            this.pb1.ValueByTransition = 50;
            // 
            // splashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 342);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "splashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SPLASH SCREEN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuProgressBar pb1;
    }
}

