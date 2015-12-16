using System;
using System.Collections.Generic;
using static System.Console;

namespace Monopoly
{
    public enum Tokens { None, Battleship, Cannon, Car, Dog, Hat, Horse, Iron, Shoe, Thimble, Wheelbarrow };
    
    public class Player
    {
        public string Name { get; private set; }
        public short Number { get; private set; }
        public Tokens Token { get; private set; } = Tokens.None;
        public int Space { get; } = 0;                  // Current location on the board
        public int Cash { get; } = 1500;

        public Player(string name, short number)
        {
            Name = name;
            Number = number;
        }

        public string location (int boardSpace)
        {
            return boardSpace == Space ? String.Format("{0}", Number) : " ";
        }

        public void readName()
        {
            Write("{0}, what's your name: ", Name);
            Name = ReadLine();
        }

        public void readToken(List<Player> players)
        {
            WriteLine("These tokens are available: {0}", availableTokens(players));
            Write("{0}, which would you like: ", Name);
            Token = (Tokens)Enum.Parse(typeof(Tokens), ReadLine());
        }

        private static string availableTokens(List<Player> players)
        {
            string tokensLeft = "";
            Int16[] available = new Int16[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (Player p in players)
                available[(int)p.Token] = 0;

            for (int i = 1; i <= 10; i++)
                if (available[i] > 0)
                    tokensLeft += String.Format("{0}, ", (Tokens)i);

            tokensLeft = tokensLeft.Remove(tokensLeft.Length - 2);
            return tokensLeft;
        }
    }
}
