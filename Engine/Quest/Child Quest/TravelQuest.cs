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

        //Tracks if the player has visited the desired location for the quest
        public bool HasVisitedLocation { get; set; }
        

        public TravelQuest(int id, string name, string description, Person questGiver, Location requiredLocation,
            int rewardGold = 0, int rewardExperience = 0, Item rewardItem = null, Equipment rewardEquipment = null,
            Spell rewardSpell = null) : base(id, name, description, questGiver, rewardGold, rewardExperience, rewardItem, rewardEquipment, rewardSpell)
        {
            this.RequiredLocation = requiredLocation;
            HasVisitedLocation = false;
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
