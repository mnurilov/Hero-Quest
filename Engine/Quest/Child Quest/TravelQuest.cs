using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class TravelQuest : Quest
    {
        //Required location to complete the quest
        public Location RequiredLocation { get; set; }
        
        public TravelQuest(int id, string name, string description, Person person, Location requiredLocation,
            int rewardGold = 0, int rewardExperience = 0, Item rewardItem = null, Equipment rewardEquipment = null,
            Spell rewardSpell = null) : base(id, name, description, person, rewardGold, rewardExperience, rewardItem, rewardEquipment, rewardSpell)
        {
            this.RequiredLocation = requiredLocation;
        }

        public override string ToString()
        {
            string info = "";

            info += base.ToString();
            info += ("Required Location: " + RequiredLocation.Name + "\n");

            return info;
        }
    }
}
