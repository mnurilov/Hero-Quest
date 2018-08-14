using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : FightingUnit
    {
        #region Fields
        private int level;
        private int currentExperience;
        private int maximumExperience;
        #endregion

        #region Properties
        public Location CurrentLocation { get; set; }
        public Weapon CurrentWeapon { get; set; }
        public HeadEquipment CurrentHeadEquipment { get; set; }
        public ChestEquipment CurrentChestEquipment { get; set; }
        public LegEquipment CurrentLegEquipment { get; set; }

        public int Level
        {
            get { return level; }
            set
            {
                if(value > 20)
                {
                    level = 20;
                }
                else if (value < 1)
                {
                    level = 1;
                }
                else
                {
                    level = value;
                }
            }
        }

        public int CurrentExperience
        {
            get { return currentExperience; }
            set
            {
                if (value > maximumExperience)
                {
                    currentExperience = maximumExperience;
                }
                else if (value < 0)
                {
                    currentExperience = 0;
                }
                else
                {
                    currentExperience = value;
                }
            }
        }

        public int MaximumExperience
        {
            get { return maximumExperience; }
            set
            {
                if (value > 100)
                {
                    maximumExperience = 100;
                }
                else if (value < 0)
                {
                    maximumExperience = 0;
                }
                else
                {
                    maximumExperience = value;
                }
            }
        }
        #endregion 

        #region Constructor
        public Player(int level, int maximumExperience, int maximumHealth, int maximumMana, int attack,
            int defense, int luck, int speed, int intellect, int resistance) : base(maximumHealth, maximumMana,
                attack, defense, luck, speed, intellect, resistance)
        {
            this.level = level;
            this.maximumExperience = maximumExperience;
            currentExperience = 0;
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
        #endregion
    }
}
