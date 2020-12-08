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
    public partial class video : Form
    {
        public video()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.URL = (Directory.GetCurrentDirectory() + @"\Resources\video.mp4");
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void exit6_Click(object sender, EventArgs e)
        {
            this.Hide();
            axWindowsMediaPlayer1.close();
        }
    }
}
