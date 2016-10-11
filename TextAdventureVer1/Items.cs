using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureVer1
{
    public class Items
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int MinimumDamage { get; set; }

        public Items(int id, string name, int maximumDamange, int minimumDamage)
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumDamange;
            MinimumDamage = minimumDamage;
        }

    }
}
