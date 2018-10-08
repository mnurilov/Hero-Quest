using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quest
    {
        #region Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public bool IsCompleted { get; set; }

        //public int Requirement { get; set; }

        public int RewardGold { get; set; }
        public int RewardExperience { get; set; }
        public InventoryItem RewardItem { get; set; }
        public InventoryEquipment RewardEquipment { get; set; }
        public Spell RewardSpell { get; set; }
        #endregion

        #region Constructor
        public Quest(int ID, string Name, string Description)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
        }
        #endregion

        public override string ToString()
        {
            string info = "";

            info += ("ID: " + ID.ToString() + "\n");
            info += ("Name: " + Name + "\n");
            info += ("Description: " + Description + "\n");
            info += ("Reward Gold: " + RewardGold.ToString() + "\n");
            info += ("Reward Experience: " + RewardExperience.ToString() + "\n");
            if(RewardItem != null)
            {
                info += ("Reward Item: " + RewardItem.ToString() + "\n");

            }
            if (RewardEquipment != null)
            {
                info += ("Reward Equipment: " + RewardEquipment.ToString() + "\n");

            }
            if (RewardSpell != null)
            {
                info += ("Reward Spell: " + RewardSpell.ToString() + "\n");

            }

            return info;
        }
    }
}
