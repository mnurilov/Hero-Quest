using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Enemy : FightingUnit
    {
        #region Data Storage
        public int ID { get; set; }

        public List<EnemyLoot> LootTable = new List<EnemyLoot>();
        #endregion

        #region Constructor
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
        #endregion

        #region Methods
        public void AttackCommand(Player player)
        {
            int damage = 0;

            //If the enemy would dodge the attack do not calculate damage
            if (RandomNumberGenerator.RandomNumberBetween(0, 100) <= player.DodgeChanceRate)
            {
                return;
            }

            //If the player would critical strike the enemy then calculate the damage accordingly
            if (RandomNumberGenerator.RandomNumberBetween(0, 100) <= CriticalChanceRate)
            {
                //Double the damage
                damage = (((Attack * Attack) / (Attack + player.Defense)) * 10) * 2;
            }
            else
            {
                damage = ((Attack * Attack) / (Attack + player.Defense)) * 10;
            }
            player.CurrentHealth -= damage;
            Console.WriteLine("{0} did {1} points of damage to {2}", Name, damage, player.Name);
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
        #endregion
    }
}
