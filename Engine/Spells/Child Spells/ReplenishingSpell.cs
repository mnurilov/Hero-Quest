using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class ReplenishingSpell : Spell
    {
        public int ReplenishingAmount;

        public ReplenishingSpell(int ID, string Name, string Description, int ManaCost, int ReplenishingAmount) : base(ID, Name, Description, ManaCost)
        {
            this.ReplenishingAmount = ReplenishingAmount;
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
