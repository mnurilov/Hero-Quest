using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class DamageItem : Item
    {
        public int DamageValue { get; set; }


        public DamageItem(int id, string name, string description, int goldValue, int damageValue)
            : base(id, name, description, goldValue)
        {
            this.DamageValue = damageValue;
        }

        public override string ToString()
        {
            string info = "";

            info += base.ToString();
            info += ("Damage Value: " + DamageValue.ToString() + "\n");

            return info;
        }
    }
}
