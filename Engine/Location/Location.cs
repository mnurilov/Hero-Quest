using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location
    {
        #region Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int EncounterChance { get; set; }

        public Location LocationToTheNorth;
        public Location LocationToTheSouth;
        public Location LocationToTheWest;
        public Location LocationToTheEast;

        public Vendor VendorInLocation;

        public Quest QuestInLocation;

        public LocationEnemy CurrentEnemy;

        public List<LocationEnemy> EnemiesInLocation = new List<LocationEnemy>();
        #endregion

        //Add the vendor and quest as a constructor later on
        public Location(int ID, string Name, string Description, int EncounterChance)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.EncounterChance = EncounterChance;
        }

        public bool EncounterTriggered()
        {
            if (RandomNumberGenerator.RandomNumberBetween(0, 99) < EncounterChance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SetLocationEnemy()
        {
            CurrentEnemy = GetLocationEnemy();
        }

        public LocationEnemy GetLocationEnemy()
        {
            int totalWeight = 0;
            foreach (LocationEnemy lc in EnemiesInLocation)
            {
                totalWeight += lc.Weight;
            }

            int randomNum = RandomNumberGenerator.RandomNumberBetween(0, totalWeight - 1);

            LocationEnemy selectedLocationEnemy = null;

            foreach (LocationEnemy lc in EnemiesInLocation)
            {
                if (randomNum < lc.Weight)
                {
                    selectedLocationEnemy = lc;
                    break;
                }

                randomNum = randomNum - lc.Weight;
            }

            return selectedLocationEnemy;
            /*int randNum = RandomNumberGenerator.RandomNumberBetween(1, 100);

            for (int i = 0; i < EnemiesInLocation.Count; i++)
            {
                if(i == 0)
                {
                    continue;
                }

                EnemiesInLocation[i].EncounterRate = EnemiesInLocation[i].EncounterRate + EnemiesInLocation[i - 1].EncounterRate;
            }

            for (int i = 0; i < EnemiesInLocation.Count; i++)
            {
                if(i == 0)
                {
                    if(randNum > 0 && randNum <= EnemiesInLocation[i].EncounterRate)
                    {

                    }
                }
                else if(randNum > EnemiesInLocation[i].EncounterRate && randNum <= EnemiesInLocation[i + 1].EncounterRate)
                {

                }
            }
            return new Enemy();*/
        }

        public override string ToString()
        {
            string info = "";

            info += ("ID: " + ID.ToString() + "\n");
            info += ("Name: " + Name.ToString() + "\n");
            info += ("Description: " + Description.ToString() + "\n");

            if(VendorInLocation != null)
            {
                info += ("Vendor Details: " + VendorInLocation.ToString() + "\n");
            }
            if(QuestInLocation != null)
            {
                info += ("Quest Details: " + QuestInLocation.ToString() + "\n");
            }
            if(EnemiesInLocation != null)
            {
                foreach(Enemy enemy in EnemiesInLocation)
                {
                    info += ("Enemy Details: " + enemy.ToString() + "\n");
                }
            }
            return info;
        }
    }
}
