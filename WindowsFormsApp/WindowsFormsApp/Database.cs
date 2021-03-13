using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Firebase;
using Firebase.Database;
using Firebase.Database.Query;

namespace WindowsFormsApp
{
    class Database
    {
        FirebaseClient firebase = new FirebaseClient("https://cliques-b6c58-default-rtdb.firebaseio.com/");
        HttpClient client = new HttpClient();
        await firebase.Child("Hello").Child("World").PutAsync("and Scott");

    }
}
