﻿using Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Location testHouse = new Location(10, "Test House", "It is the land of tests", 50);
            List<LocationEnemy> locationEnemies = new List<LocationEnemy>();
            locationEnemies.Add(new LocationEnemy(World.CreateEnemy(1), 10));
            locationEnemies.Add(new LocationEnemy(World.CreateEnemy(2), 20));
            locationEnemies.Add(new LocationEnemy(World.CreateEnemy(3), 30));
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

            foreach (KeyValuePair<string, int> enemy in result)
            {
                Console.WriteLine("Key: {0}\t Value: {1}\t", enemy.Key, enemy.Value);
            }
            Console.ReadKey();

            Game.Run();
        }
    }
}
