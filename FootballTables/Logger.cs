using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FootballTables
{
    internal class Logger
    {
        // var List
        List<League> leagues;

        // League type Logger Constructor
        public Logger(List<League> leagues)
        {
            this.leagues = leagues;
        }

        // Reads league list data from setup.csv
        public void readLeagueSetup() 
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
            };
            StreamReader readerSetup = new StreamReader("setup.csv");
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

        // Writes league list data to setup.csv
        public void writeLeagueSetup()
        {
            // Write to a file.
            StreamWriter writerSetup = new StreamWriter("setup.csv");
            CsvWriter csv = new CsvWriter(writerSetup, CultureInfo.InvariantCulture);
            {
                csv.WriteRecords(leagues);
                csv.Flush(); // Data is written from the writer buffer to the stream.
            }
        }

        // Updates the League List in setup.csv
        public void updateLeagueSetup() 
        {
            // Append to the file.
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                // Don't write the header again.
                HasHeaderRecord = false,
            };
            using (var stream = File.Open("setup.csv", FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, config))
            {
                csv.WriteRecords(leagues);
                csv.Flush();
            }
        }

        // Prints League's in list
        public void printLeagueList()
        {
            for (int i = 0; i < leagues.Count; i++)
            {
                var league = leagues[i];
                league.printLeagueInfo();
            }
        }
    }
}
