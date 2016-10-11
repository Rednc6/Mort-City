using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureVer1
{
    public class Locations
    {
        public int ID { get; set; }
        public Items AccessItem { get; set; }
        public PlayerBPN BPN_available { get; set; }
        public Enemies RoamingEnemies { get; set; }
        public Locations ExitLocation { get; set; }
        public Locations EnterLocation { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Locations(int id, string name, string description, Items accessItem = null, PlayerBPN bPN_available = null, 
            Enemies roamingEnemies = null)
        {
            ID = id;
            Name = name;
            Description = description;
            AccessItem = accessItem;
            BPN_available = bPN_available;
            RoamingEnemies = roamingEnemies;
            
        }

    }
}
