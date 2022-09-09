using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPReview1
{
   public class Roster
    {
        private const int MinNo = 0;
        private const int MaxNo = 98;

        public int _number;

        public int Number
        {
            get { return _number; }
            set 
            { 
               if (value < MinNo || value > MaxNo)
                {
                    throw new ArgumentOutOfRangeException($"Player number must be greater than {MinNo} and less than {MaxNo}");
                }
                _number = value; 
            }
        }

        public string _playerName;

        public string PlayerName
        {
            get => _playerName; 
            set 
            { 
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The name mut contain text");
                }
                _playerName = value.Trim();
            }
        }

        public Position Position { get; set; }
        

        public Roster(Position position, int number, string playerName)
        {
            Position = position;
            Number = number;
            PlayerName = playerName;
        }

        public override string ToString()
        {
            return $"{Number}, {PlayerName}, {Position}";
        }
        
    }
}
