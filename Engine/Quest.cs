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
        public string RequestPlayerHelp { get; set; }
        public bool IsCompleted { get; set; }

        public int Requirement { get; set; }

        public int RewardGold { get; set; }
        public int RewardExperience { get; set; }
        public Item RewardItem { get; set; }
        public Equipment RewardEquipment { get; set; }
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
    }
}
