namespace Sarmizegetusa_Regia
{
    partial class informatii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(informatii));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.exit4 = new Sarmizegetusa_Regia.CircularButton();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1122, 588);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // exit4
            // 
            this.exit4.BackColor = System.Drawing.Color.White;
            this.exit4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit4.BackgroundImage")));
            this.exit4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit4.Location = new System.Drawing.Point(1030, 12);
            this.exit4.Name = "exit4";
            this.exit4.Size = new System.Drawing.Size(55, 54);
            this.exit4.TabIndex = 1;
            this.exit4.UseVisualStyleBackColor = false;
            this.exit4.Click += new System.EventHandler(this.exit4_Click);
            // 
            // informatii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 588);
            this.Controls.Add(this.exit4);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "informatii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "informatii";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private CircularButton exit4;
    }
}