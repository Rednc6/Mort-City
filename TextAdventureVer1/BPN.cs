using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureVer1
{
    public class BPN  // Class for Quests in the game.
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CreditReward { get; set; }
        public List<BPNlog> BPNcompletionItems { get; set; }


        public BPN(int id, string name, string description, int creditReward)
        {
            ID = id;
            Name = name;
            Description = description;
            CreditReward = creditReward;
            BPNcompletionItems = new List<BPNlog>();
        }                                           

    }
}
