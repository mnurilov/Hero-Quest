using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public abstract class Equipment
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int GoldValue { get; set; }
        private const double SellingValueModifier = 0.5;
        public int SellingGoldValue { get; set; }

        //<----------Equipment stat bonuses---------->
        public int HealthBonus { get; set; }
        public int ManaBonus { get; set; }
        public int StrengthBonus { get; set; }
        public int DefenseBonus { get; set; }
        public int LuckBonus { get; set; }
        public int SpeedBonus { get; set; }
        public int IntellectBonus { get; set; }
        public int ResistanceBonus { get; set; }


        public Equipment(int id, string name, string description, int goldValue, int healthBonus, int manaBonus, int strengthBonus,
            int defenseBonus, int luckBonus, int speedBonus, int intellectBonus, int resistanceBonus)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.GoldValue = goldValue;
            SellingGoldValue = (int)(GoldValue * SellingValueModifier);
            this.HealthBonus = healthBonus;
            this.ManaBonus = manaBonus;
            this.StrengthBonus = strengthBonus;
            this.DefenseBonus = defenseBonus;
            this.LuckBonus = luckBonus;
            this.SpeedBonus = speedBonus;
            this.IntellectBonus = intellectBonus;
            this.ResistanceBonus = resistanceBonus;
        }


        public override string ToString()
        {
            string info = "";

            info += ("ID: " + ID + "\n");
            info += ("Name: " + Name + "\n");
            info += ("Description: " + Description + "\n");
            info += ("Gold Value: " + GoldValue + "\n");
            info += ("Health Bonus: " + HealthBonus + "\n");
            info += ("Mana Bonus: " + ManaBonus + "\n");
            info += ("Strength Bonus: " + StrengthBonus + "\n");
            info += ("Defense Bonus: " + DefenseBonus + "\n");
            info += ("Luck Bonus: " + LuckBonus + "\n");
            info += ("Speed Bonus: " + SpeedBonus + "\n");
            info += ("Intellect Bonus: " + IntellectBonus + "\n");
            info += ("Resistance Bonus: " + ResistanceBonus + "\n");

            return info;
        }
    }
}
