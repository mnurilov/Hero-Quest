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

        public Location LocationToTheNorth;
        public Location LocationToTheSouth;
        public Location LocationToTheWest;
        public Location LocationToTheEast;

        public Vendor VendorInLocation;

        public Quest QuestInLocation;

        public List<Enemy> EnemiesInLocation = new List<Enemy>();
        #endregion

        //Add the vendor and quest as a constructor later on
        public Location(int ID, string Name, string Description)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
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
