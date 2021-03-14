using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp
{
    public partial class Form2 : Form
    {
        public FormData formData;
        public Form2()
        {  
            InitializeComponent();
            label2.Text = "Form a " + FormData.GAME + " Team";

            if (FormData.GAME == "Rocket League") {
                this.BackgroundImage = Properties.Resources.rocket_league_sport;
            }
            else if(FormData.GAME == "CSGO"){
                this.BackgroundImage = Properties.Resources.cs_splash;
            }
            else if (FormData.GAME == "League Of Legends")
            {
                this.BackgroundImage = Properties.Resources.league_splash;
            }
            else if (FormData.GAME == "Dota 2")
            {
                this.BackgroundImage = Properties.Resources.dota2_splash;
            }
            else if (FormData.GAME == "Valorant")
            {
                this.BackgroundImage = Properties.Resources.val_splash;
            }
            else if (FormData.GAME == "Overwatch")
            {
                this.BackgroundImage = Properties.Resources.ov_splash;
            }
            formData = new FormData();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    

       

        private void textBox1_TextChanged(object sender, EventArgs e)//Age Level text box
        {
            formData.ageLevel = textBox1.Text;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)//Contact
        {
            formData.contact = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)//Team Name
        {
            formData.teamName = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)//Team Rank
        {
            formData.teamRank = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)//# Team Members
        {
            formData.slotsAvailable = int.Parse(textBox5.Text);
        }

        private void button1_Click(object sender, EventArgs e)//Submit button
        {
           
            Database.PostDataToDB(FormData.GAME, formData);
        }


    }
}
