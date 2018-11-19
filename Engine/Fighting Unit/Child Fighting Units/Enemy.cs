using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Enemy : FightingUnit
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int RewardGold { get; set; }
        public int RewardExperiencePoints { get; set; }
        public List<EnemyLoot> LootTable { get; set; }


        public Enemy (int id, string name, string description, int maximumHealth, int maximumMana, int strength, 
            int defense, int luck, int speed, int intellect, int resistance, double criticalChanceRate,
            double dodgeChanceRate, int rewardGold, int rewardExperiencePoints, List<EnemyLoot> lootTable = null)
            : base (name, maximumHealth, maximumMana, strength, defense, luck, speed, intellect, resistance, 
                  criticalChanceRate, dodgeChanceRate)
        {
            this.ID = id;
            this.Description = description;
            this.RewardGold = rewardGold;
            this.RewardExperiencePoints = rewardExperiencePoints;
            this.LootTable = lootTable;
        }

        //WORK NEEDS TO BE DONE
        public int Attack(Player player)
        {
            int damage = 0;

            //If the player would dodge the attack do not calculate the damage
            if (RandomNumberGenerator.RandomNumberBetween(0, 100) <= player.DodgeChanceRate)
            {
                Console.WriteLine("{0} missed", Name);
                return damage;
            }

            //If the enemy would critical strike the player then calculate the damage accordingly
            if (RandomNumberGenerator.RandomNumberBetween(0, 100) <= CriticalChanceRate)
            {
                //Double the damage
                damage = (((Strength * Strength) / (Strength + player.Defense)) * 2) * 2;
                Console.WriteLine("{0} critical hit and did {1} points of damage to {2}", Name, damage, player.Name);
            }
            else
            {
                damage = ((Strength * Strength) / (Strength + player.Defense)) * 2;
                Console.WriteLine("{0} did {1} points of damage to {2}", Name, damage, player.Name);
            }
            return damage;
        }

        public override string ToString()
        {
            string info = "";

            info += ("ID: " + ID.ToString() + "\n");
            info += ("Description: " + Description + "\n");
            info += base.ToString();
            info += ("Reward Gold: " + RewardGold.ToString() + "\n");
            info += ("Reward Experience: " + RewardExperiencePoints.ToString() + "\n");
            if(LootTable != null)
            {
                foreach (EnemyLoot enemyLoot in LootTable)
                {
                    info += ("ID: " + enemyLoot.ID.ToString() + "\t" + "Name: " + enemyLoot.Name + "\n");
                }
            }
            
            return info;
        }
    }
}
