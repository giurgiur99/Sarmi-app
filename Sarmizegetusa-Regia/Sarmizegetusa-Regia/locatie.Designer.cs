namespace Sarmizegetusa_Regia
{
    partial class locatie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(locatie));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.exit3 = new Sarmizegetusa_Regia.CircularButton();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowNavigation = false;
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1122, 588);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("https://www.google.com/maps/place/Sarmizegetusa+Regia/@45.6230986,23.3073112,16.7" +
        "5z/data=!4m5!3m4!1s0x474dd494bcd295a3:0xc9ae59da5362bb6a!8m2!3d45.622717!4d23.31" +
        "0439?hl=ro", System.UriKind.Absolute);
            // 
            // exit3
            // 
            this.exit3.BackColor = System.Drawing.Color.Transparent;
            this.exit3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit3.BackgroundImage")));
            this.exit3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit3.Location = new System.Drawing.Point(1039, 12);
            this.exit3.Name = "exit3";
            this.exit3.Size = new System.Drawing.Size(70, 65);
            this.exit3.TabIndex = 1;
            this.exit3.UseVisualStyleBackColor = false;
            this.exit3.Click += new System.EventHandler(this.exit3_Click);
            // 
            // locatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 588);
            this.Controls.Add(this.exit3);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "locatie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "locatie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private CircularButton exit3;
    }
}