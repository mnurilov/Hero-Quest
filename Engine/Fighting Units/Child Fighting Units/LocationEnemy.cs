using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LocationEnemy : Enemy
    {
        public int Weight;

        public LocationEnemy(Enemy enemy, int weight) : base(enemy.ID, enemy.Level, enemy.Name, enemy.MaximumHealth,
            enemy.MaximumMana, enemy.Attack, enemy.Defense, enemy.Luck, enemy.Speed, enemy.Intellect, enemy.Resistance,
            enemy.CriticalChanceRate, enemy.DodgeChanceRate, enemy.Gold, enemy.ExperiencePoints)
        {
            this.Weight = weight;
        }
    }
}
