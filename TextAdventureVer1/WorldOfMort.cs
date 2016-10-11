using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureVer1
{
    public static class WorldOfMort
    {
        public static readonly List<Items> Items = new List<Items>();
        public static readonly List<Enemies> Enemies = new List<Enemies>();
        public static readonly List<PlayerBPN> PlayerBPN = new List<PlayerBPN>();
        public static readonly List<Locations> Locations = new List<Locations>();

        public const int ITEM_ID_KNIFE = 1;
        public const int ITEM_ID_FEN603 = 1;
        public const int ITEM_ID_TACO = 1;
        public const int ITEM_ID_LEATHERJACKET = 1;

        public const int ENEMIE_ID_PUNK = 1;
        public const int ENEMIE_ID_MUTANTTACO = 1;

        public const int BPN_ID_CLEAR_OUT_PUNKS = 1;
        public const int BPN_ID_CLEAR_OUT_DOWNTOWN = 1;

        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_HALLWAY = 1;

        static WorldOfMort()
        {
            PopulateItems();
            PopulateEnemies();
            PopulateBPN();
            PopulateLocation();
        }
        private static void PopulateItems()
        {
            Items.Add(new Items(ITEM_ID_KNIFE, "Knife", 2, 1));
            Items.Add(new Items(ITEM_ID_FEN603, "FEN603", 5, 2));
            Items.Add(new Items(ITEM_ID_LEATHERJACKET, "Spook Leather Jacket", 0, 0));
            Items.Add(new Items(ITEM_ID_TACO, "Frozen Taco", 0,0 ));
        }
        private static void PopulateEnemies()
        {
            Enemies Punk = new Enemies(ENEMIE_ID_PUNK, "Punk", 5, 2, 10, 10);
            Enemies MutantTaco = new Enemies(ENEMIE_ID_MUTANTTACO, "Mutant Taco", 6, 0, 8, 8);

        }
        public static void PopulateBPN()
        {
            PlayerBPN Clear_Downtown = new PlayerBPN(BPN_ID_CLEAR_OUT_DOWNTOWN,
                "Blue: Clean up down town", "Gangers loutering aroun downtown, clean them out", 250);
            PlayerBPN Clear_Punks = new PlayerBPN(BPN_ID_CLEAR_OUT_PUNKS, "The good nabo", "Your nabour needs a hand", 50);
        }
        public static void PopulateLocation()
        {
            Locations Home = new Locations(LOCATION_ID_HOME, "Home sweet Home", "insert d");
            Locations Hallway = new Locations(LOCATION_ID_HALLWAY, "Hallway", 
                "A dirty place, armored doors on each side and an elevator with a 'Broke' sign on it");

            Hallway.RoamingEnemies = EnemiesByID(ENEMIE_ID_PUNK);
            Hallway.BPN_available = BPNbyID(BPN_ID_CLEAR_OUT_PUNKS);
        }

        }
   
    }

  



