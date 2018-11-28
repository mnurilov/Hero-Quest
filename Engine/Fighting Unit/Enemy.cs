﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Enemy
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        private int currentHealth;
        public int CurrentHealth
        {
            get
            {
                return currentHealth;
            }
            set
            {
                if (value > MaximumHealth)
                {
                    currentHealth = MaximumHealth;
                }
                else if (value < 0)
                {
                    currentHealth = 0;
                }
                else
                {
                    currentHealth = value;
                }
            }
        }

        private int currentMana;
        public int CurrentMana
        {
            get
            {
                return currentMana;
            }
            set
            {
                if (value > MaximumMana)
                {
                    currentMana = MaximumMana;
                }
                else if (value < 0)
                {
                    currentMana = 0;
                }
                else
                {
                    currentMana = value;
                }
            }
        }

        public int MaximumHealth { get; set; }
        public int MaximumMana { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int Luck { get; set; }
        public int Speed { get; set; }
        public int Intellect { get; set; }
        public int Resistance { get; set; }

        public double CriticalChanceRate { get; set; }
        public double DodgeChanceRate { get; set; }

        public int RewardGold { get; set; }
        public int RewardExperiencePoints { get; set; }
        public List<EnemyLoot> LootTable { get; set; }


        public Enemy (int id, string name, string description, int maximumHealth, int maximumMana, int strength, 
            int defense, int luck, int speed, int intellect, int resistance, double criticalChanceRate,
            double dodgeChanceRate, int rewardGold, int rewardExperiencePoints, List<EnemyLoot> lootTable = null)
        { 
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.MaximumHealth = maximumHealth;
            this.MaximumMana = maximumMana;
            this.Strength = strength;
            this.Defense = defense;
            this.Luck = luck;
            this.Speed = speed;
            this.Intellect = intellect;
            this.Resistance = resistance;
            this.CriticalChanceRate = criticalChanceRate;
            this.DodgeChanceRate = dodgeChanceRate;
            CurrentHealth = MaximumHealth;
            CurrentMana = MaximumMana;
            this.RewardGold = rewardGold;
            this.RewardExperiencePoints = rewardExperiencePoints;
            this.LootTable = lootTable;
        }

        public int Attack(Player player, ref GameSession.BattleResult battleResult)
        {
            int damage = 0;

            //If the player would dodge the attack do not calculate the damage
            if (RandomNumberGenerator.RandomNumberBetween(0, 100) <= player.DodgeChanceRate)
            {
                battleResult = GameSession.BattleResult.Missed;
                return damage;
            }

            //If the enemy would critical strike the player then calculate the damage accordingly
            if (RandomNumberGenerator.RandomNumberBetween(0, 100) <= CriticalChanceRate)
            {
                //Double the damage
                battleResult = GameSession.BattleResult.Critical;
                damage = (((Strength * Strength) / (Strength + player.TotalDefense)) * 2) * 2;
            }
            //Else the enemy would normally strike the player then calculate the damage accordingly
            else
            {
                battleResult = GameSession.BattleResult.Normal;
                damage = ((Strength * Strength) / (Strength + player.TotalDefense)) * 2;
            }

            return damage;
        }

        public override string ToString()
        {
            string info = "";

            info += ("ID: " + ID.ToString() + "\n");
            info += ("Description: " + Description + "\n");
            info += ("Name: " + Name + "\n");
            info += ("Current Health: " + CurrentHealth.ToString() + "\n");
            info += ("Maximum Health: " + MaximumHealth.ToString() + "\n");
            info += ("Current Mana: " + CurrentMana.ToString() + "\n");
            info += ("Maximum Mana: " + MaximumMana.ToString() + "\n");
            info += ("Strength: " + Strength.ToString() + "\n");
            info += ("Defense: " + Defense.ToString() + "\n");
            info += ("Luck: " + Luck.ToString() + "\n");
            info += ("Speed: " + Speed.ToString() + "\n");
            info += ("Intellect: " + Intellect.ToString() + "\n");
            info += ("Resistance: " + Resistance.ToString() + "\n");
            info += ("Critical Chance: " + ((int)CriticalChanceRate).ToString() + "%\n");
            info += ("Dodge Chance: " + ((int)DodgeChanceRate).ToString() + "%\n");
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