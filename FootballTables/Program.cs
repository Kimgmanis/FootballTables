using FootballTables;

// List
List<League> leagues = new List<League>();

// League Logger
Logger leaguelogger = new Logger(leagues);

// Leagues
// League superLigaen = new League("Super Ligaen", 1, 0, 0, 0, 2);
// League nordicBetLigaen = new League("NordicBet Ligaen", 0, 2, 2, 2, 2);

// Adds to leagues List
// leagues.Add(superLigaen);
// leagues.Add(nordicBetLigaen);

leaguelogger.readLeagueSetup();

// Prints League's List in console
leaguelogger.printLeagueList();

// writes leagues list into csv file
// leaguelogger.writeLeagueSetup();


