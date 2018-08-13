using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class FightingUnit
    {
        #region Fields
        private int currentHealth;
        private int maximumHealth;
        private int currentMana;
        private int maximumMana;
        private int attack;
        private int defense;
        private int luck;
        private int speed;
        private int intellect;
        private int resistance;
        #endregion

        #region Properties
        public int CurrentHealth
        {
            get { return currentHealth; }
            set
            {
                if (value > maximumHealth)
                {
                    currentHealth = maximumHealth;
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

        public int MaximumHealth
        {
            get { return maximumHealth; }
            set
            {
                if (value > 100)
                {
                    maximumHealth = 100;
                }
                else if (value < 0)
                {
                    maximumHealth = 0;
                }
                else
                {
                    maximumHealth = value;
                }
            }
        }

        public int CurrentMana
        {
            get { return currentMana; }
            set
            {
                if (value > maximumMana)
                {
                    currentMana = maximumMana;
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

        public int MaximumMana
        {
            get { return maximumMana; }
            set
            {
                if (value > 100)
                {
                    maximumMana = 100;
                }
                else if (value < 0)
                {
                    maximumMana = 0;
                }
                else
                {
                    maximumMana = value;
                }
            }
        }

        public int Attack
        {
            get { return attack; }
            set
            {
                if (value > 50)
                {
                    attack = 50;
                }
                else if (value < 0)
                {
                    attack = 0;
                }
                else
                {
                    attack = value;
                }
            }
        }

        public int Defense
        {
            get { return defense; }
            set
            {
                if (value > 50)
                {
                    defense = 50;
                }
                else if (value < 0)
                {
                    defense = 0;
                }
                else
                {
                    defense = value;
                }
            }
        }

        public int Luck
        {
            get { return luck; }
            set
            {
                if (value > 30)
                {
                    luck = 30;
                }
                else if (value < 0)
                {
                    luck = 0;
                }
                else
                {
                    luck = value;
                }
            }
        }

        public int Speed
        {
            get { return speed; }
            set
            {
                if (value > 100)
                {
                    speed = 100;
                }
                else if (value < 0)
                {
                    speed = 0;
                }
                else
                {
                    speed = value;
                }
            }
        }

        public int Intellect
        {
            get { return intellect; }
            set
            {
                if (value > 1000)
                {
                    intellect = 1000;
                }
                else if (value < 0)
                {
                    intellect = 0;
                }
                else
                {
                    intellect = value;
                }
            }
        }

        public int Resistance
        {
            get { return resistance; }
            set
            {
                if (value > 10)
                {
                    resistance = 10;
                }
                else if (value < 0)
                {
                    resistance = 0;
                }
                else
                {
                    resistance = value;
                }
            }
        }
        #endregion 

        #region Constructor
        public FightingUnit(int MaximumHealth, int MaximumMana, int Attack, int Defense, 
            int Luck, int Speed, int Intellect, int Resistance)
        {
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

            return stats;
        }
        #endregion
    }
}
