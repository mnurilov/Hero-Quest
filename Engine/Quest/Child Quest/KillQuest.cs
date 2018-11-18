using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class KillQuest : Quest
    {
        //Key is the enemy, Value is quantity of the enemy
        public Dictionary<Enemy, int> RequiredEnemies { get; set; }
        
        public KillQuest(int id, string name, string description, Person person, Dictionary<Enemy, int> requiredEnemies,
            int rewardGold = 0, int rewardExperience = 0, Item rewardItem = null, Equipment rewardEquipment = null, 
            Spell rewardSpell = null): base(id, name, description, person, rewardGold, rewardExperience, rewardItem, rewardEquipment, rewardSpell)
        {
            this.RequiredEnemies = requiredEnemies;
        }

        public override string ToString()
        {
            string info = "";

            info += base.ToString();
            foreach (KeyValuePair<Enemy, int> requiredEnemy in RequiredEnemies)
            {
                info += ("Enemy: " + requiredEnemy.Key + "Quantity: " + requiredEnemy.Value + "\n");
            }

            return info;
        }
    }
}
