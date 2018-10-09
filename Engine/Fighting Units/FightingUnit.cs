using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class FightingUnit
    {
        public delegate void PropertyChangedHandler();

        public event PropertyChangedHandler StatsChanged;
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
                if (StatsChanged != null)
                {
                    StatsChanged();
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
                if (StatsChanged != null)
                {
                    StatsChanged();
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
                if (StatsChanged != null)
                {
                    StatsChanged();
                }
            }
        }

        private int currentExperiencePoints;
        public int CurrentExperiencePoints
        {
            get
            {
                return currentExperiencePoints;
            }
            set
            {
                if (Level >= MaximumLevel)
                {
                    currentExperiencePoints = 0;
                }
                else
                {
                    currentExperiencePoints = value;
                }
                if (StatsChanged != null)
                {
                    StatsChanged();
                }
            }
        }

        public int MaximumHealth { get; set; }
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
        public FightingUnit(int Level, string Name, int MaximumHealth, int MaximumMana, int Attack, int Defense, 
            int Luck, int Speed, int Intellect, int Resistance)
        {
            this.Level = Level;
            this.Name = Name;
            this.MaximumHealth = MaximumHealth;
            this.MaximumMana = MaximumMana;
            this.Attack = Attack;
            this.Defense = Defense;
            this.Luck = Luck;
            this.Speed = Speed;
            this.Intellect = Intellect;
            this.Resistance = Resistance;
            CurrentHealth = MaximumHealth;
            CurrentMana = MaximumMana;
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
