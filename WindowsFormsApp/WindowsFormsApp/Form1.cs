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
            int i = 0;
            foreach (var DBdata in datas)
            {
                var jsonSerial = DBdata.Object;
                //Console.WriteLine($"{ DBdata.Key} is { jsonSerial.ageLevel }");
                nameArray[i].Text = jsonSerial.teamName;
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
    }
}
