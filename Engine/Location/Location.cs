using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int EncounterRate { get; set; }

        //Connects the locations together
        public Location LocationToTheNorth { get; set; }
        public Location LocationToTheSouth { get; set; }
        public Location LocationToTheWest { get; set; }
        public Location LocationToTheEast { get; set; }

        public Vendor VendorInLocation { get; set; }
        public Quest QuestInLocation { get; set; }
        //Key is the enemy, Value is the weight (The appearance rate of the enemy)
        public Dictionary<Enemy, int> EnemiesInLocation { get; set; }


        //Add the vendor and quest as a constructor later on
        public Location(int id, string name, string description, int encounterRate)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.EncounterRate = encounterRate;
        }
        
        //Checks if an encounter will be triggered 
        public bool EncounterTriggered()
        {
            if (RandomNumberGenerator.RandomNumberBetween(0, 99) < EncounterRate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Selects an enemy based on the weights given to them
        public Enemy SelectEnemy()
        {
            int totalWeight = 0;
            Enemy selectedEnemy = null;

            foreach (KeyValuePair<Enemy, int> weightedEnemy in EnemiesInLocation)
            {
                totalWeight += weightedEnemy.Value;
            }

            int randomNum = RandomNumberGenerator.RandomNumberBetween(0, totalWeight - 1);

            foreach (KeyValuePair<Enemy, int> weightedEnemy in EnemiesInLocation)
            {
                if (randomNum < weightedEnemy.Value)
                {
                    selectedEnemy = weightedEnemy.Key;
                    break;
                }

                randomNum = randomNum - weightedEnemy.Value;
            }

            return selectedEnemy;
        }

        public override string ToString()
        {
            string info = "";

            info += ("ID: " + ID.ToString() + "\n");
            info += ("Name: " + Name + "\n");
            info += ("Description: " + Description + "\n");
            info += ("Encounter Rate: " + EncounterRate.ToString() + "\n");
            if(LocationToTheNorth != null)
            {
                info += ("Location to the north: " + LocationToTheNorth.Name + "\n");
            }
            if(LocationToTheSouth != null)
            {
                info += ("Location to the south: " + LocationToTheSouth.Name + "\n");
            }
            if(LocationToTheWest != null)
            {
                info += ("Location to the west: " + LocationToTheWest.Name + "\n");
            }
            if(LocationToTheEast != null)
            {
                info += ("Location to the east: " + LocationToTheEast.Name + "\n");
            }
            if(VendorInLocation != null)
            {
                info += ("Vendor Name: " + VendorInLocation.Name + "\n");
            }
            if(QuestInLocation != null)
            {
                info += ("Quest Name: " + QuestInLocation.Name + "\n");
            }
            if(EnemiesInLocation != null)
            {
                foreach(KeyValuePair<Enemy, int> weightedEnemy in EnemiesInLocation)
                {
                    info += ("Enemy Name: " + weightedEnemy.Key.Name + "\n");
                }
            }
            return info;
        }
    }
}
