using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class DamageSpell : Spell
    {
        public int SpellDamage { get; set; }

        #region Constructor
        public DamageSpell(int id, string name, string description, int manaCost, int spellDamage)
            : base(id, name, description, manaCost)
        {
            this.SpellDamage = spellDamage;
        }
        #endregion

        public override string ToString()
        {
            string info = "";

            info += base.ToString();
            info += ("Spell Damage: " + SpellDamage.ToString() + "\n");

            return info;
        }
    }
}
