using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : Equipment
    {
        #region Properties

        #endregion

        #region Constructor
        public Weapon(int ID, string Name, int HealthBonus = 0, int ManaBonus = 0, int AttackBonus = 0,
            int DefenseBonus = 0, int LuckBonus = 0, int SpeedBonus = 0, int IntellectBonus = 0,
            int ResistanceBonus = 0) : base(ID, Name, HealthBonus, ManaBonus, AttackBonus, DefenseBonus,
                LuckBonus, SpeedBonus, IntellectBonus, ResistanceBonus)
        {
        }
        #endregion 
    }
}
