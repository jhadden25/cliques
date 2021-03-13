using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


     
        private void pictureBox1_Click(object sender, EventArgs e)//Rocket League
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }
        private void pictureBox2_Click(object sender, EventArgs e)//CSGO
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)//League
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)//Dota
        {
           
        }
        private void pictureBox8_Click(object sender, EventArgs e)//Valorant
        {

        }
        private void pictureBox9_Click(object sender, EventArgs e)//Overwatch
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
