using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class ReplenishingSpell : Spell
    {
        public int ReplenishingAmount { get; set; }

        public ReplenishingSpell(int id, string name, string description, int manaCost, int replenishingAmount)
            : base(id, name, description, manaCost)
        {
            this.ReplenishingAmount = replenishingAmount;
        }

        public override string ToString()
        {
            string info = "";

            info += base.ToString();
            info += ("Replenishing Amount: " + ReplenishingAmount.ToString() + "\n");

            return info;
        }
    }
}
