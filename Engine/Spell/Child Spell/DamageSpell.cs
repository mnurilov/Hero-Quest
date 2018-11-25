using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class DamageSpell : Spell
    {
        public int DamageAmount { get; set; }


        public DamageSpell(int id, string name, string description, int goldValue, int manaCost, int damageAmount)
            : base(id, name, description, goldValue, manaCost)
        {
            this.DamageAmount = damageAmount;
        }

        public override string ToString()
        {
            string info = "";

            info += base.ToString();
            info += ("Damage Amount: " + DamageAmount.ToString() + "\n");

            return info;
        }
    }
}
