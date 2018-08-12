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
        #endregion 

        public FightingUnit(int currentHealth)
        {
            this.currentHealth = currentHealth;
        }
    }
}
