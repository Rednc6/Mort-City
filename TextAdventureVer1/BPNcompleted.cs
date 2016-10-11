using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureVer1
{
    class BPNcompleted                  // class for quest the player has completed 
    {
        public PlayerBPN Details { get; set; }
        public bool IsCompleted { get; set; }

        public BPNcompleted(PlayerBPN details)
        {
            Details = details;
            IsCompleted = false;
        }
    }
}
