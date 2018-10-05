using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Equipment : Item
    {
        #region Properties
        public int HealthBonus { get; set; }
        public int ManaBonus { get; set; }
        public int AttackBonus { get; set; }
        public int DefenseBonus { get; set; }
        public int LuckBonus { get; set; }
        public int SpeedBonus { get; set; }
        public int IntellectBonus { get; set; }
        public int ResistanceBonus { get; set; }
        #endregion

        #region Constructor
        //Equipments bonus's are set to 0 so that you only have to set the attributes that you want to a value and the rest become 0
        public Equipment(int id, string name, string description, int healthBonus = 0, int manaBonus = 0, 
            int attackBonus = 0, int defenseBonus = 0, int luckBonus = 0, int speedBonus = 0, int intellectBonus = 0,
            int resistanceBonus = 0) : base(id, name, description)
        {
            this.HealthBonus = healthBonus;
            this.ManaBonus = manaBonus;
            this.AttackBonus = attackBonus;
            this.DefenseBonus = defenseBonus;
            this.LuckBonus = luckBonus;
            this.SpeedBonus = speedBonus;
            this.IntellectBonus = intellectBonus;
            this.ResistanceBonus = resistanceBonus;
        }
        #endregion 

        #region Method
        public override string ToString()
        {
            string info = "";

            info += base.ToString();
            info += ("Health Bonus: " + HealthBonus.ToString() + "\n");
            info += ("Mana Bonus: " + ManaBonus.ToString() + "\n");
            info += ("Attack Bonus: " + AttackBonus.ToString() + "\n");
            info += ("Defense Bonus: " + DefenseBonus.ToString() + "\n");
            info += ("Luck Bonus: " + LuckBonus.ToString() + "\n");
            info += ("Speed Bonus: " + SpeedBonus.ToString() + "\n");
            info += ("Intellect Bonus: " + IntellectBonus.ToString() + "\n");
            info += ("Resistance Bonus: " + ResistanceBonus.ToString() + "\n");

            return info;
        }
        #endregion
    }
}
