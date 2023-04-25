﻿using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.IO;


namespace FootballTables
{
    internal class Logger
    {
        // var List
        List<League> leagues;
        List<Club> clubs;

        // League type Logger Constructor
        public Logger(List<League> leagues)
        {
            this.leagues = leagues;
        }
        public Logger(List<Club> clubs)
        {
            this.clubs = clubs;
        }

        // Reads league list data from setup.csv
        public void readLeagueSetup() 
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
            };
            StreamReader readerSetup = new StreamReader(@"test/setup.csv");
            CsvReader csv = new CsvReader(readerSetup, config);
            {
                csv.Read();
                while (csv.Read())
                {
                    var records = csv.GetRecord<League>();
                    leagues.Add(records);
                }
                csv.Dispose();
            }
        }
        
        // Reads league list data from teams.csv
        public void readTeams() 
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
            };
            StreamReader readerSetup = new StreamReader(@"test/teams.csv");
            CsvReader csv = new CsvReader(readerSetup, config);
            {
                csv.Read();
                while (csv.Read())
                {
                    var records = csv.GetRecord<Club>();
                    clubs.Add(records);
                }
                csv.Dispose();
            }
        }

        // Writes League List data to setup.csv
        public void writeLeagueSetup()
        {
                // Write to setup.csv
                StreamWriter writerSetup = new StreamWriter(@"test/setup.csv");
                CsvWriter csv = new CsvWriter(writerSetup, CultureInfo.InvariantCulture);
                {
                    csv.WriteRecords(leagues);
                    csv.Flush(); // Data is written from the writer buffer to the stream.
                }
        }
        
        // Writes Club list data to teams.csv
        public void writeTeam()
        {
            // Write to teams.csv
            StreamWriter writerSetup = new StreamWriter(@"test/teams.csv");
            CsvWriter csv = new CsvWriter(writerSetup, CultureInfo.InvariantCulture);
            {
                csv.WriteRecords(clubs);
                csv.Flush(); // Data is written from the writer buffer to the stream.
            }
        }

        /* untested
        // Updates the League List in setup.csv
        public void updateLeagueSetup() 
        {
            // Append to the file.
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                // Don't write the header again.
                HasHeaderRecord = false,
            };
            using (var stream = File.Open("test/setup.csv", FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, config))
            {
                csv.WriteRecords(leagues);
                csv.Flush();
            }
        } */

        // Prints League's in list
        public void printLeagueList()
        {
            for (int i = 0; i < leagues.Count; i++)
            {
                var league = leagues[i];
                league.printLeagueInfo();
            }
        }
        
        // Prints Club's in list
        public void printClubList()
        {
            for (int i = 0; i < clubs.Count; i++)
            {
                var club = clubs[i];
                club.printClubInfo();
            }
        }

        // round x processing
        public void roundx()
        {

        }

    }
}
