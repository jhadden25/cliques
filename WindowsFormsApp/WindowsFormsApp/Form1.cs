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
using Ranks;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        //Implement Label Assignment
        FirebaseClient firebase = new FirebaseClient("https://cliques-b6c58-default-rtdb.firebaseio.com/");
        static void bubbleSort(FormData[] arr, string game)
        {
            
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    object rank1 = 0;
                    object rank2 = 1;
                    if (game == "Rocket League")
                    {
                        rank1 = Enum.Parse(typeof(RLRanks), arr[j].teamRank);
                        rank2 = Enum.Parse(typeof(RLRanks), arr[j + 1].teamRank);
                    }
                    else if (game == "CSGO")
                    {
                        rank1 = Enum.Parse(typeof(CSRanks), arr[j].teamRank);
                        rank2 = Enum.Parse(typeof(CSRanks), arr[j + 1].teamRank);
                    }else if (game == "League Of Legends")
                    {
                        rank1 = Enum.Parse(typeof(LOLRanks), arr[j].teamRank);
                        rank2 = Enum.Parse(typeof(LOLRanks), arr[j + 1].teamRank);
                    }else if (game == "Dota 2")
                    {
                        rank1 = Enum.Parse(typeof(DotaRanks), arr[j].teamRank);
                        rank2 = Enum.Parse(typeof(DotaRanks), arr[j + 1].teamRank);
                    }else if (game == "Valorant")
                    {
                        rank1 = Enum.Parse(typeof(ValRanks), arr[j].teamRank);
                        rank2 = Enum.Parse(typeof(ValRanks), arr[j + 1].teamRank);
                    }else if (game == "Overwatch")
                    {
                        rank1 = Enum.Parse(typeof(OWRanks), arr[j].teamRank);
                        rank2 = Enum.Parse(typeof(OWRanks), arr[j + 1].teamRank);
                    }
                    if ((int)rank1 > (int)rank2)
                    {
                        // swap temp and arr[i] 
                        FormData temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        public async void setLabels(string game)
        {
            var datas = await firebase.Child("Gaming").Child(game).OrderByKey().OnceAsync<FormData>();
            Label[] nameArray = new Label[] {Name1, Name2, Name3, Name4};
            Label[] ageArray = new Label[] {Age1, Age2, Age3, Age4 };
            Label[] slotsArray = new Label[] {Slots1, Slots2, Slots3, Slots4 };
            Label[] rankArray = new Label[] {Rank1, Rank2, Rank3, Rank4 };
            Label[] contactArray = new Label[] {Contact1, Contact2, Contact3, Contact4 };
            FormData[] TeamSheet = new FormData[4];

            
            int i = 0;
            int numTeams = 0;
            foreach (var DBdata in datas)
            {
                var jsonSerial = DBdata.Object;
                TeamSheet[i] = jsonSerial;

                if (DBdata.Object.teamName.ToString().Length > 1)
                    numTeams++;
                i++;
            }

            if (numTeams == 4)
            {
                bubbleSort(TeamSheet, FormData.GAME);
            }



                for (int j = 0; j < numTeams; j++)
                {

                    //Console.WriteLine($"{ DBdata.Key} is { jsonSerial.ageLevel }");
                    nameArray[j].Text = TeamSheet[j].teamName;
                    ageArray[j].Text = TeamSheet[j].ageLevel;
                    contactArray[j].Text = TeamSheet[j].contact;
                    rankArray[j].Text = TeamSheet[j].teamRank.ToString();
                    slotsArray[j].Text = TeamSheet[j].slotsAvailable.ToString();
                }
            numTeams = 0;
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
