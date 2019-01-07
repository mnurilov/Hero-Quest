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

        //Tracks current status of the quest by saving the enemies defeated so far
        public Dictionary<Enemy, int> EnemiesDefeatedSoFar { get; set; }
        

        public KillQuest(int id, string name, string description, Person questGiver, Dictionary<Enemy, int> requiredEnemies,
            int rewardGold = 0, int rewardExperience = 0, Item rewardItem = null, Equipment rewardEquipment = null, 
            Spell rewardSpell = null): base(id, name, description, questGiver, rewardGold, rewardExperience, rewardItem, rewardEquipment, rewardSpell)
        {
            this.RequiredEnemies = requiredEnemies;
            EnemiesDefeatedSoFar = new Dictionary<Enemy, int>();
        }


        public override string ToString()
        {
            string info = "";

            info += base.ToString();
            foreach (KeyValuePair<Enemy, int> requiredEnemy in RequiredEnemies)
            {
                info += ("Enemy: " + requiredEnemy.Key.Name + "\t" + "Quantity: " + requiredEnemy.Value + "\n");
            }

            return info;
        }
    }
}
