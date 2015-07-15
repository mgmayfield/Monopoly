using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Board
    {
        private List<Property> _playingBoard = new List<Property>(40);
        public List<Property> PlayingBoard
        {
            get { return _playingBoard; }
        }

        public Board()
        {
            Property go = new Property(0, "GO", "Corners", 200, null, false);
            _playingBoard.Add(go);

            Property mediterraneanAvenue = new Property(1, "Mediterranean Avenue", "Brown", 60, new int[6] { 2, 10, 30, 90, 160, 250 }, true);
            _playingBoard.Add(mediterraneanAvenue);

            Property communityChestBrown = new Property(2, "Community Chest", "Chest", 0, null, false);
            _playingBoard.Add(communityChestBrown);

            Property balticAvenue = new Property(3, "Baltic Avenue", "Brown", 60, new int[6] { 4, 20, 60, 180, 320, 450 }, true);
            _playingBoard.Add(balticAvenue);

            Property incomeTax = new Property(4, "Income Tax", "Tax", -200, null, false);
            _playingBoard.Add(incomeTax);

            Property readingRailroad = new Property(5, "Reading Railroad", "Railroad", 200, null, true);
            _playingBoard.Add(readingRailroad);

            Property orientalAvenue = new Property(6, "Oriental Avenue", "Light Blue", 100, new int[6] { 6, 30, 90, 270, 400, 550 }, true);
            _playingBoard.Add(orientalAvenue);

            Property chanceLightBlue = new Property(7, "Chance", "Chance", 0, null, false);
            _playingBoard.Add(chanceLightBlue);

            Property vermontAvenue = new Property(8, "Vermont Avenue", "Light Blue", 100, new int[6] { 6, 30, 90, 270, 400, 550 }, true);
            _playingBoard.Add(vermontAvenue);

            Property connecticutAvenue = new Property(9, "Connecticut Avenue", "Light Blue", 120, new int[6] { 8, 40, 100, 300, 450, 600 }, true);
            _playingBoard.Add(connecticutAvenue);

            Property jail = new Property(10, "Jail", "Corners", 0, null, false);
            _playingBoard.Add(jail);
        }

        
        
        
        
        
        private const string topLines = " ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ";
        private const string midLines = " -----                                                 ----- ";


        private const Int16[] viewBoardOrder = new Int16[40] { 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 
                                                          30, 19, 31, 18, 32, 17, 33, 16, 34, 15,
                                                          35, 14, 36, 13, 37, 12, 38, 11, 19, 10,
                                                          9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

        private const string[] viewTopName = new string[40] { "Free ", "Kent-", "Chanc", "Indi-", "Illi-", " B&O ", "Atla-", "Vent-", "Water", "Marvn",
                                                              "Go To", " New ", "Paci-", "Tenn-", "North", "Comm ", "Comm ", " St. ", "Penn ", "Penn ",
                                                              "Short", "Virg-", "Chanc", "State", "Park ", "Elect", " Lux ", " St. ", "Board", "Jail ",
                                                              "Conn-", "Ver- ", "Chanc", "Orie-", "Read ", "Incom", "Bal- ", "Comm ", "Medi-", " GO  " };

        private const string[] viewBottomName = new string[40] { " Park", " ucky", "  ?  ", " ana ", " nois", "Rail ", " ntic", " nor ", "Works", "Gardn",
                                                                 " Jail", " York", " fic ", "essee", "Carol", "Chest", "Chest", "James", " Ave ", "Rail ", 
                                                                 "Line ", " inia", "  ?  ", " Ave ", "Place", " ric ", " Tax ", "Charl", " walk", "     ",
                                                                 "ticut", "mont ", "  ?  ", " ntal", "Rail ", " Tax ", " tic ", "Chest", "teran", "     " };
        
        public static void viewBoard(List<Player> players)
        {            
            foreach (Int16 i in viewBoardOrder)
            {
                
            }

            Console.WriteLine(" ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ");
            Console.WriteLine("|     |     |Chanc|Indi-|     |     |     |     |     |     |     |");
            Console.WriteLine("|     |     |  ?  | ana |     |     |     |     |     |     |     |");
            Console.WriteLine("|     |     |     | *** |     |     |     |     |     |     |     |");
            Console.WriteLine("|     |     | 1 2 |   2 |     |     |     |     |     |     |     |");
            Console.WriteLine("|     |     | 3 4 |     |     |     |     |     |     |     |     |");
            Console.WriteLine("|     |     |  2  |  1  |     |     |     |     |     |     |     |");
            Console.WriteLine(" ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ----- ");
            Console.WriteLine("|     |                                                     |     |");
            Console.WriteLine("|     |                                                     |     |");
            Console.WriteLine("|     |                                                     |     |");
            Console.WriteLine("|     |                                                     |     |");
            Console.WriteLine("|     |                                                     |     |");
            Console.WriteLine("|     |                                                     |     |");
            Console.WriteLine(" -----                                                       ----- ");
            Console.WriteLine("|     |                                                     |     |");
            Console.WriteLine("|     |                                                     |     |");
            Console.WriteLine("|     |                                                     |     |");
            Console.WriteLine("|     |                                                     |     |");
            Console.WriteLine("|     |                                                     |     |");
            Console.WriteLine("|     |                                                     |     |");
            Console.WriteLine(" -----                                                       ----- ");
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
