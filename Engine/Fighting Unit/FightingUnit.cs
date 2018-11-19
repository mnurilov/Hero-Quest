using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class FightingUnit
    {
        public string Name { get; set; }

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

        public FightingUnit(string name, int maximumHealth, int maximumMana, int strength, int defense, 
            int luck, int speed, int intellect, int resistance, double criticalChanceRate, double dodgeChanceRate)
        {
            this.Name = name;
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
        }

        public override string ToString()
        {
            string stats = "";

            stats += ("Name: " + Name + "\n");
            stats += ("Current Health: " + CurrentHealth.ToString() + "\n");
            stats += ("Maximum Health: " + MaximumHealth.ToString() + "\n");
            stats += ("Current Mana: " + CurrentMana.ToString() + "\n");
            stats += ("Maximum Mana: " + MaximumMana.ToString() + "\n");
            stats += ("Strength: " + Strength.ToString() + "\n");
            stats += ("Defense: " + Defense.ToString() + "\n");
            stats += ("Luck: " + Luck.ToString() + "\n");
            stats += ("Speed: " + Speed.ToString() + "\n");
            stats += ("Intellect: " + Intellect.ToString() + "\n");
            stats += ("Resistance: " + Resistance.ToString() + "\n");
            stats += ("Critical Chance: " + ((int)CriticalChanceRate).ToString() + "%\n");
            stats += ("Dodge Chance: " + ((int)DodgeChanceRate).ToString() + "%\n");

            return stats;
        }
    }
}
