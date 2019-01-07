using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Sword : Weapon
    {
        public Sword(int id, string name, string description, int goldValue, int healthBonus, int manaBonus, int strengthBonus,
            int defenseBonus, int luckBonus, int speedBonus, int intellectBonus , int resistanceBonus)
            : base(id, name, description, goldValue, healthBonus, manaBonus, strengthBonus, defenseBonus, luckBonus, speedBonus,
                  intellectBonus, resistanceBonus)
        {

        }
    }
}
