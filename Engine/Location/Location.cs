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

        //Chance of encountering an enemy when travelling to this location
        public int EncounterRate { get; set; }
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public bool HasVisited { get; set; }

        //<----------Connects the locations together---------->
        public Location LocationToTheNorth { get; set; }
        public Location LocationToTheSouth { get; set; }
        public Location LocationToTheWest { get; set; }
        public Location LocationToTheEast { get; set; }

        public Person PersonInLocation { get; set; }

        public object RequiredObjectToEnter { get; set; }
        public bool IsAllowedToEnter { get; set; }

        public Item ItemInLocation { get; set; }
        public Equipment EquipmentInLocation { get; set; }
        public Spell SpellInLocation { get; set; }

        //<----------Location population---------->
        public Vendor VendorInLocation { get; set; }
        public Inn InnInLocation { get; set; }
        public Quest QuestInLocation { get; set; }

        //Key is the enemy, Value is the weight (The appearance rate of the enemy)
        public Dictionary<Enemy, int> EnemiesInLocation { get; set; }

        public Enemy BossInLocation { get; set; }


        public Location(int id, string name, string description, int encounterRate, int xCoordinate, int yCoordinate)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.EncounterRate = encounterRate;
            this.XCoordinate = xCoordinate;
            this.YCoordinate = yCoordinate;
            HasVisited = false;
            IsAllowedToEnter = true;
        }
        

        public bool HasLootInLocation()
        {
            if(ItemInLocation != null || EquipmentInLocation != null || SpellInLocation != null)
            {
                return true;
            }
            return false;
        }

        public object GiveLootInLocation()
        {
            if(ItemInLocation != null)
            {
                Item item = ItemInLocation;
                ItemInLocation = null;
                return item;
            }
            else if(EquipmentInLocation != null)
            {
                Equipment equipment = EquipmentInLocation;
                EquipmentInLocation = null;
                return equipment;
            }
            else if(SpellInLocation != null)
            {
                Spell spell = SpellInLocation;
                SpellInLocation = null;
                return spell;
            }
            else
            {
                return null;
            }
        }

        //Checks if an encounter with an enemy will be triggered 
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

        //Selects an enemy from the enemies in the dictionary based on the weights given to them
        public Enemy SelectEnemy()
        {
            if(BossInLocation != null && BossInLocation.CurrentHealth > 0)
            {
                return BossInLocation;
            }
            if(BossInLocation != null)
            {
                return null;
            }

            int totalWeight = 0;
            Enemy selectedEnemy = null;

            if (EnemiesInLocation == null)
            {
                return selectedEnemy;
            }

            //Add up all the weights of the enemies
            foreach (KeyValuePair<Enemy, int> weightedEnemy in EnemiesInLocation)
            {
                totalWeight += weightedEnemy.Value;
            }

            int randomNum = RandomNumberGenerator.RandomNumberBetween(0, totalWeight - 1);

            //Selects the enemy based on the random number rolled
            foreach (KeyValuePair<Enemy, int> weightedEnemy in EnemiesInLocation)
            {
                if (randomNum < weightedEnemy.Value)
                {
                    selectedEnemy = weightedEnemy.Key;
                    break;
                }

                randomNum = randomNum - weightedEnemy.Value;
            }

            //Generate a clone of the selected enemy and return that clone
            return CloneGenerator.CloneEnemy(selectedEnemy);
        }

        public override string ToString()
        {
            string info = "";

            info += ("ID: " + ID + "\n");
            info += ("Name: " + Name + "\n");
            info += ("Description: " + Description + "\n");
            info += ("Encounter Rate: " + EncounterRate + "\n");
            info += ("Coordinates: " + "(" + XCoordinate + ", " + YCoordinate + ")" + "\n");
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
            if(InnInLocation != null)
            {
                info += ("Inn Name: " + InnInLocation.Name + "\n");
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
            if(BossInLocation != null)
            {
                info += ("Boss Name: " + BossInLocation.Name + "\n");
            }
            return info;
        }
    }
}