using System;

namespace Monopoly
{
    public class Property
    {
        private Int16 _space;
        public Int16 Space
        {
            get { return _space; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
        }

        private string _set;
        public string Set
        {
            get { return _set; }
        }

        private int _price;
        public int Price
        {
            get { return _price; }
        }

        private int[] _rent;
        public int[] Rent
        {
            get { return _rent; }
        }

        private bool _ownable;
        public bool Ownable
        {
            get { return _ownable; }
        }

        private Player _owner;
        public Player Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }

        private bool _inMonopoly;
        public bool InMonopoly
        {
            get { return _inMonopoly; }
            set { _inMonopoly = value; }
        }

        private Int16 _houses;
        public Int16 Houses
        {
            get { return _houses; }
            set { _houses = value; }
        }

        

        public Property(Int16 space, string name, string set, int price, int[] rent, bool ownable)
        {
            _space = space;
            _name = name;
            _set = set;
            _price = price;
            _rent = rent;
            _ownable = ownable;
            _owner = null;
            _inMonopoly = false;
            _houses = 0;
        }


        // Outputs how many houses are currently on the property
        public string writeHouses()
        {
            switch (_houses)
            {
                case 1: return "  *  ";
                case 2: return "  ** ";
                case 3: return " *** ";
                case 4: return " ****";
                case 5: return "*****";
                default: return "     ";
            }
        }

        public string writeOwner()
        {
            return _owner.Name;
        }
    }
}
