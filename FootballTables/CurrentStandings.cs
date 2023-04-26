using System;
using System.Collections.Generic;
using System.Linq;
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
        public void printCurrentStandings()
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

        public void AddClub(List<Club> club)
        {
            for(int i = 0; i < club.Count; i++)
            {
                CurrentStandings standings = new CurrentStandings(club[i]);
                standings.printCurrentStandings();
                // standings.Add(club[i]);
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

        public void DisplayTable()
        {
            Console.WriteLine("Club\t\tPoints\tGD\tGF\tGA");

            foreach (var currentStandings in currentStandings)
            {
                Console.WriteLine($"{currentStandings.FullClubName}\t\t{currentStandings.Points}\t{currentStandings.GoalDifference}\t{currentStandings.GoalsFor}\t{currentStandings.GoalsAgainst}");
            }
        }

    }
}
