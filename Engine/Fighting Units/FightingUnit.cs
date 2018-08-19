using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class FightingUnit
    {
        /* Removing for the time being not sure if i need them
         * #region Fields

         private int maximumHealth;
         private int currentMana;
         private int maximumMana;
         private int attack;
         private int defense;
         private int luck;
         private int speed;
         private int intellect;
         private int resistance;
         #endregion*/

        private int currentHealth;

        #region Properties
        public string Name { get; set; }

        public int CurrentHealth
        {
            get
            {
                return currentHealth;
            }
            set
            {
                if (currentHealth > MaximumHealth)
                {
                    currentHealth = MaximumHealth;
                }
                else if (currentHealth < 0)
                {
                    currentHealth = 0;
                }
                else
                {
                    currentHealth = value;
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
       
        #endregion 

        #region Constructor
        public FightingUnit(string Name, int MaximumHealth, int MaximumMana, int Attack, int Defense, 
            int Luck, int Speed, int Intellect, int Resistance)
        {
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

            return stats;
        }
        #endregion
    }
}
