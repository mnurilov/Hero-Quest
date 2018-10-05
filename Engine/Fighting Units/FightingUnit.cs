using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class FightingUnit
    {
        #region Data Storage
        #region Constants
        protected const int MinimumLevel = 1;
        protected const int MaximumLevel = 20;
        #endregion

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

        private int level;
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                if (value > MaximumLevel)
                {

                    level = MaximumLevel;
                }
                else if (value < MinimumLevel)
                {
                    level = MinimumLevel;
                }
                else
                {
                    level = value;
                }
            }
        }

        public int MaximumHealth { get; set; }
        public int CurrentMana { get; set; }
        public int MaximumMana { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Luck { get; set; }
        public int Speed { get; set; }
        public int Intellect { get; set; }
        public int Resistance { get; set; }

        public double CriticalChanceRate { get; set; }
        public double DodgeChanceRate { get; set; }
        #endregion

        #region Constructor
        public FightingUnit(int level, string name, int maximumHealth, int maximumMana, int attack, int defense, 
            int luck, int speed, int intellect, int resistance)
        {
            this.Level = level;
            this.Name = name;
            this.MaximumHealth = maximumHealth;
            this.MaximumMana = maximumMana;
            this.Attack = attack;
            this.Defense = defense;
            this.Luck = luck;
            this.Speed = speed;
            this.Intellect = intellect;
            this.Resistance = resistance;
            CurrentHealth = maximumHealth;
            CurrentMana = maximumMana;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            string stats = "";

            stats += ("Name: " + Name + "\n");
            stats += ("Current Health: " + CurrentHealth.ToString() + "\n");
            stats += ("Maximum Health: " + MaximumHealth.ToString() + "\n");
            stats += ("Current Mana: " + CurrentMana.ToString() + "\n");
            stats += ("Maximum Mana: " + MaximumMana.ToString() + "\n");
            stats += ("Attack: " + Attack.ToString() + "\n");
            stats += ("Defense: " + Defense.ToString() + "\n");
            stats += ("Luck: " + Luck.ToString() + "\n");
            stats += ("Speed: " + Speed.ToString() + "\n");
            stats += ("Intellect: " + Intellect.ToString() + "\n");
            stats += ("Resistance: " + Resistance.ToString() + "\n");
            stats += ("Critical Chance: " + ((int)CriticalChanceRate).ToString() + "%\n");
            stats += ("Dodge Chance: " + ((int)DodgeChanceRate).ToString() + "%\n");

            return stats;
        }
        #endregion
    }
}
