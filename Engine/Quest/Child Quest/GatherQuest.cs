using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class GatherQuest : Quest
    {
        //Key is the enemy loot, Value is quantity of the enemy loot
        public Dictionary<Item, int> RequiredItems { get; set; }


        public GatherQuest(int id, string name, string description, Person questGiver, Dictionary<Item, int> requiredItems,
            int rewardGold = 0, int rewardExperience = 0, Item rewardItem = null, Equipment rewardEquipment = null,
            Spell rewardSpell = null) : base(id, name, description, questGiver, rewardGold, rewardExperience, rewardItem, rewardEquipment, rewardSpell)
        {
            this.RequiredItems = requiredItems;
        }


        public override string ToString()
        {
            string info = "";

            info += base.ToString();
            foreach (KeyValuePair<Item, int> requiredItem in RequiredItems)
            {
                info += ("Item: " + requiredItem.Key.Name + "\t" + "Quantity: " + requiredItem.Value + "\n");
            }

            return info;
        }
    }
}
