using FootballTables;

// Lists
List<League> leagues = new List<League>();
List<Club> clubs = new List<Club>();

// League Logger
Logger leagueLogger = new Logger(leagues);
Logger clubLogger = new Logger(clubs);

// Project Setup
if (File.Exists(@"setup.csv")) // if setup.csv exists
{
    // Reads setup.csv and prints League's List to console
    leagueLogger.readLeagueSetup();
    leagueLogger.printLeagueList();
}else if (!File.Exists(@"setup.csv")) // if !setup exists
{
    // Leagues
    League superLigaen = new League("Super Ligaen", 1, 0, 0, 0, 2);
    League nordicBetLigaen = new League("NordicBet Ligaen", 0, 2, 2, 2, 2);
    // Adds to leagues List
    leagues.Add(superLigaen);
    leagues.Add(nordicBetLigaen);
    // Writes leagues list into csv file
    leagueLogger.writeLeagueSetup();
    leagueLogger.printLeagueList();
    Console.WriteLine("setup.csv created");
}
if(File.Exists(@"teams.csv")) // if teams.csv exists
{
    // Reads teams.csv and prints to console
    clubLogger.readTeams();
    clubLogger.printClubList();
} else if (!File.Exists(@"teams.csv")) // if !teams.csv exists
{
    // Teams - superligaen
    Club fcn = new("F-C-N", "Football Club Nordsjaelland", 0, "unknown", "last", "pteam", "rteam");
    Club fcc = new("F-C-C", "Football Club Copenhagen", 0, "unknown", "last", "pteam", "rteam");
    Club vff = new("V-F-F", "Viborg Fodsports Forening", 0, "unknown", "last", "pteam", "rteam");
    Club agf = new("A-G-F", "Aarhus Gymnastikforening", 0, "unknown", "last", "pteam", "rteam");
    Club rfc = new("R-F-C", "Randers Football Club", 0, "unknown", "last", "pteam", "rteam");
    Club bif = new("B-I-F", "Brondbyenes Idraetsforening", 0, "unknown", "last", "pteam", "rteam");
    Club sif = new("S-I-F", "Silkeborg Idraetsforening", 0, "unknown", "last", "pteam", "rteam");
    Club fcm = new("F-C-M", "Football Club MidtjyllandDanish", 0, "unknown", "last", "pteam", "rteam");
    Club obk = new("O-B-K", "Odense Boldklub", 0, "unknown", "last", "pteam", "rteam");
    Club ach = new("A-C-H", "AC Horsens", 0, "unknown", "last", "pteam", "rteam");
    Club lbk = new("L-B-K", "Lyngby Boldklub", 0, "unknown", "last", "pteam", "rteam");
    Club abk = new("A-B-K", "Aalborg Boldklub", 0, "unknown", "last", "pteam", "rteam");
    clubs.Add(fcn);
    clubs.Add(fcc);
    clubs.Add(vff);
    clubs.Add(agf);
    clubs.Add(rfc);
    clubs.Add(bif);
    clubs.Add(sif);
    clubs.Add(fcm);
    clubs.Add(obk);
    clubs.Add(ach);
    clubs.Add(lbk);
    clubs.Add(abk);
    // Teams - nordicbetligaen
    Club vbk = new("V-B-K", "Vejle Boldklub", 0, "unknown", "last", "pteam", "rteam");
    Club hif = new("H-I-F", "Hvidovre Idraetsforening", 0, "unknown", "last", "pteam", "rteam");
    Club fch = new("F-C-H", "Football Club Helsingor", 0, "unknown", "last", "pteam", "rteam");
    Club sje = new("S-J-E", "Sonderjyske Fodbold", 0, "unknown", "last", "pteam", "rteam");
    Club vff1 = new("V-F-F", "Vendsyssel Forenede Fodboldklubber", 0, "unknown", "last", "pteam", "rteam");
    Club nbk = new("N-B-K", "Naestved Boldklub", 0, "unknown", "last", "pteam", "rteam");
    Club hfb = new("H-F-B", "Hillerod Fodbold", 0, "unknown", "last", "pteam", "rteam");
    Club hbk = new("H-B-K", "Herfolge Boldklub koge", 0, "unknown", "last", "pteam", "rteam");
    Club hik = new("H-I-K", "Hobro Idraets Klub", 0, "unknown", "last", "pteam", "rteam");
    Club bfa = new("B-F-A", "BK Fremad Amager", 0, "unknown", "last", "pteam", "rteam");
    Club fcf = new("F-C-F", "Football Club Fredericia", 0, "unknown", "last", "pteam", "rteam");
    Club nfc = new("N-F-C", "Nykobing Football Club", 0, "unknown", "last", "pteam", "rteam");
    clubs.Add(vbk);
    clubs.Add(hif);
    clubs.Add(fch);
    clubs.Add(sje);
    clubs.Add(vff1);
    clubs.Add(nbk);
    clubs.Add(hfb);
    clubs.Add(hbk);
    clubs.Add(hik);
    clubs.Add(bfa);
    clubs.Add(fcf);
    clubs.Add(nfc);
    // Writes club objects to teams.csv
    clubLogger.writeTeam();
    clubLogger.printClubList();
    Console.WriteLine("teams.csv created");
}