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
    public class TestStates
    {
        [TestMethod]
        public void TestTurnDeterminer()
        {
            BattleState bs = new BattleState();
            Player player = new Player(1, "Bob", Player.Class.Thief);
            Enemy enemy = new Enemy(1, 1, "Tom", 10, 10, 5, 5, 5, 6, 5, 5, 5, 5, 5, 5);

            int counter = 0;

            for (int i = 0; i < 100000; i++)
            {
                bs.DetermineTurn(player, enemy);

                if (bs.playerTurn == true)
                {
                    counter++;
                }
                else
                {

                }
            }

            if (counter >= 49500 && counter <= 50500)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }


        }
    }
}
