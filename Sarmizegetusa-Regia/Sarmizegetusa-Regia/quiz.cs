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
    public partial class quiz : Form
    {
        public quiz()
        {
            InitializeComponent();
            
        }

        int corecte = 0;
        int c = 0;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void circularButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
           
            
            

            c++;
            switch (c)
            {
                case 1:
                    panel5.Dispose();
                    panel6.Dispose();
                    if (radioButton17.Checked) corecte++;
                    if (radioButton24.Checked) corecte++;
                    break;

                case 2:
                    panel4.Hide();
                    panel3.Hide();
                    if (radioButton10.Checked) corecte++;
                    if (radioButton13.Checked) corecte++;
                    break;

                case 3:
                    panel2.Hide();
                    panel1.Hide();
                    if (radioButton1.Checked) corecte++;
                    if (radioButton7.Checked) corecte++;
                    MessageBox.Show("Felicitari ai obtinut " + corecte + " puncte");
                    this.Hide();
                    break;
                
                    
            }
            



        }

        private void quiz_Load(object sender, EventArgs e)
        {

        }
    }
}
