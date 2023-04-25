using FootballTables;

// List
List<League> leagues = new List<League>();
List<Club> clubs = new List<Club>();

// League Logger
Logger leagueLogger = new Logger(leagues);
Logger clubLogger = new Logger(clubs);

// Leagues
// League superLigaen = new League("Super Ligaen", 1, 0, 0, 0, 2);
// League nordicBetLigaen = new League("NordicBet Ligaen", 0, 2, 2, 2, 2);

// clubLogger.writeTeam();

// Adds to leagues List
// leagues.Add(superLigaen);
// leagues.Add(nordicBetLigaen);

// writes leagues list into csv file
// leaguelogger.writeLeagueSetup();

// Reads setup.csv
leagueLogger.readLeagueSetup();

// Prints League's List in console
leagueLogger.printLeagueList();

// Teams
Club club1 = new("abbreviation", "club1", 0, "unknown", "last", "pteam", "rteam");
Club FCN = new("F-C-N", "FC Nordsjaelland", 0, "unknown", "last", "pteam", "rteam");

clubs.Add(club1);

clubLogger.printClubList();