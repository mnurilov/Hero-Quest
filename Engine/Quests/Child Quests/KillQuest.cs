using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class KillQuest : Quest
    {
        #region Properties
        //Possibly make this a list but ill save that for later incase I want to make a kill quest with 2 enemies as the requirement
        public Enemy EnemyRequirement;
        //Same for this possibly make it a list so I can split the quantity requirement for enemies
        public int Quantity { get; set; }
        #endregion

        public KillQuest(int id, string name, string description, Enemy enemyRequirement, int quantity) 
            : base(id, name, description)
        {
            this.EnemyRequirement = enemyRequirement;
            this.Quantity = quantity;
        }

        public override string ToString()
        {
            string info = "";

            info += base.ToString();
            info += ("Enemy Requirement: " + EnemyRequirement.ToString() + "\n");
            info += ("Quantity: " + Quantity.ToString() + "\n");

            return info;
        }
    }
}
