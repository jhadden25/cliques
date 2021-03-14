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
            formData = new FormData();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = 
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
