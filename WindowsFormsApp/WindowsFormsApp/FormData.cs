using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WindowsFormsApp
{
    public class FormData
    {
        public static string GAME { get; set; }
        public string ageLevel { get; set; }
        public string contact { get; set; }
        public string teamName { get; set; }
        public string teamRank { get; set; }
        public int currentRoster { get; set; }
        public int maxRoster { get; set; }

    }
}
