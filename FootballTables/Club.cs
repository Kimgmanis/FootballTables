using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTables
{
    internal class Club
    {
        public String abbreviation { get; set; }
        public String fullClubName { get; set; }
        public int specialRanking { get; set; }
        public String wChamp { get; set; }
        public String cLast { get; set; }
        public String pTeam { get; set; }
        public String rTeam { get; set; }

        public Club(String abbreviation, String fullClubName, int specialRanking, string wChamp, string cLast, String pTeam, String rTeam) 
        {
            this.abbreviation = abbreviation;
            this.fullClubName = fullClubName;
            this.specialRanking = specialRanking;
            this.wChamp = wChamp;
            this.cLast = cLast;
            this.pTeam = pTeam;
            this.rTeam = rTeam;
        }

        public void PrintClubInfo()
        {
            Console.WriteLine("Abbreviation: " + this.abbreviation);
            Console.WriteLine("Full Club name: " + this.fullClubName);
            Console.WriteLine("Special Ranking: " + this.specialRanking);
            Console.WriteLine("W-Last years champion: " + this.wChamp);
            Console.WriteLine("C-Last years cup winner: " + this.cLast);
            Console.WriteLine("P-Promoted team: " + this.pTeam);
            Console.WriteLine("R-Relegated team: " + this.pTeam);
        }
    }
}
