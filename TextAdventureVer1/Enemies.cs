using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureVer1
{
    public class Enemies : CreatureStats            // Enemies and the base class for all creatues.
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int Credit { get; set; }
        public List<LootTable> Loot { get; set; }

        public Enemies(int id, string name, int maximumDamage, int credit, int maximumHitPoint, int currentHitPoint) : 
            base(maximumHitPoint, currentHitPoint)
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumDamage;
            Credit = credit;
            Loot = new List<LootTable>();
            
        }



    }
}
