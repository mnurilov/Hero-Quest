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
        public Dictionary<EnemyLoot, int> RequiredEnemyLoots { get; set; }


        public GatherQuest(int id, string name, string description, Person person, Dictionary<EnemyLoot, int> requiredEnemyLoots,
            int rewardGold = 0, int rewardExperience = 0, Item rewardItem = null, Equipment rewardEquipment = null,
            Spell rewardSpell = null) : base(id, name, description, person, rewardGold, rewardExperience, rewardItem, rewardEquipment, rewardSpell)
        {
            this.RequiredEnemyLoots = requiredEnemyLoots;
        }

        public override string ToString()
        {
            string info = "";

            info += base.ToString();
            foreach (KeyValuePair<EnemyLoot, int> requiredEnemyLoot in RequiredEnemyLoots)
            {
                info += ("Enemy Loot: " + requiredEnemyLoot.Key.Name + "\t" + "Quantity: " + requiredEnemyLoot.Value + "\n");
            }

            return info;
        }
    }
}
