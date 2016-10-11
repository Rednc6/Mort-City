using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureVer1
{
    public class LootTable
    {
        public Items Details { get; set; }
        public int DropChance { get; set; }
        public bool IsDefaultItem { get; set; }

        public LootTable(Items details, int dropChance, bool isDefaultItem)
        {
            Details = details;
            DropChance = dropChance;
            IsDefaultItem = isDefaultItem;
        }
    }
}
