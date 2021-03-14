using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using Firebase.Database.Query;
using Newtonsoft.Json;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        //Implement Label Assignment
        FirebaseClient firebase = new FirebaseClient("https://cliques-b6c58-default-rtdb.firebaseio.com/");
        public async void setLabels(string game)
        {
            var datas = await firebase.Child("Gaming").Child(game).OrderByKey().OnceAsync<FormData>();
            Label[] nameArray = new Label[] {Name1, Name2, Name3, Name4};
            Label[] ageArray = new Label[] {Age1, Age2, Age3, Age4 };
            Label[] slotsArray = new Label[] {Slots1, Slots2, Slots3, Slots4 };
            Label[] rankArray = new Label[] {Rank1, Rank2, Rank3, Rank4 };
            Label[] contactArray = new Label[] {Contact1, Contact2, Contact3, Contact4 };
            int i = 0;
            foreach (var DBdata in datas)
            {
                var jsonSerial = DBdata.Object;
                //Console.WriteLine($"{ DBdata.Key} is { jsonSerial.ageLevel }");
                nameArray[i].Text = jsonSerial.teamName;
                ageArray[i].Text = jsonSerial.ageLevel;
                contactArray[i].Text = jsonSerial.contact;
                rankArray[i].Text = jsonSerial.teamRank;
                slotsArray[i].Text = jsonSerial.slotsAvailable.ToString();
                i++;
            }
        }

        public Form1()
        {
            InitializeComponent();
            setLabels(FormData.GAME);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Age1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

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
