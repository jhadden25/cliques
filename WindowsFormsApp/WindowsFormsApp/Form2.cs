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
using Ranks;

namespace WindowsFormsApp
{
    public partial class Form2 : Form
    {
        public FormData formData;

        bool clickedSubmit = false;
        public Form2()
        {  
            InitializeComponent();
            label2.Text = "Form a " + FormData.GAME + " Team";

            if (FormData.GAME == "Rocket League") {
                this.BackgroundImage = Properties.Resources.rocket_league_sport;
                listBox1.Items.Add(RLRanks.Bronze.ToString());
                listBox1.Items.Add(RLRanks.Silver.ToString());
                listBox1.Items.Add(RLRanks.Gold.ToString());
                listBox1.Items.Add(RLRanks.Platinum.ToString());
                listBox1.Items.Add(RLRanks.Diamond.ToString());
                listBox1.Items.Add(RLRanks.Champion.ToString());
                listBox1.Items.Add(RLRanks.GC.ToString());
                listBox1.Items.Add(RLRanks.SSL.ToString());

            }
            else if(FormData.GAME == "CSGO"){
                this.BackgroundImage = Properties.Resources.cs_splash;
                listBox1.Items.Add(CSRanks.Silver.ToString());
                listBox1.Items.Add(CSRanks.GoldNova.ToString());
                listBox1.Items.Add(CSRanks.MasterGuardian.ToString());
                listBox1.Items.Add(CSRanks.DMG.ToString());
                listBox1.Items.Add(CSRanks.LEM.ToString());
                listBox1.Items.Add(CSRanks.SMFC.ToString());
                listBox1.Items.Add(CSRanks.GlobalElite.ToString());
            }
            else if (FormData.GAME == "League Of Legends")
            {
                this.BackgroundImage = Properties.Resources.league_splash;
                listBox1.Items.Add(LOLRanks.Iron.ToString());
                listBox1.Items.Add(LOLRanks.Bronze.ToString());
                listBox1.Items.Add(LOLRanks.Silver.ToString());
                listBox1.Items.Add(LOLRanks.Gold.ToString());
                listBox1.Items.Add(LOLRanks.Platinum.ToString());
                listBox1.Items.Add(LOLRanks.Diamond.ToString());
                listBox1.Items.Add(LOLRanks.Master.ToString());
                listBox1.Items.Add(LOLRanks.Grandmaster.ToString());
                listBox1.Items.Add(LOLRanks.Challenger.ToString());

            }
            else if (FormData.GAME == "Dota 2")
            {
                this.BackgroundImage = Properties.Resources.dota2_splash;
                listBox1.Items.Add(DotaRanks.Herald.ToString());
                listBox1.Items.Add(DotaRanks.Guardian.ToString());
                listBox1.Items.Add(DotaRanks.Crusader.ToString());
                listBox1.Items.Add(DotaRanks.Archon.ToString());
                listBox1.Items.Add(DotaRanks.Legend.ToString());
                listBox1.Items.Add(DotaRanks.Ancient.ToString());
                listBox1.Items.Add(DotaRanks.Divine.ToString());
            }
            else if (FormData.GAME == "Valorant")
            {
                this.BackgroundImage = Properties.Resources.val_splash;
                listBox1.Items.Add(ValRanks.Iron.ToString());
                listBox1.Items.Add(ValRanks.Bronze.ToString());
                listBox1.Items.Add(ValRanks.Silver.ToString());
                listBox1.Items.Add(ValRanks.Gold.ToString());
                listBox1.Items.Add(ValRanks.Platinum.ToString());
                listBox1.Items.Add(ValRanks.Diamond.ToString());
                listBox1.Items.Add(ValRanks.Immortal.ToString());
                listBox1.Items.Add(ValRanks.Radiant.ToString());
            }
            else if (FormData.GAME == "Overwatch")
            {
                this.BackgroundImage = Properties.Resources.ov_splash;
                listBox1.Items.Add(OWRanks.Bronze.ToString());
                listBox1.Items.Add(OWRanks.Silver.ToString());
                listBox1.Items.Add(OWRanks.Gold.ToString());
                listBox1.Items.Add(OWRanks.Platinum.ToString());
                listBox1.Items.Add(OWRanks.Diamond.ToString());
                listBox1.Items.Add(OWRanks.Master.ToString());
                listBox1.Items.Add(OWRanks.Grandmaster.ToString());
                listBox1.Items.Add(OWRanks.Top500.ToString());

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
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)//# Team Members
        {
            formData.slotsAvailable = int.Parse(textBox5.Text);
        }

        private void button1_Click(object sender, EventArgs e)//Submit button
        {
            if (clickedSubmit == false)
            {
                clickedSubmit = true;
                button1.Enabled = false;
                Random random = new Random();
                int uniqueID = random.Next(1, 100000);
                Database.PostDataToDB(FormData.GAME, uniqueID, formData);  
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FormData.GAME == "Rocket League")
            {
                formData.teamRank = Enum.Parse(typeof(RLRanks), listBox1.SelectedItem.ToString()).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            this.Hide();
            mm.ShowDialog();
            this.Close();
        }
    }
}
