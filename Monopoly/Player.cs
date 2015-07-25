using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public enum Tokens { None, Battleship, Cannon, Car, Dog, Hat, Horse, Iron, Shoe, Thimble, Wheelbarrow };
    
    public class Player
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private Int16 _number;
        public Int16 Number
        {
            get { return _number; }
        }

        private Tokens _token;
        public Tokens Token
        {
            get { return _token; }
            set { _token = value; }
        }
        
        // Current location on the board
        private int _space;
        public int Space
        {
            get { return _space; }
            set { _space = value; }
        }

        private int _cash;
        public int Cash
        {
            get { return _cash; }
            set { _cash = value; }
        }

        public Player(string name, Int16 number)
        {
            _name = name;
            _number = number;
            _token = Tokens.None;
            _space = 0;
            _cash = 1500;
        }

        public string location (int boardSpace)
        {
            return boardSpace == _space ? String.Format("{0}", _number) : " ";
        }
    }
}
