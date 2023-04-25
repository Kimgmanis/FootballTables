using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTables
{
    internal class CurrentStandings
    {
        public int tablePosition { get; set; }
        public string fullClubName { get; set; }
        public int gamesPlayed { get; set; }
        public int gamesWon { get; set; }
        public int gamesLost { get; set; }
        public int goalsFor { get; set; }
        public int goalsAgainst { get; set;}
        public int goalDifference { get; set; }
        public int points { get; set; }
        public string winningStreak { get; set; }

        public CurrentStandings(int tablePosition, string fullClubName, int gamesPlayed, int gamesWon, int gamesLost,
                                int goalsFor, int goalsAgainst, int goalDifference, int points, string winningStreak)
        {
            this.tablePosition = tablePosition;
            this.fullClubName = fullClubName;
            this.gamesPlayed = gamesPlayed;
            this.gamesWon = gamesWon;
            this.gamesLost = gamesLost;
            this.goalsFor = goalsFor;
            this.goalsAgainst = goalsAgainst;
            this.goalDifference = goalDifference;
            this.points = points;
            this.winningStreak = winningStreak;
        }

        // Prints current standings to console
        public void printCurrentStandings()
        {
            Console.WriteLine("Position in the table: ");
            Console.WriteLine("Abbreviation: ");
            Console.WriteLine("Full club name: ");
            Console.WriteLine("Games played: ");
            Console.WriteLine("Number of games won: ");
            Console.WriteLine("Number of games drawn: ");
            Console.WriteLine("Number of games lost: ");
            Console.WriteLine("Goals for: ");
            Console.WriteLine("Goals against: ");
            Console.WriteLine("Goal Difference: ");
            Console.WriteLine("Points achieved: ");
            Console.WriteLine("Current winning streak: ");
        }

        // round x processing
        public void roundx(string clubX, string clubY)
        {

        }
    }
}
