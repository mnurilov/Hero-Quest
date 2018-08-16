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
        #endregion

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

            return info;
        }
    }
}
