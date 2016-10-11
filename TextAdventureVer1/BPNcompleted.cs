using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureVer1
{
    public class BPNcompleted                  // class for quest the player has completed 
    {
        public BPN Details { get; set; }
        public bool IsCompleted { get; set; }

        public BPNcompleted(BPN details)
        {
            Details = details;
            IsCompleted = false;
        }
    }
}
