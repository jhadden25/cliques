﻿using System;
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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void HideOptions()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }
     
        private void pictureBox1_Click(object sender, EventArgs e)//Rocket League
        {
            HideOptions();
            button1.Visible = true;
            button2.Visible = true;

        }
        private void pictureBox2_Click(object sender, EventArgs e)//CSGO
        {
            HideOptions();
            button1.Visible = true;
            button2.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)//League
        {
            HideOptions();
            button1.Visible = true;
            button2.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)//Dota
        {
            HideOptions();
            button1.Visible = true;
            button2.Visible = true;
        }
        private void pictureBox8_Click(object sender, EventArgs e)//Valorant
        {
            HideOptions();
            button1.Visible = true;
            button2.Visible = true;
        }
        private void pictureBox9_Click(object sender, EventArgs e)//Overwatch
        {
            HideOptions();
            button1.Visible = true;
            button2.Visible = true;
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//Join Team
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)//Create Team
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Close();
        }
    }
}