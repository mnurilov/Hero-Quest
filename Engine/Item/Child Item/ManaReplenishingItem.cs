using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class ManaReplenishingItem : Item
    {
        public int ManaReplenishingValue { get; set; }

        public ManaReplenishingItem(int id, string name, string description, int manaReplenishingValue) : base(id, name, description)
        {
            this.ManaReplenishingValue = manaReplenishingValue;
        }

        public override string ToString()
        {
            string info = "";

            info += base.ToString();
            info += ("Mana Replenishing Value: " + ManaReplenishingValue.ToString() + "\n");

            return info;
        }
    }
}
