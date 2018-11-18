using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Statement { get; set; }

        public Person(int id, string name, string description, string statement)
        {
            this.ID = id;
            this.Name = name;
            this.Description = description;
            this.Statement = statement;
        }

        public override string ToString()
        {
            string info = "";

            info += ("ID: " + ID.ToString() + "\n");
            info += ("Name: " + Name + "\n");
            info += ("Description: " + Description + "\n");
            info += ("Statement: " + Statement + "\n");

            return info;
        }
    }
}
