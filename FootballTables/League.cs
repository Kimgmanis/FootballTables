using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTables
{
    internal class League
    {
        public String leagueName { get; set; }
        public int numOfPosChampionsLeague { get; set; }
        public int numOfPosEuLeague { get; set; }
        public int numOfPosConfLeague { get; set; }
        public int numOfPosUpperLeague { get; set; }
        public int numOfPosLowerLeague { get; set; }

        public League(String leagueName, int numOfPosChampionsLeague, int numOfPosEuLeague, int numOfPosConfLeague, int numOfPosUpperLeague, int numOfPosLowerLeague)
        {
            this.leagueName = leagueName;
            this.numOfPosChampionsLeague = numOfPosChampionsLeague;
            this.numOfPosEuLeague = numOfPosEuLeague;
            this.numOfPosConfLeague = numOfPosConfLeague;
            this.numOfPosUpperLeague = numOfPosUpperLeague;
            this.numOfPosLowerLeague = numOfPosLowerLeague;
        }

        public void printLeagueInfo()
        {
            Console.WriteLine("League Name: " + this.leagueName);
            Console.WriteLine("Number of positions to promote to Champions League: " + this.numOfPosChampionsLeague);
            Console.WriteLine("Number of positions to promote to Europe League: " + this.numOfPosEuLeague);
            Console.WriteLine("Number of positions to promote to Conference League: " + this.numOfPosConfLeague);
            Console.WriteLine("Number of positions to promote to Upper League: " + this.numOfPosUpperLeague);
            Console.WriteLine("Number of positions to promote to Lower League: " + this.numOfPosLowerLeague + "\n");
        }
    }
}
