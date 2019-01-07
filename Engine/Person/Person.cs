using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Person
    {
        public string Name { get; set; }
        public string Description { get; set; }

        //The message that the person will give to the player
        public string Statement { get; set; }    


        public Person(string name, string description, string statement)
        {
            this.Name = name;
            this.Description = description;
            this.Statement = statement;
        }


        public override string ToString()
        {
            string info = "";

            info += ("Name: " + Name + "\n");
            info += ("Description: " + Description + "\n");
            info += ("Statement: " + Statement + "\n");

            return info;
        }
    }
}
