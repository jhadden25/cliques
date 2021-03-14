using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Ranks
{
    public enum RLRanks
    {
        Bronze = 0,
        Silver = 1,
        Gold = 2,
        Platinum = 3,
        Diamond = 4,
        Champion = 5,
        GC = 6,
        SSL = 7
    }
    public enum CSRanks
    {
        Silver = 0,
        GoldNova = 1,
        MasterGuardian = 2,
        DMG = 3,
        LEM = 4,
        SMFC = 5,
        GlobalElite = 6
    }
    public enum LOLRanks
    {
        Iron = 0,
        Bronze = 1,
        Silver = 2,
        Gold = 3,
        Platinum = 4,
        Diamond = 5,
        Master = 6,
        Grandmaster = 7,
        Challenger = 8
    }
    public enum DotaRanks
    {
        Herald = 0,
        Guardian = 1,
        Crusader = 2,
        Archon = 3,
        Legend = 4,
        Ancient = 5,
        Divine = 6,
    }
    public enum ValRanks
    {
        Iron = 0,
        Bronze = 1,
        Silver = 2,
        Gold = 3,
        Platinum = 4,
        Diamond = 5,
        Immortal = 6,
        Radiant = 7
    }
    public enum OWRanks
    {
        Bronze = 1,
        Silver = 2,
        Gold = 3,
        Platinum = 4,
        Diamond = 5,
        Master = 6,
        Grandmaster = 7,
        Top500 = 8
    }
}
namespace WindowsFormsApp
{
    
    public class FormData
    {
        
        public static string GAME { get; set; }
        public string ageLevel { get; set; }
        public string contact { get; set; }
        public string teamName { get; set; }
        public string teamRank { get; set; }
        public int slotsAvailable { get; set; }

    }
}
