using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureVer1
{
    public class PlayerBPN  // Class for Quests in the game.
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CreditReward { get; set; }

        public PlayerBPN(int id, string name, string description, int creditReward)
        {
            ID = id;
            Name = name;
            Description = description;
            CreditReward = creditReward;
        }                                           

    }
}
