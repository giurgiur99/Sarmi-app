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

namespace Sarmizegetusa_Regia
{
    public partial class informatii : Form
    {
        public informatii()
        {
            InitializeComponent();
            webBrowser1.Navigate(Directory.GetCurrentDirectory() + @"\Resources\info.htm");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void exit4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
