﻿using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.IO;


namespace FootballTables
{
    internal class Logger
    {
        // var List
        public List<League> leagues;
        public List<Club> clubs;
        public List<Round> Rounds;

        // League type Logger Constructor
        public Logger(List<League> leagues)
        {
            this.leagues = leagues;
        }
        public Logger(List<Club> clubs)
        {
            this.clubs = clubs;
        }
        public Logger(List<Round> rounds)
        {
            this.Rounds = rounds;
        }

        // Csv Configuration
        CsvConfiguration configH = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HasHeaderRecord = false,
        };
        CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {

        };

        // Reads league list data from setup.csv
        public void readLeagueSetup() 
        {
            // StreamReader
            StreamReader readerSetup = new StreamReader(@"test/setup.csv");
            // Csv Reader
            CsvReader csv = new CsvReader(readerSetup, configH);
            {
                csv.Read();
                while (csv.Read())
                {
                    var records = csv.GetRecord<League>();
                    leagues.Add(records);
                }
                csv.Dispose();
                readerSetup.Close();
            }
        }
        
        // Reads league list data from teams.csv
        public void readTeams() 
        {
            // StreamReader
            StreamReader readerTeams = new StreamReader(@"test/teams.csv");
            // Csv reader
            CsvReader csv = new CsvReader(readerTeams, configH);
            {
                csv.Read();
                while (csv.Read())
                {
                    var records = csv.GetRecord<Club>();
                    clubs.Add(records);
                }
                csv.Dispose();
                readerTeams.Dispose();
            }
        }
        
        // Reads round1.csv
        public void readRound1() 
        {
            // StreamReader
            StreamReader readerRounds = new StreamReader(@"test/round1.csv");
            // Csv reader
            CsvReader csv = new CsvReader(readerRounds, configH);
            {
                csv.Read();
                while (csv.Read())
                {
                    var records = csv.GetRecord<Round>();
                    Rounds.Add(records);
                }
                csv.Dispose();
                readerRounds.Dispose();
            }
        }
        public void readRound2() 
        {
            // StreamReader
            StreamReader readerRounds = new StreamReader(@"test/round2.csv");
            // Csv reader
            CsvReader csv = new CsvReader(readerRounds, configH);
            {
                csv.Read();
                while (csv.Read())
                {
                    var records = csv.GetRecord<Round>();
                    Rounds.Add(records);
                }
                csv.Dispose();
                readerRounds.Dispose();
            }
        }

        // Writes League List data to setup.csv
        public void writeLeagueSetup()
        {
            // Write to setup.csv
            // StreamWriter
            StreamWriter writerSetup = new StreamWriter(@"test/setup.csv");
            CsvWriter csv = new CsvWriter(writerSetup, config);
                {
                    csv.WriteRecords(leagues);
                    csv.Flush(); // Data is written from the writer buffer to the stream.
                    writerSetup.Close();
                }
        }
        
        // Writes Club list data to teams.csv
        public void writeTeam()
        {
            // Write to teams.csv
            StreamWriter writerTeams = new StreamWriter(@"test/teams.csv");
            CsvWriter csv = new CsvWriter(writerTeams, config);
            {
                csv.WriteRecords(clubs);
                csv.Flush(); // Data is written from the writer buffer to the stream.
                writerTeams.Close();
            }
        }
        
        // Writes Round list data to round.csv
        public void writeRound1()
        {
            // Write to Round.csv
            StreamWriter writerRounds = new StreamWriter(@"test/round1.csv");
            CsvWriter csv = new CsvWriter(writerRounds, config);
            {
                csv.WriteRecords(Rounds);
                csv.Flush(); // Data is written from the writer buffer to the stream.
                writerRounds.Close();
            }
        }
        public void writeRound2()
        {
            // Write to Round.csv
            StreamWriter writerRounds = new StreamWriter(@"test/round2.csv");
            CsvWriter csv = new CsvWriter(writerRounds, config);
            {
                csv.WriteRecords(Rounds);
                csv.Flush(); // Data is written from the writer buffer to the stream.
                writerRounds.Close();
            }
        }

        // Prints League's in list to Console
        public void printLeagueList()
        {
            for (int i = 0; i < leagues.Count; i++)
            {
                var league = leagues[i];
                league.printLeagueInfo();
            }
        }
        
        // Prints Club's in list to Console
        public void printClubList()
        {
            for (int i = 0; i < clubs.Count; i++)
            {
                var club = clubs[i];
                club.printClubInfo();
            }
        }

        public void roundStart()
        {
            // checks if rounds already exist
            if (!File.Exists("@test/round1.csv"))
            {
                // Creates round#.csv
                string directoryPath = @"test";
                for (var i = 0; i < 2; i++)
                {
                    int fileNumber = +1;
                    string fileName = "round" + fileNumber.ToString() + ".csv";
                    string filePath = Path.Combine(directoryPath, fileName);
                    File.Create(filePath).Close();
                }
            }
        }
    }
}
