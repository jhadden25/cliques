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
        FirebaseClient firebase = new FirebaseClient("https://cliques-b6c58-default-rtdb.firebaseio.com/");

        public async void PostDataToDB(string key, string data)
        {
            dynamic jsonObj = JsonConvert.SerializeObject(data);
            await firebase.Child("Gaming").Child(key).PutAsync(jsonObj);
        }

        public async void GetFromDB()
        {
            var datas = await firebase.Child("Gaming").Child("Rocket League").OrderByKey().OnceAsync<FormData>();

            foreach (var DBdata in datas)
            {
                var jsonSerial = DBdata.Object;
                Console.WriteLine($"{ DBdata.Key} is { jsonSerial.ageLevel }");
            }
        }
    }

}
