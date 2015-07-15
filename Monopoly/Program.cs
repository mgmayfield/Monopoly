using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            Board playingBoard = new Board();
            List<Player> players = newPlayers();
            Int16 numberOfPlayers;

            Console.WriteLine("Welcome to Monopoly!");
            Console.Write("How many will be playing (2-4): ");
            Int16.TryParse(Console.ReadLine(), out numberOfPlayers);
            
            players.RemoveRange(numberOfPlayers, 4 - numberOfPlayers);

            foreach (Player p in players)
            {
                Console.Write("{0}, what's your name: ", p.Name);
                p.Name = Console.ReadLine();

                Console.WriteLine("These tokens are available: {0}", availableTokens(players));
                Console.Write("{0}, which would you like: ", p.Name);
                p.Token = (Tokens)Enum.Parse(typeof(Tokens), Console.ReadLine());
            }

            Console.WriteLine("Let's get started!");
            viewBoard();

            Console.Write("Bob, what's your name: ");
            string a = Console.ReadLine();

        }

        private static List<Player> newPlayers()
        {
            List<Player> players = new List<Player>(4);

            Player player1 = new Player("Player 1", 1);
            players.Add(player1);

            Player player2 = new Player("Player 2", 2);
            players.Add(player2);

            Player player3 = new Player("Player 3", 3);
            players.Add(player3);

            Player player4 = new Player("Player 4", 4);
            players.Add(player4);

            return players;
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

        private static void viewBoard()
        {
            Console.WriteLine(" ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ");
            Console.WriteLine("|     |     |Chanc|Indi-|     |     |     |     |     |     |");
            Console.WriteLine("|     |     |  ?  | ana |     |     |     |     |     |     |");
            Console.WriteLine("|     |     |     | *** |     |     |     |     |     |     |");
            Console.WriteLine("|     |     | 1 2 |   2 |     |     |     |     |     |     |");
            Console.WriteLine("|     |     | 3 4 |     |     |     |     |     |     |     |");
            Console.WriteLine("|     |     |  2  |  1  |     |     |     |     |     |     |");
            Console.WriteLine(" ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ");
            Console.WriteLine("|    |                                       |    |");
            Console.WriteLine("|    |                                       |    |");
            Console.WriteLine(" ----                                         ---- ");
            Console.WriteLine("|    |                                       |    |");
            Console.WriteLine("|    |                                       |    |");
            Console.WriteLine(" ----                                         ---- ");
            Console.WriteLine("|    |                                       |    |");
            Console.WriteLine("|    |                                       |    |");
            Console.WriteLine(" ----                                         ---- ");
            Console.WriteLine("|    |                                       |    |");
            Console.WriteLine("|    |                                       |    |");
            Console.WriteLine(" ----                                         ---- ");
            Console.WriteLine("|    |                                       |    |");
            Console.WriteLine("|    |                                       |    |");
            Console.WriteLine(" ----                                         ---- ");
            Console.WriteLine("|    |                                       |    |");
            Console.WriteLine("|    |                                       |    |");
            Console.WriteLine(" ----                                         ---- ");
            Console.WriteLine("|    |                                       |    |");
            Console.WriteLine("|    |                                       |    |");
            Console.WriteLine(" ----                                         ---- ");
            Console.WriteLine("|    |                                       |    |");
            Console.WriteLine("|    |                                       |    |");
            Console.WriteLine(" ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ");
            Console.WriteLine("|    |    |    |    |    |    |    |    |    | 1 2|");
            Console.WriteLine("|    |    |    |    |    |    |    |    |    |    |");
            Console.WriteLine(" ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ");
        }
    }
}
