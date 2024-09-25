namespace Tales_Of_Rizal
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BackgroundBtn = new System.Windows.Forms.Button();
            this.NoliBtn = new System.Windows.Forms.Button();
            this.ElfiliBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 592);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BackgroundBtn
            // 
            this.BackgroundBtn.BackColor = System.Drawing.Color.Black;
            this.BackgroundBtn.ForeColor = System.Drawing.Color.White;
            this.BackgroundBtn.Location = new System.Drawing.Point(614, 214);
            this.BackgroundBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackgroundBtn.Name = "BackgroundBtn";
            this.BackgroundBtn.Size = new System.Drawing.Size(352, 85);
            this.BackgroundBtn.TabIndex = 2;
            this.BackgroundBtn.Text = "BACKGROUND";
            this.BackgroundBtn.UseVisualStyleBackColor = false;
            this.BackgroundBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // NoliBtn
            // 
            this.NoliBtn.BackColor = System.Drawing.Color.Black;
            this.NoliBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.NoliBtn.Location = new System.Drawing.Point(614, 335);
            this.NoliBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NoliBtn.Name = "NoliBtn";
            this.NoliBtn.Size = new System.Drawing.Size(352, 85);
            this.NoliBtn.TabIndex = 3;
            this.NoliBtn.Text = "NOLI ME TANGERE";
            this.NoliBtn.UseVisualStyleBackColor = false;
            this.NoliBtn.Click += new System.EventHandler(this.NoliBtn_Click);
            // 
            // ElfiliBtn
            // 
            this.ElfiliBtn.BackColor = System.Drawing.Color.Black;
            this.ElfiliBtn.ForeColor = System.Drawing.Color.White;
            this.ElfiliBtn.Location = new System.Drawing.Point(614, 457);
            this.ElfiliBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ElfiliBtn.Name = "ElfiliBtn";
            this.ElfiliBtn.Size = new System.Drawing.Size(352, 85);
            this.ElfiliBtn.TabIndex = 4;
            this.ElfiliBtn.Text = "EL FILIBUSTERISMO";
            this.ElfiliBtn.UseVisualStyleBackColor = false;
            this.ElfiliBtn.Click += new System.EventHandler(this.ElfiliBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(481, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 117);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tales of Rizal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1105, 608);
            this.Controls.Add(this.ElfiliBtn);
            this.Controls.Add(this.NoliBtn);
            this.Controls.Add(this.BackgroundBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(1121, 647);
            this.MinimumSize = new System.Drawing.Size(1121, 647);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BackgroundBtn;
        private System.Windows.Forms.Button NoliBtn;
        private System.Windows.Forms.Button ElfiliBtn;
        private System.Windows.Forms.Label label1;
    }
}

