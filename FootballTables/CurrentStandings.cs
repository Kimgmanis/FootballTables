using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FootballTables
{
    internal class CurrentStandings
    {
        // Lists
        private List<Club> clubs1 = new List<Club>();
        private List<CurrentStandings> currentStandings = new List<CurrentStandings>();

        public int TablePosition { get; set; }
        public string Abbreviation { get; set; }
        public string FullClubName { get; set; }
        public int GamesPlayed { get; set; }
        public int GamesWon { get; set; }
        public int GamesDrawn { get; set; }
        public int GamesLost { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        public int GoalDifference { get; set; }
        public int Points { get; set; }
        public string WinningStreak { get; set; }

        public CurrentStandings(int tablePosition, string abbreviation, string fullClubName, int gamesPlayed, int gamesWon, int gamesDrawn, int gamesLost,
                                int goalsFor, int goalsAgainst, int goalDifference, int points, string winningStreak)
        {
            this.TablePosition = tablePosition;
            this.Abbreviation = abbreviation;
            this.FullClubName = fullClubName;
            this.GamesPlayed = gamesPlayed;
            this.GamesWon = gamesWon;
            this.GamesDrawn = gamesDrawn;
            this.GamesLost = gamesLost;
            this.GoalsFor = goalsFor;
            this.GoalsAgainst = goalsAgainst;
            this.GoalDifference = goalDifference;
            this.Points = points;
            this.WinningStreak = winningStreak;
        }
        public CurrentStandings(Club club)
        {
            this.TablePosition = TablePosition;
            this.Abbreviation = club.abbreviation;
            this.FullClubName = club.fullClubName;
            this.GamesPlayed = GamesPlayed;
            this.GamesWon = GamesWon;
            this.GamesDrawn = GamesDrawn;
            this.GamesLost = GamesLost;
            this.GoalsFor = GoalsFor;
            this.GoalsAgainst = GoalsAgainst;
            this.GoalDifference = GoalDifference;
            this.Points = Points;
            this.WinningStreak = WinningStreak;
        }
        public CurrentStandings(){}

        // Prints current standings to console
        public void PrintCurrentStanding()
        {
            Console.WriteLine("Position in the table: " + this.TablePosition);
            Console.WriteLine("Abbreviation: " + this.Abbreviation);
            Console.WriteLine("Full club name: " + this.FullClubName);
            Console.WriteLine("Games played: " + this.GamesPlayed);
            Console.WriteLine("Number of games won: " + this.GamesWon);
            Console.WriteLine("Number of games drawn: " + this.GamesDrawn);
            Console.WriteLine("Number of games lost: " + this.GamesLost);
            Console.WriteLine("Goals for: " + this.GoalsFor);
            Console.WriteLine("Goals against: " + this.GoalsAgainst);
            Console.WriteLine("Goal Difference: " + this.GoalDifference);
            Console.WriteLine("Points achieved: " + this.Points);
            Console.WriteLine("Current winning streak: " + this.WinningStreak);
        }


        public void AddClubsToCurrentStandings(List<Club> club)
        {
            // loops through every club object in List
            for(int i = 0; i < club.Count; i++)
            {
                CurrentStandings standings = new CurrentStandings(club[i]); // converts Club.cs type to CurrentStanding.cs object type
                currentStandings.Add(standings); // adds converted Club object to currentStandings List
            }
        }

        public void SortByPoints()
        {
            currentStandings = currentStandings.OrderByDescending(x => x.Points).ToList();
        }
        public void SortByGoalDifference()
        {
            currentStandings = currentStandings.OrderByDescending(x => x.GoalDifference).ToList();
        }
        public void SortByGoalsFor()
        {
            currentStandings = currentStandings.OrderByDescending(x => x.GoalsFor).ToList();
        }
        public void SortByGoalsAgainst()
        {
            currentStandings = currentStandings.OrderBy(x => x.GoalsAgainst).ToList();
        }

        public void SortAlphabetically()
        {
            currentStandings = currentStandings.OrderBy(x => x.FullClubName).ToList();
        }

        public void PrintCurrentStandings()
        {
            var table = new ConsoleTable("#", "Abbreviation", "Full Club Name", "Game Played",
                "W", "D", "L", "Goal For", "Goal Against", "Goal Difference", "Total Points", "Streak");
            foreach(var currentStandings in currentStandings)
            {
                /*
                // Calculate remaining stats based on club data
                int gp = currentStandings.GamesWon + currentStandings.GamesLost;
                int gd = currentStandings.GoalsFor - currentStandings.GoalsAgainst;
                int pts = currentStandings.GamesWon * 3;*/

                table.AddRow(currentStandings.TablePosition, currentStandings.Abbreviation, currentStandings.FullClubName, currentStandings.GamesPlayed,
                    currentStandings.GamesWon, currentStandings.GamesDrawn, currentStandings.GamesLost, currentStandings.GoalsFor, currentStandings.GoalsAgainst,
                    currentStandings.GoalDifference, currentStandings.Points, currentStandings.WinningStreak);
            }
            table.Write(Format.Default);
        }
    }
}
