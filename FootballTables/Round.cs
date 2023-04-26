
using CsvHelper.Configuration.Attributes;

namespace FootballTables
{
    internal class Round
    {
        [Index(0)]
        public Club ClubX { get; set; }
        [Index(1)]
        public int ScoreX { get; set; }
        [Index(2)]
        public Club ClubY { get; set; }
        [Index(3)]
        public int ScoreY { get; set; }

        public Round(Club clubX, int scoreX , Club clubY, int scoreY)
        {
            ClubX = clubX;
            ScoreX = scoreX;
            ClubY = clubY;
            ScoreY = scoreY;
        }
    }
}
