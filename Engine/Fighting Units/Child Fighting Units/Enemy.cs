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

        public List<EnemyLoot> LootTable = new List<EnemyLoot>();
        #endregion

        public Enemy (int ID, int Level, string Name, int MaximumHealth, int MaximumMana, int Attack, 
            int Defense, int Luck, int Speed, int Intellect, int Resistance, double CriticalChanceRate,
            double DodgeChanceRate) :
            base (Level, Name, MaximumHealth, MaximumMana, Attack, Defense, Luck, Speed, 
                Intellect, Resistance)
        {
            this.ID = ID;
            this.CriticalChanceRate = CriticalChanceRate;
            this.DodgeChanceRate = DodgeChanceRate;
        }

        public override string ToString()
        {
            string info = "";

            info += ("ID: " + ID.ToString() + "\n");
            info += base.ToString();
            if(LootTable != null)
            {
                foreach (EnemyLoot enemyLoot in LootTable)
                {
                    info += ("ID: " + enemyLoot.ID.ToString() + ", " + enemyLoot.Name + "\n");
                }
            }
            

            return info;
        }
    }
}
