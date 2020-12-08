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
    public partial class Descopera : Form
    {
        public Descopera()
        {
            InitializeComponent();

        }

        private void circularButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        ToolTip t1 = new ToolTip();
        private void circularButton1_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Templul mare circular", circularButton1);
        }

        private void circularButton3_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Templele patrulatere din extremitatea de nord", circularButton3);
        }

        private void circularButton4_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Soarele de andezit ( Altarul )", circularButton4);
        }

        private void circularButton5_MouseHover(object sender, EventArgs e)
        {
            t1.Show(" Drumul pavat ", circularButton5);
        }
    }
}
