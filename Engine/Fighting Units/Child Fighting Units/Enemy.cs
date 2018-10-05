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
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }

        public List<EnemyLoot> LootTable = new List<EnemyLoot>();
        #endregion

        #region Constructor
        public Enemy (int id, int level, string name, int maximumHealth, int maximumMana, int attack, 
            int defense, int luck, int speed, int intellect, int resistance, double criticalChanceRate,
            double dodgeChanceRate, int gold, int experiencePoints) :
            base (level, name, maximumHealth, maximumMana, attack, defense, luck, speed, 
                intellect, resistance)
        {
            this.ID = id;
            this.CriticalChanceRate = criticalChanceRate;
            this.DodgeChanceRate = dodgeChanceRate;
            this.Gold = gold;
            this.ExperiencePoints = experiencePoints;
        }
        #endregion

        #region Methods
        public void AttackCommand(Player player)
        {
            int damage = 0;

            //If the enemy would dodge the attack do not calculate damage
            if (RandomNumberGenerator.RandomNumberBetween(0, 100) <= player.DodgeChanceRate)
            {
                Console.WriteLine("{0} missed", Name);
                return;
            }

            //If the player would critical strike the enemy then calculate the damage accordingly
            if (RandomNumberGenerator.RandomNumberBetween(0, 100) <= CriticalChanceRate)
            {
                //Double the damage
                damage = (((Attack * Attack) / (Attack + player.Defense)) * 2) * 2;
                Console.WriteLine("{0} critical hit and did {1} points of damage to {2}", Name, damage, player.Name);
            }
            else
            {
                damage = ((Attack * Attack) / (Attack + player.Defense)) * 2;
                Console.WriteLine("{0} did {1} points of damage to {2}", Name, damage, player.Name);
            }
            player.CurrentHealth -= damage;
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
