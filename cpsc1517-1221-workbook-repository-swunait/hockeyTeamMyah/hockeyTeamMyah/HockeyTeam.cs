using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace hockeyTeamMyah
{
    // enums:
    //divison
    //conference

    //white space/null:
    // team name
    //city

    //assign default value?
    //games played
    //wins
    //losses
    // overtime losses
    public class HockeyTeam
    {
        //fields & properties

        public NhlConference _conference { get; private set; }
        public NhlDivision _division { get; private set; }

        private string _teamName;

        public string TeamName
        {
            get { return _teamName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name must contain text.");
                }

                _teamName = value.Trim();
            }
        }

        private string _city;

        public string City
        {
            get { return _city; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("City must contain text.");
                }
                _city = value.Trim();
            }
        }


        private int _gamesPlayed;

        public int GamesPlayed
        {
            get { return _gamesPlayed; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Games Played must be >= 0.");
                }
                _gamesPlayed = value;
            }
        }


        private int _wins;

        public int Wins
        {
            get { return _wins; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Wins cannot be >= 0");
                }
                _wins = value;
            }
        }

        private int _losses;

        public int Losses
        {
            get { return _losses; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Losses cannot be >= 0");
                }
                _losses = value;
            }
        }

        private int _overtimeLosses;

        public int OvertimeLosses
        {
            get { return _overtimeLosses; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Wins cannot be >= 0");
                }
                _overtimeLosses = value;
            }
        }

        public int Points
        {
            get { return (Wins * 2) + OvertimeLosses; }

        }

        public Position Position { get; private set; }

        public List<Roster> Players { get; private set; }

        private const int MaxNumber = 23;
        public void AddPlayer(Roster currentPlayer) // voud cux doesnt return anything, Roster/list is the "data type:, currntPlayer is new value
        {
            if (Players.Count > MaxNumber)
            {
                throw new Exception("There is the max amoutn of players on the team. Remove player ad then try again");
            }
            Players.Add(currentPlayer); // add current player
        }

        public void RemovePlayer(int number)
        {
            bool foundPlayer = false; // assign false for the if statement below
            int playerIndex = -1; // assign -1 for the RemoveAt method, so that if it removes a player without finding it its not a plyer that exists
                                  // since theres no player at -1

            
            for (int index = 0; index <= Players.Count; index++) // stops when index is >= the amount of players to exit the loop
            {

                if (Players[index].PlayerNumber == number) // if the index of Players.PlayerNumber equals the nmumber passes in, aka player is found
                {
                    foundPlayer = true; // to avoid the next if statement
                    playerIndex = index; // asssign playerIndex to Index so that playerIndex can be accessed outside of the for loop
                    index = Players.Count; // ends th loop because index cannot be >= player count
                }            
                
            }
            if (!foundPlayer)
            {
                throw new ArgumentException("The player at the index you entered does not exist");
            }
            Players.RemoveAt(playerIndex); // can finally remove the player! :-)
        }




        //constructors

        /* For Lists:
         * -one first, if else to enure list isn't empty, if not empty then pass in 
         * -one normal underneath, list is empty and no argument passed in for it
         */
        public HockeyTeam(NhlConference conference, NhlDivision division, string teamName, string city, List<Roster> players)
        {
            if(players == null)
            {
                players = new List<Roster>(); // instantiating new list with thse passed in values for players
            }
            else
            {
                Players = players; // if players already exists, then assigning Players the values passed in for players
            }
            _conference = conference;
            _division = division;
            _teamName = teamName;
            _city = city;

            _gamesPlayed = 0;
            _wins = 0;
            _losses = 0;
            _overtimeLosses = 0;
        }

        public HockeyTeam(NhlConference conference, NhlDivision division, string teamName, string city) // no argument
        {
            _conference = conference;
            _division = division;
            _teamName = teamName;
            _city = city;
            Players = new List<Roster>(); // empty list

            _gamesPlayed = 0;
            _wins = 0;  
            _losses = 0;
            _overtimeLosses = 0;
        }

        //methods

        public override string ToString()
        {
            return String.Format($"Conference: {_conference}\nDivision: {_division}\nTeam: {_teamName}\nCity: {_city}\n Games Played: {_gamesPlayed}\nWins: {_wins}\nLosses: {_losses}\nOvertime Losses: {_overtimeLosses}");
        }

        /*
        public int Points2()
        {
            return (Wins *2) + OvertimeLosses;
        }
        */
        
        /*
        public void String2()
        {
            Console.WriteLine($"Conference: {_conference}\nDivision: {_division}\nTeam: {_teamName}\nCity: {_city}\n Games Played: {_gamesPlayed}\nWins: {_wins}\nLosses: {_losses}\nOvertime Losses: {_overtimeLosses}");
        }
        */



    }
}
