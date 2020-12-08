using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Sarmizegetusa_Regia
{
    public partial class Main : Form
    {

        


        public Main()
        {
            InitializeComponent();
        }



        private void circularButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void circularButton5_Click(object sender, EventArgs e)
        {
            Main2 Main2 = new Main2();
            Main2.Show();
        }

        private void circularButton5_Click_1(object sender, EventArgs e)
        {
            Main2 Main2 = new Main2();
            Main2.Show();
        }

        private async void vreme_Click(object sender, EventArgs e)
        {
            locatie locatie = new locatie();
            locatie.Show();
         
        }

        private void info_Click(object sender, EventArgs e)
        {
            informatii informatii = new informatii();
            informatii.Show();
        }

        private void contact_Click(object sender, EventArgs e)
        {
            contact contact = new contact();
            contact.Show();
        }
    }
    }


