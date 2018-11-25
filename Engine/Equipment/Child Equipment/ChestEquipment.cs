using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class ChestEquipment : Equipment
    {
        public ChestEquipment(int id, string name, string description, int goldValue, int healthBonus = 0, int manaBonus = 0, int attackBonus = 0,
            int defenseBonus = 0, int luckBonus = 0, int speedBonus = 0, int intellectBonus = 0, int resistanceBonus = 0)
            : base(id, name, description, goldValue, healthBonus, manaBonus, attackBonus, defenseBonus, luckBonus, speedBonus,
                  intellectBonus, resistanceBonus)
        {

        }
    }
}
