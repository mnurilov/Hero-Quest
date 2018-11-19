using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public Person Person { get; set; }

        //Rewards for the quest
        public int RewardGold { get; set; }
        public int RewardExperience { get; set; }
        public Item RewardItem { get; set; }
        public Equipment RewardEquipment { get; set; }
        public Spell RewardSpell { get; set; }

        public Quest(int id, string name, string description, Person person, int rewardGold = 0, int rewardExperience = 0,
            Item rewardItem = null, Equipment rewardEquipment = null, Spell rewardSpell = null)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            IsCompleted = false;
            this.Person = person;
            this.RewardGold = rewardGold;
            this.RewardExperience = rewardExperience;
            this.RewardItem = rewardItem;
            this.RewardEquipment = rewardEquipment;
            this.RewardSpell = rewardSpell;
        }

        public override string ToString()
        {
            string info = "";

            info += ("ID: " + ID.ToString() + "\n");
            info += ("Name: " + Name + "\n");
            info += ("Description: " + Description + "\n");
            info += ("Is Completed: " + IsCompleted + "\n");
            info += ("Person: " + Person.Name + "\n");
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
