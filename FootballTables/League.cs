using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTables
{
    internal class League
    {
        [Index(0)]
        public String leagueName { get; set; }
        [Index(1)]
        public int numOfPosChampionsLeague { get; set; }
        [Index(2)]
        public int numOfPosEuLeague { get; set; }
        [Index(3)]
        public int numOfPosConfLeague { get; set; }
        [Index(4)]
        public int numOfPosUpperLeague { get; set; }
        [Index(5)]
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

        // Prints League
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
