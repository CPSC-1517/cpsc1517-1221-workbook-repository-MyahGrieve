using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hockeyTeamMyah
{
    public class Roster
    {
        //playernumber, name, position

        //fields and properties
        public Position Position { get; private set; }

        public int _playerNumber;

        public int PlayerNumber
        {
            get { return _playerNumber; }
            set
            { 
                if (_playerNumber < 0 || _playerNumber > 98)
                {
                    throw new ArgumentOutOfRangeException("The player number must be between 0 and 98");
                }
                _playerNumber = value; 
            }
        }

        public string _playerName;

        public string PlayerName
        {
            get { return _playerName; }
            set 
            {   if (string.IsNullOrEmpty(_playerName))
                {
                    throw new ArgumentNullException("must have a value here bro");
                }
                _playerName = value.Trim(); 
            }
        }

        public Roster (Position position, int playerNumber, string playerName)
        {
            Position = position;
            PlayerNumber = playerNumber;
            PlayerName = playerName;
        }

        public override string ToString()
        {
            return $"{Position},{PlayerNumber},{PlayerName}";
        }
    }
}
