using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class ReplenishSpell : Spell
    {
        public int ReplenishAmount { get; set; }


        public ReplenishSpell(int id, string name, string description, int goldValue, int manaCost, int replenishAmount)
            : base(id, name, description, goldValue, manaCost)
        {
            this.ReplenishAmount = replenishAmount;
        }

        public override string ToString()
        {
            string info = "";

            info += base.ToString();
            info += ("Replenish Amount: " + ReplenishAmount.ToString() + "\n");

            return info;
        }
    }
}
