using Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineTests
{
    [TestClass]
    public class TestPlayer
    {
        [TestMethod]
        public void TestCriticalChance()
        {
            Player player = new Player(1, "Bob", Player.Class.Thief);
            Enemy enemy = new Enemy(1, 1, "Timmy", 10, 10, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5);

            player.AttackCommand(enemy);
        }
    }
}
