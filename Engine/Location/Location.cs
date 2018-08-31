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

        public List<Enemy> EnemiesInLocation = new List<Enemy>();
        public List<int> EnemiesEncounterChance = new List<int>();
        #endregion

        //Add the vendor and quest as a constructor later on
        public Location(int ID, string Name, string Description, int EncounterChance)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
            this.EncounterChance = EncounterChance;
        }

        public void 

        public Enemy GetEnemyFromList()
        {
            int randNum = RandomNumberGenerator.RandomNumberBetween(1, 100);

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
            return new Enemy();
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
