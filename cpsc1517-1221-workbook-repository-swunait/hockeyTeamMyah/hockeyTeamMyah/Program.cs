// See https://aka.ms/new-console-template for more information

using hockeyTeamMyah;

HockeyTeam Oilers = new(NhlConference.Western, NhlDivision.Pacific, "Oilers", "Edmonton" );
Oilers.GamesPlayed = 22;
Oilers.Wins = 12;
Oilers.Losses = 10;
Oilers.OvertimeLosses = 2;
Console.WriteLine(Oilers);
Console.WriteLine("Points: " + Oilers.Points);
Console.WriteLine();
//Oilers.String2();

//why use this. ?
//why set the # parameters to default 0?
//if there were multiple methods and you just Console.WriteLined(Oilers);, would all of the methods run?
