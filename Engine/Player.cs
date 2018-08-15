using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : FightingUnit
    {
        /* #region Fields
         private int level;
         private int currentExperience;
         private int maximumExperience;
         #endregion*/

        public const double WarriorHealthStatScaleFactor = 6.073588;
        public const double WarriorHealthStatExponent = 1.7;
        public const double WarriorHealthStatConstant = 10;

        #region Properties
        public int Level { get; set; }
        public int CurrentExperience { get; set; }
        public int MaximumExperience { get; set; }
        public Location CurrentLocation { get; set; }
        public Weapon CurrentWeapon { get; set; }
        public HeadEquipment CurrentHeadEquipment { get; set; }
        public ChestEquipment CurrentChestEquipment { get; set; }
        public LegEquipment CurrentLegEquipment { get; set; }
        #endregion 

        #region Constructor
        public Player(int maximumHealth, int maximumMana, int attack, int defense, int luck,
            int speed, int intellect, int resistance, int level = 1) : base(maximumHealth, maximumMana,
                attack, defense, luck, speed, intellect, resistance)
        {
            this.Level = level;
            this.MaximumExperience = (int)(10 + (Math.Pow(Level, 3)));
            this.CurrentExperience = 0; 
            MaximumHealth = (int)((WarriorHealthStatScaleFactor * (Math.Pow(Level, WarriorHealthStatExponent))) + 10);
            CurrentHealth = MaximumHealth;
            MaximumMana = (int)(12 + (Math.Pow(Level, 3)) / 3);
            CurrentMana = MaximumMana;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            string stats = "";

            stats += ("Level: " + Level.ToString() + "\n");
            stats += ("Current Experience: " + CurrentExperience.ToString() + "\n");
            stats += ("Maximum Experience: " + MaximumExperience.ToString() + "\n");
            stats += base.ToString();

            return stats;
        }

        public void GainExperience(int experience)
        {
            CurrentExperience += experience;

            while(CurrentExperience >= MaximumExperience)
            {
                LevelUp();
                CurrentExperience -= MaximumExperience;
                MaximumExperience = (int)(10 + (Math.Pow(Level, 3)));
            }
        }

        public void LevelUp()
        {
            Level++;
            MaximumHealth = (int)((WarriorHealthStatScaleFactor * (Math.Pow(Level, WarriorHealthStatExponent))) + 10);
            CurrentHealth = MaximumHealth;
            MaximumMana = (int)(12 + (Math.Pow(Level, 3)) / 3);
            CurrentMana = MaximumMana;
        }
        #endregion
    }
}
