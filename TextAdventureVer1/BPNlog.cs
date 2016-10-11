using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureVer1
{
    public class BPNlog         // Class for quests the player is on
    {
        public Items Details { get; set; }
        public  int Quantity { get; set; }
            
        public BPNlog(Items details, int quantity)
        {
            Details = details;
            Quantity = quantity;
        }
    }
}
