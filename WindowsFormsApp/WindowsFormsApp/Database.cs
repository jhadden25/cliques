using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Firebase;
using Firebase.Database;
using Firebase.Database.Query;
using Newtonsoft.Json;

namespace WindowsFormsApp
{
    class Database
    {
        static readonly FirebaseClient firebase = new FirebaseClient("https://cliques-b6c58-default-rtdb.firebaseio.com/");

        public static async void PostDataToDB(string game, string key, string data)
        {
            dynamic jsonObj = JsonConvert.SerializeObject(data);
            await firebase.Child("Gaming").Child(game).Child(key).PutAsync(jsonObj);
        }

        public static async void PostDataToDB(string game, int uID, FormData fd)
        {
            dynamic jsonObj = JsonConvert.SerializeObject(fd);
            await firebase.Child("Gaming").Child(game).Child(uID.ToString()).PutAsync(jsonObj);
        }

        public static async void GetFromDB(string game)
        {
            var datas = await firebase.Child("Gaming").Child(game).OrderByKey().OnceAsync<FormData>();

            foreach (var DBdata in datas)
            {
                var jsonSerial = DBdata.Object;
                Console.WriteLine($"{ DBdata.Key} is { jsonSerial.ageLevel }");
            }
        }
    }

}
