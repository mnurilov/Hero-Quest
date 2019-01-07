using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class DamageSpell : Spell
    {
        public int DamageValue { get; set; }


        public DamageSpell(int id, string name, string description, int goldValue, int manaCost, int damageValue)
            : base(id, name, description, goldValue, manaCost)
        {
            this.DamageValue = damageValue;
        }


        public override string ToString()
        {
            string info = "";

            info += base.ToString();
            info += ("Damage Value: " + DamageValue + "\n");

            return info;
        }
    }
}
