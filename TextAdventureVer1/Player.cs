using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureVer1
{
    public class Player : CreatureStats             // Player stats and base class.
    {
        
        public int Credit { get; set; }
        public string Name { get; set; }
        public List<PlayerInventory> Inventory { get; set; }
        public List<BPNlog> BPN { get; set; } 


        public Player(int maximumHitPoint, int currentHitPoint, int credit) : base(maximumHitPoint, currentHitPoint)
        {
            Credit = credit;
            Inventory = new List<PlayerInventory>();
            BPN = new List<BPNlog>();
            
        }
         
    }
}
