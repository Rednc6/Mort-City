using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureVer1
{
    public class CreatureStats                      // Base class for common properties among creatues.
    {
        public int MaximumHitPoint { get; set; }
        public int CurrentHitPoint { get; set; }

        public CreatureStats(int maximumHitPoint, int currentHitPoint)
        {
            MaximumHitPoint = maximumHitPoint;
            CurrentHitPoint = currentHitPoint;
        }

    }
}
