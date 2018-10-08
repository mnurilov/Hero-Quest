﻿using System;
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
        public Equipment(int ID, string Name, int HealthBonus = 0, int ManaBonus = 0, int AttackBonus = 0,
            int DefenseBonus = 0, int LuckBonus = 0, int SpeedBonus = 0, int IntellectBonus = 0,
            int ResistanceBonus = 0) : base(ID, Name)
        {
            this.HealthBonus = HealthBonus;
            this.ManaBonus = ManaBonus;
            this.AttackBonus = AttackBonus;
            this.DefenseBonus = DefenseBonus;
            this.LuckBonus = LuckBonus;
            this.SpeedBonus = SpeedBonus;
            this.IntellectBonus = IntellectBonus;
            this.ResistanceBonus = ResistanceBonus;
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
