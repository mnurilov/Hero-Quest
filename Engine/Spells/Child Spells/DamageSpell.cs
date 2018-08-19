using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class DamageSpell : Spell
    {
        public int SpellDamage;

        #region Constructor
        public DamageSpell(int ID, string Name, string Description, int ManaCost, int SpellDamage) : base(ID, Name, Description, ManaCost)
        {
            this.SpellDamage = SpellDamage;
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
