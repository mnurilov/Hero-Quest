using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class QuestItem : Item
    {
        public QuestItem(int id, string name, string description, int goldValue) : base(id, name, description, goldValue)
        {

        }
    }
}
