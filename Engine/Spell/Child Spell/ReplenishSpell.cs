using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class ReplenishSpell : Spell
    {
        public int ReplenishValue { get; set; }


        public ReplenishSpell(int id, string name, string description, int goldValue, int manaCost, int replenishValue)
            : base(id, name, description, goldValue, manaCost)
        {
            this.ReplenishValue = replenishValue;
        }


        public override string ToString()
        {
            string info = "";

            info += base.ToString();
            info += ("Replenish Value: " + ReplenishValue + "\n");

            return info;
        }
    }
}
