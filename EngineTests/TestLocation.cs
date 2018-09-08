using System;
using System.Collections.Generic;
using Engine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EngineTests
{
    [TestClass]
    public class TestLocation
    {
        [TestMethod]
        public void TestEnemyEncounter()
        {
            Location testHouse = new Location(10, "Test House", "It is the land of tests", 50);
            List<LocationEnemy> locationEnemies = new List<LocationEnemy>();
            locationEnemies.Add(new LocationEnemy(World.CreateEnemy(1), 10));
            locationEnemies.Add(new LocationEnemy(World.CreateEnemy(2), 20));
            testHouse.EnemiesInLocation = locationEnemies;

            int totalWeight = 0;
            foreach (LocationEnemy lc in testHouse.EnemiesInLocation)
            {
                totalWeight += lc.Weight;
            }

            bool correct = false;

            Dictionary<string, int> result = new Dictionary<string, int>();

            LocationEnemy selectedLocationEnemy = null;

            for (int i = 0; i < 100000; i++)
            {
                selectedLocationEnemy = testHouse.GetLocationEnemy();
                if (selectedLocationEnemy != null)
                {
                    if (result.ContainsKey(selectedLocationEnemy.Name))
                    {
                        result[selectedLocationEnemy.Name] = result[selectedLocationEnemy.Name] + 1;
                    }
                    else
                    {
                        result.Add(selectedLocationEnemy.Name, 1);
                    }
                }
            }
            

            if (result["Rat"] >= (100000 / 3) - 300 && result["Rat"] <= (100000 / 3) + 300)
            {
                correct = true;
            }
            Assert.IsTrue(correct);
        }

        [TestMethod]
        public void TestLocationEncounterChance()
        {
            bool correct = false;
            Player player = new Player(1, "Test", Player.Class.Warrior);


            for (int i = 0; i < 100000; i++)
            {
                player.MoveTo(World.FindLocationByID(2));
            }

            if(player.TEST >= (100000/2) - 300 && player.TEST <= (100000/2) + 300)
            {
                correct = true;
            }
            Assert.IsTrue(correct);
        }
    }

    
}
