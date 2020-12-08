namespace Sarmizegetusa_Regia
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.next = new Sarmizegetusa_Regia.CircularButton();
            this.exit1 = new Sarmizegetusa_Regia.CircularButton();
            this.contact = new Sarmizegetusa_Regia.CircularButton();
            this.info = new Sarmizegetusa_Regia.CircularButton();
            this.vreme = new Sarmizegetusa_Regia.CircularButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-19, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1242, 670);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next.BackgroundImage")));
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Location = new System.Drawing.Point(1037, 524);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(89, 77);
            this.next.TabIndex = 5;
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.circularButton5_Click_1);
            // 
            // exit1
            // 
            this.exit1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.exit1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit1.BackgroundImage")));
            this.exit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit1.Location = new System.Drawing.Point(1037, 12);
            this.exit1.Name = "exit1";
            this.exit1.Size = new System.Drawing.Size(89, 77);
            this.exit1.TabIndex = 4;
            this.exit1.UseVisualStyleBackColor = false;
            this.exit1.Click += new System.EventHandler(this.circularButton4_Click);
            // 
            // contact
            // 
            this.contact.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.contact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contact.BackgroundImage")));
            this.contact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.contact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contact.Location = new System.Drawing.Point(85, 411);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(144, 142);
            this.contact.TabIndex = 3;
            this.contact.UseVisualStyleBackColor = false;
            this.contact.Click += new System.EventHandler(this.contact_Click);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("info.BackgroundImage")));
            this.info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info.Location = new System.Drawing.Point(85, 225);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(144, 142);
            this.info.TabIndex = 2;
            this.info.UseVisualStyleBackColor = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // vreme
            // 
            this.vreme.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.vreme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vreme.BackgroundImage")));
            this.vreme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vreme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vreme.Location = new System.Drawing.Point(85, 43);
            this.vreme.Name = "vreme";
            this.vreme.Size = new System.Drawing.Size(144, 142);
            this.vreme.TabIndex = 1;
            this.vreme.UseVisualStyleBackColor = false;
            this.vreme.Click += new System.EventHandler(this.vreme_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 627);
            this.Controls.Add(this.next);
            this.Controls.Add(this.exit1);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.info);
            this.Controls.Add(this.vreme);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private CircularButton vreme;
        private CircularButton info;
        private CircularButton contact;
        private CircularButton exit1;
        private CircularButton next;
    }
}