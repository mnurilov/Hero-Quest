using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class GatheringQuest : Quest
    {
        #region Properties
        //Possibly make this a list but ill save that for later incase I want to make a kill quest with 2 enemies as the requirement
        public EnemyLoot EnemyLootRequirement;
        //Same for this possibly make it a list so I can split the quantity requirement for enemies
        public int Quantity { get; set; }
        #endregion

        public GatheringQuest(int ID, string Name, string Description, EnemyLoot EnemyLootRequirement, int Quantity) : base(ID, Name, Description)
        {
            this.EnemyLootRequirement = EnemyLootRequirement;
            this.Quantity = Quantity;
        }

        public override string ToString()
        {
            string info = "";

            info += base.ToString();
            info += ("Enemy Loot Requirement: " + EnemyLootRequirement.ToString() + "\n");
            info += ("Quantity: " + Quantity.ToString() + "\n");

            return info;
        }
    }
}
