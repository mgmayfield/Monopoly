﻿using System;
using System.Collections.Generic;
using static System.Console;

namespace Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            Board playingBoard = new Board();
            List<Player> players = newPlayers();
            short numberOfPlayers;

            WriteLine("Welcome to Monopoly!");
            Write("How many will be playing (2-4): ");
            short.TryParse(ReadLine(), out numberOfPlayers);
            
            players.RemoveRange(numberOfPlayers, 4 - numberOfPlayers);

            foreach (Player p in players)
            {
                p.readName();
                p.readToken(players);
            }

            WriteLine("Let's get started!");
            viewBoard();

            Write("Bob, what's your name: ");
            string a = ReadLine();

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
