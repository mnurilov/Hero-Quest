using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        #region Data Storage
        #region Constants
        private const int EnemyIDRat = 1;
        private const int EnemyIDSnake = 2;
        private const int EnemyIDOgre = 3;
        private const int EnemyIDDragon = 4;

        private const int EnemyLootIDRatTail = 1;
        private const int EnemyLootIDRatCarcass = 2;
        private const int EnemyLootIDSnakeFang = 3;
        private const int EnemyLootIDOgreTooth = 4;

        private const int QuestIDCleanTheSewers = 1;
        private const int QuestIDAntidoteConcoction = 2;

        private const int SpellIDFire = 1;
        private const int SpellIDThunder = 2;
        private const int SpellIDCure = 3;

        private const int ItemIDBasicPotion = 1;
        private const int ItemIDMegaPotion = 2;
        private const int ItemIDHyperPotion = 3;
        private const int ItemIDBasicEther = 4;
        private const int ItemIDMegaEther = 5;
        private const int ItemIDHyperEther = 6;

        private const int LocationIDHome = 1;
        private const int LocationIDGrassPlains = 2;
        private const int LocationIDTown = 3;
        private const int LocationIDFarm = 4;
        private const int LocationIDBarn = 5;
        private const int LocationIDFarmHut = 6;

        private const int VendorIDJohn = 1;
        private const int VendorIDBobby = 2;

        private const int HeadEquipmentIDBronzeHelmet = 1;
        private const int HeadEquipmentIDRuneHelmet = 2;
        private const int ChestEquipmentIDBronzeChestPlate = 3;
        private const int ChestEquipmentIDRuneChestPlate = 4;
        private const int LegEquipmentIDBronzeLeggings = 5;
        private const int LegEquipmentIDRuneLeggings = 6;
        private const int WeaponEquipmentIDBronzeSword = 7;
        private const int WeaponEquipmentIDRuneSword = 8;
        private const int ShieldEquipmentIDBronzeShield = 9;
        private const int ShieldEquipmentIDRuneShield = 10;
        private const int TomeEquipmentIDBronzeTome = 11;
        private const int TomeEquipmentIDRuneTome = 12;
        #endregion

        #region World Objects
        private static readonly List<Enemy> enemies = new List<Enemy>();
        private static readonly List<Location> locations = new List<Location>();
        private static readonly List<Item> items = new List<Item>();
        private static readonly List<Vendor> vendors = new List<Vendor>();
        private static readonly List<Equipment> equipments = new List<Equipment>();
        private static readonly List<EnemyLoot> enemyLoots = new List<EnemyLoot>();
        private static readonly List<Spell> spells = new List<Spell>();
        private static readonly List<Quest> quests = new List<Quest>();
        #endregion
        #endregion

        #region Constructor
        static World()
        {
            PopulateItems();
            PopulateEnemyLoots();
            PopulateEquipments();
            PopulateEnemies();
            PopulateSpells();
            PopulateQuests();

            //Put the vendors after the item and equipment spawns so that it can load the items
            PopulateVendors();
            
            //Put this last because it needs everything else to be loaded first
            PopulateLocations();
        }
        #endregion

        #region Population Functions
        private static void PopulateLocations()
        {
            //Creation of locations
            Location home = new Location(LocationIDHome, "House", "Hey it's your house, it's dirty!", 0);
            Location grassPlains = new Location(LocationIDGrassPlains, "Grassy Plains", "A nice vibrant grassy plains", 50);
            Location town = new Location(LocationIDTown, "Town", "What a beautiful town", 0);
            Location farm = new Location(LocationIDFarm, "Farm", "It's a farm! Alright I'm bored back to my phone", 50);
            Location barn = new Location(LocationIDBarn, "Barn", "It smells terrible in here", 50);
            Location farmHut = new Location(LocationIDFarmHut, "Farm Hut", "It's the farmer's hut, say hello!", 100);


            //Linking up the locations
            home.LocationToTheNorth = grassPlains;

            grassPlains.LocationToTheNorth = town;
            grassPlains.LocationToTheSouth = home;

            town.LocationToTheEast = farm;
            town.LocationToTheSouth = grassPlains;

            farm.LocationToTheNorth = barn;
            farm.LocationToTheEast = farmHut;
            farm.LocationToTheWest = town;

            barn.LocationToTheSouth = farm;

            farmHut.LocationToTheWest = farm;


            //Added vendors to the locations
            town.VendorInLocation = FindVendorByID(1);
            farmHut.VendorInLocation = FindVendorByID(2);


            //Add enemies to the locations
            grassPlains.EnemiesInLocation.Add(new LocationEnemy(CreateEnemy(1), 10));
            grassPlains.EnemiesInLocation.Add(new LocationEnemy(CreateEnemy(2), 20));

            farm.EnemiesInLocation.Add(new LocationEnemy(CreateEnemy(3), 10));
            farm.EnemiesInLocation.Add(new LocationEnemy(CreateEnemy(4), 100));

            barn.EnemiesInLocation.Add(new LocationEnemy(CreateEnemy(1), 100));
            barn.EnemiesInLocation.Add(new LocationEnemy(CreateEnemy(4), 100));

            farmHut.EnemiesInLocation.Add(new LocationEnemy(CreateEnemy(2), 1));


            //Add the locations to list
            locations.Add(home);
            locations.Add(grassPlains);
            locations.Add(town);
            locations.Add(farm);
            locations.Add(barn);
            locations.Add(farmHut);
        }

        private static void PopulateItems()
        {
            items.Add(new HealthReplenishingItem(ItemIDBasicPotion, "Basic Potion", 5));
            items.Add(new HealthReplenishingItem(ItemIDMegaPotion, "Mega Potion", 15));
            items.Add(new HealthReplenishingItem(ItemIDHyperPotion, "Hyper Potion", 30));
            items.Add(new ManaReplenishingItem(ItemIDBasicEther, "Basic Ether", 4));
            items.Add(new ManaReplenishingItem(ItemIDMegaEther, "Mega Ether", 16));
            items.Add(new ManaReplenishingItem(ItemIDHyperEther, "Hyper Ether", 36));
        }

        private static void PopulateEquipments()
        {
            equipments.Add(new HeadEquipment(HeadEquipmentIDBronzeHelmet, "Bronze Helmet", 5, 0, 0, 5, 0, 0, 0, 0));
            equipments.Add(new HeadEquipment(HeadEquipmentIDRuneHelmet, "Rune Helmet", 10, 0, 0, 10, 0, 0, 0, 0));
            equipments.Add(new HeadEquipment(ChestEquipmentIDBronzeChestPlate, "Bronze Chest Plate", 15, 0, 0, 15, 0, 0, 0, 0));
            equipments.Add(new HeadEquipment(ChestEquipmentIDRuneChestPlate, "Rune Chest Plate", 30, 0, 0, 30, 0, 0, 0, 0));
            equipments.Add(new HeadEquipment(LegEquipmentIDBronzeLeggings, "Bronze Leggings", 10, 0, 0, 10, 0, 0, 0, 0));
            equipments.Add(new HeadEquipment(LegEquipmentIDRuneLeggings, "Rune Leggings", 20, 0, 0, 20, 0, 0, 0, 0));
            equipments.Add(new HeadEquipment(WeaponEquipmentIDBronzeSword, "Bronze Sword", 0, 0, 10, 0, 0, 0, 0, 0));
            equipments.Add(new HeadEquipment(WeaponEquipmentIDRuneSword, "Rune Sword", 0, 0, 0, 30, 0, 0, 0, 0));
            equipments.Add(new HeadEquipment(ShieldEquipmentIDBronzeShield, "Bronze Shield", 0, 0, 0, 0, 10, 0, 0, 0));
            equipments.Add(new HeadEquipment(ShieldEquipmentIDRuneShield, "Rune Shield", 5, 0, 0, 0, 30, 0, 0, 0));
            equipments.Add(new HeadEquipment(TomeEquipmentIDBronzeTome, "Bronze Tome", 0, 10, 0, 0, 0, 0, 15, 0));
            equipments.Add(new HeadEquipment(TomeEquipmentIDRuneTome, "Rune Tome", 0, 30, 0, 5, 0, 0, 30, 0));
        }

        private static void PopulateVendors()
        {
            Vendor John = new Vendor(VendorIDJohn, "John");
            Vendor Bobby = new Vendor(VendorIDBobby, "Bobby");

            John.VendorItemInventory.Add(new InventoryItem(FindItemByID(1), 5));
            John.VendorItemInventory.Add(new InventoryItem(FindItemByID(2), 3));
            John.VendorItemInventory.Add(new InventoryItem(FindItemByID(3), 2));

            John.VendorEquipmentInventory.Add(new InventoryEquipment(FindEquipmentByID(1), 1));
            John.VendorEquipmentInventory.Add(new InventoryEquipment(FindEquipmentByID(2), 1));
            John.VendorEquipmentInventory.Add(new InventoryEquipment(FindEquipmentByID(3), 1));
            John.VendorEquipmentInventory.Add(new InventoryEquipment(FindEquipmentByID(4), 17));
            John.VendorEquipmentInventory.Add(new InventoryEquipment(FindEquipmentByID(5), 6));
            John.VendorEquipmentInventory.Add(new InventoryEquipment(FindEquipmentByID(6), 3));

            Bobby.VendorItemInventory.Add(new InventoryItem(FindItemByID(4), 9));
            Bobby.VendorItemInventory.Add(new InventoryItem(FindItemByID(5), 7));
            Bobby.VendorItemInventory.Add(new InventoryItem(FindItemByID(6), 1)); 

            Bobby.VendorEquipmentInventory.Add(new InventoryEquipment(FindEquipmentByID(7), 12));
            Bobby.VendorEquipmentInventory.Add(new InventoryEquipment(FindEquipmentByID(8), 13));
            Bobby.VendorEquipmentInventory.Add(new InventoryEquipment(FindEquipmentByID(9), 4));
            Bobby.VendorEquipmentInventory.Add(new InventoryEquipment(FindEquipmentByID(10), 1));
            Bobby.VendorEquipmentInventory.Add(new InventoryEquipment(FindEquipmentByID(11), 9));
            Bobby.VendorEquipmentInventory.Add(new InventoryEquipment(FindEquipmentByID(12), 4));

            vendors.Add(John);
            vendors.Add(Bobby);
        }

        private static void PopulateEnemyLoots()
        {
            enemyLoots.Add(new EnemyLoot(EnemyLootIDRatTail, "Rat Tail"));
            enemyLoots.Add(new EnemyLoot(EnemyLootIDRatCarcass, "Rat Carcass"));
            enemyLoots.Add(new EnemyLoot(EnemyLootIDSnakeFang, "Snake Fang"));
            enemyLoots.Add(new EnemyLoot(EnemyLootIDOgreTooth, "Ogre Tooth"));
        }

        private static void PopulateEnemies()
        {
            Enemy rat = new Enemy(EnemyIDRat, 1, "Rat", 5, 0, 3, 0, 0, 0, 0, 0, 10, 10, 10, 10);
            Enemy snake = new Enemy(EnemyIDSnake, 3, "Snake", 5, 0, 5, 5, 10, 6, 0, 5, 15, 15, 15, 15);
            Enemy ogre = new Enemy(EnemyIDOgre, 10, "Ogre", 30, 0, 15, 10, 0, 0, 0, 0, 5, 5, 100, 100);
            Enemy dragon = new Enemy(EnemyIDDragon, 20, "Dragon", 300, 50, 100, 50, 0, 50, 0, 50, 10, 10, 1000, 1000);

            rat.LootTable.Add(FindEnemyLootByID(1));
            rat.LootTable.Add(FindEnemyLootByID(2));
            snake.LootTable.Add(FindEnemyLootByID(3));
            ogre.LootTable.Add(FindEnemyLootByID(4));

            enemies.Add(rat);
            enemies.Add(snake);
            enemies.Add(ogre);
            enemies.Add(dragon);
        }

        private static void PopulateQuests()
        {
            Quest cleanTheSewers = new KillQuest(QuestIDCleanTheSewers, "Clean the Sewers", "Kill 3 rats in the sewers to help clean out the place", FindEnemyByID(1), 3);
            cleanTheSewers.RewardGold = 10;

            Quest antidoteConcoction = new GatheringQuest(QuestIDAntidoteConcoction, "Antidote Concoction", "Bring me 3 snake fangs so I can make the antidote", FindEnemyLootByID(3), 3);

            quests.Add(cleanTheSewers);
            quests.Add(antidoteConcoction);
        }

        private static void PopulateSpells()
        {
            spells.Add(new DamageSpell(SpellIDFire, "Fire", "Summons fire to burn your enemy", 5, 10));
            spells.Add(new DamageSpell(SpellIDThunder, "Thunder", "Summons thunder to deafen your enemy", 10, 50));
            spells.Add(new ReplenishingSpell(SpellIDCure, "Cure", "Heals you", 10, 20));
        }
        #endregion

        #region View Functions
        public static void ViewSpells()
        {
            foreach (Spell spell in spells)
            {
                Console.WriteLine(spell.ToString());
                Console.ReadKey();
            }
        }

        public static void ViewItems()
        {
            foreach(Item item in items)
            {
                Console.WriteLine(item.ToString());
                Console.ReadKey();
            }
        }

        public static void ViewEquipment()
        {
            foreach (Equipment equipment in equipments)
            {
                Console.WriteLine(equipment.ToString());
                Console.ReadKey();
            }
        }

        public static void ViewQuests()
        {
            foreach(Quest quest in quests)
            {
                Console.WriteLine(quest.ToString());
                Console.ReadKey();
            }
        }

        public static void ViewEnemies()
        {
            foreach(Enemy enemy in enemies)
            {
                Console.WriteLine(enemy.ToString());
                Console.ReadKey();
            }
        }
        #endregion

        #region Find X by ID Functions
        //Finds a specific enemy loot based on ID
        public static EnemyLoot FindEnemyLootByID(int ID)
        {
            foreach (EnemyLoot enemyLoot in enemyLoots)
            {
                if (enemyLoot.ID == ID)
                {
                    return enemyLoot;
                }
            }
            return null;
        }

        //Finds a specific enemy based on ID
        public static Enemy FindEnemyByID(int ID)
        {
            foreach(Enemy enemy in enemies)
            {
                if(enemy.ID == ID)
                {
                    return enemy;
                }
            }
            return null;
        }

        //Finds a specific spell based on ID
        public static Spell FindSpellByID(int ID)
        {
            foreach(Spell spell in spells)
            {
                if(spell.ID == ID)
                {
                    return spell;
                }
            }
            return null;
        }

        //Finds a specific quest based on ID
        public static Quest FindQuestByID(int ID)
        {
            foreach(Quest quest in quests)
            {
                if(quest.ID == ID)
                {
                    return quest;
                }
            }
            return null;
        }

        //Finds a specific item based on ID
        public static Item FindItemByID(int ID)
        {
            foreach(Item item in items)
            {
                if(item.ID == ID)
                {
                    return item;
                }
            }
            return null;
        }

        //Finds a specific equipment piece based on ID
        public static Equipment FindEquipmentByID(int ID)
        {
            foreach(Equipment equipment in equipments)
            {
                if(equipment.ID == ID)
                {
                    return equipment;
                }
            }
            return null;
        }

        //Finds a specific vendor based on ID
        public static Vendor FindVendorByID(int ID)
        {
            foreach(Vendor vendor in vendors)
            {
                if(vendor.ID == ID)
                {
                    return vendor;
                }
            }
            return null;
        }

        //Finds a specific location based on ID
        public static Location FindLocationByID(int ID)
        {
            foreach (Location location in locations)
            {
                if (location.ID == ID)
                {
                    return location;
                }
            }
            return null;
        }
        #endregion

        public static Enemy CreateEnemy(int ID)
        {
            foreach (Enemy enemy in enemies)
            {
                if(enemy.ID == ID)
                {
                    return new Enemy(enemy.ID, enemy.Level, enemy.Name, enemy.MaximumHealth, enemy.MaximumMana, enemy.Attack,
                        enemy.Defense, enemy.Luck, enemy.Speed, enemy.Intellect, enemy.Resistance, enemy.CriticalChanceRate,
                        enemy.DodgeChanceRate, enemy.Gold, enemy.ExperiencePoints);
                }
            }
            return null;
        }

        public static LocationEnemy CreateNewLocationEnemy(LocationEnemy locationEnemy)
        {
            return new LocationEnemy(new Enemy(locationEnemy.ID, locationEnemy.Level, locationEnemy.Name,
                locationEnemy.MaximumHealth, locationEnemy.MaximumMana, locationEnemy.Attack,
                locationEnemy.Defense, locationEnemy.Luck, locationEnemy.Speed, locationEnemy.Intellect,
                 locationEnemy.Resistance, locationEnemy.CriticalChanceRate, locationEnemy.DodgeChanceRate,
                 locationEnemy.Gold, locationEnemy.ExperiencePoints),
                  locationEnemy.Weight);
        }
    }
}
