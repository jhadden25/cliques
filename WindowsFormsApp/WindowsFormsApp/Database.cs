﻿using System;
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
    }
}