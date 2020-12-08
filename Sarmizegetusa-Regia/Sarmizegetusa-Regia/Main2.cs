using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarmizegetusa_Regia
{
    public partial class Main2 : Form
    {
        public Main2()
        {
            InitializeComponent();
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main Main = new Main();
            Main.Show();
        }

        private void exit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void media_Click(object sender, EventArgs e)
        {
            video video = new video();
            video.Show();
        }

        private void circularButton2_Click(object sender, EventArgs e)
        {
            quiz quiz = new quiz();
            quiz.Show();
        }

        private void descopera_Click(object sender, EventArgs e)
        {
            Descopera Descopera = new Descopera();
            Descopera.Show();
        }
    }
}
