using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureVer1
{
    public class PlayerInventory
    {
        public Items Details { get; set; }
        public int Quantity { get; set; }

        public PlayerInventory(Items details, int quantity)
        {
            Details = details;
            Quantity = quantity;

        }
    }
}
