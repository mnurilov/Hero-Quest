using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Enemy : FightingUnit
    {
        #region Properties
        public int ID { get; set; }
        #endregion

        public Enemy (int ID, int MaximumHealth, int MaximumMana, int Attack, 
            int Defense, int Luck, int Speed, int Intellect, int Resistance) :
            base (MaximumHealth, MaximumMana, Attack, Defense, Luck, Speed, 
                Intellect, Resistance)
        {
            this.ID = ID;
        }
    }
}
