using CsvHelper.Configuration.Attributes;

namespace FootballTables
{
    internal class Club
    {
        [Index(0)]
        public String abbreviation { get; set; }
        [Index(1)]
        public String fullClubName { get; set; }
        [Index(2)]
        public int specialRanking { get; set; }
        [Index(3)]
        public String wChamp { get; set; } // Last years champion
        [Index(4)]
        public String cLast { get; set; } // Last years cup winner
        [Index(5)]
        public String pTeam { get; set; } // Promoted team
        [Index(6)]
        public String rTeam { get; set; } // Relegated team

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

        // Prints Club to console
        public void printClubInfo()
        {
            Console.WriteLine("Abbreviation: " + this.abbreviation);
            Console.WriteLine("Full Club name: " + this.fullClubName);
            Console.WriteLine("Special Ranking: " + this.specialRanking);
            Console.WriteLine("W-Last years champion: " + this.wChamp);
            Console.WriteLine("C-Last years cup winner: " + this.cLast);
            Console.WriteLine("P-Promoted team: " + this.pTeam);
            Console.WriteLine("R-Relegated team: " + this.rTeam + "\n");
        }
    }
}
