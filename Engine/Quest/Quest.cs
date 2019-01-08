using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public abstract class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public Person QuestGiver { get; set; }

        //<----------Rewards for the quest---------->
        public int RewardGold { get; set; }
        public int RewardExperience { get; set; }
        public Item RewardItem { get; set; }
        public Equipment RewardEquipment { get; set; }
        public Spell RewardSpell { get; set; }
        public string Rewards { get; set; }


        public Quest(int id, string name, string description, Person questGiver, int rewardGold = 0, int rewardExperience = 0,
            Item rewardItem = null, Equipment rewardEquipment = null, Spell rewardSpell = null)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            IsCompleted = false;
            this.QuestGiver = questGiver;
            this.RewardGold = rewardGold;
            this.RewardExperience = rewardExperience;
            this.RewardItem = rewardItem;
            this.RewardEquipment = rewardEquipment;
            this.RewardSpell = rewardSpell;
            InitializeRewards();
        }

        
        private void InitializeRewards()
        {
            Rewards += ("Gold:" + "\t" + RewardGold + "\n");
            Rewards += ("Experience:" + "\t" + RewardExperience + "\n");
            if(RewardItem != null)
            {
                Rewards += ("Item:" + "\t" + RewardItem.Name + "\n");
            }
            if(RewardEquipment != null)
            {
                Rewards += ("Equipment:" + "\t" + RewardEquipment.Name + "\n");
            }
            if(RewardSpell != null)
            {
                Rewards += ("Spell:" + "\t" + RewardSpell.Name + "\n");
            }
        }


        public override string ToString()
        {
            string info = "";

            info += ("ID: " + ID + "\n");
            info += ("Name: " + Name + "\n");
            info += ("Description: " + Description + "\n");
            info += ("Is Completed: " + IsCompleted + "\n");
            info += ("Person: " + QuestGiver.Name + "\n");
            info += ("Reward Gold: " + RewardGold + "\n");
            info += ("Reward Experience: " + RewardExperience + "\n");
            if(RewardItem != null)
            {
                info += ("Reward Item: " + RewardItem.Name + "\n");

            }
            if (RewardEquipment != null)
            {
                info += ("Reward Equipment: " + RewardEquipment.Name + "\n");

            }
            if (RewardSpell != null)
            {
                info += ("Reward Spell: " + RewardSpell.Name + "\n");

            }

            return info;
        }
    }
}
