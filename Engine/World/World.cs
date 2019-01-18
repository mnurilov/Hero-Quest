﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        //<----------Item ID's---------->
        private const int ItemIDBasicPotion = 1;
        private const int ItemIDMegaPotion = 2;
        private const int ItemIDHyperPotion = 3;
        private const int ItemIDBasicEther = 4;
        private const int ItemIDMegaEther = 5;
        private const int ItemIDHyperEther = 6;
        private const int ItemIDRatTail = 7;
        private const int ItemIDRatCarcass = 8;
        private const int ItemIDSnakeFang = 9;
        private const int ItemIDOgreTooth = 10;
        

        private const int ItemIDApple = 12;
        private const int ItemIDMilk = 13;
        private const int ItemIDFireInJar = 14;

        //<----------Equipment ID's---------->
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
        private const int DaggerEquipmentIDBronzeDagger = 13;
        private const int NegativeHealthEquipmentID = 14;
        private const int NegativeManaEquipmentID = 15;
        private const int NegativeAttackEquipmentID = 16;
        private const int NegativeDefenseEquipmentID = 17;
        private const int NegativeLuckEquipmentID = 18;
        private const int NegativeSpeedEquipmentID = 19;
        private const int NegativeIntellectEquipmentID = 20;
        private const int NegativeResistanceEquipmentID = 21;

        //Starting Gear
        private const int HeadEquipmentIDLeatherCoif = 22;
        private const int ChestEquipmentIDLeatherBody = 23;
        private const int LegEquipmentIDLeatherChaps = 24;
        private const int SwordIDWoodenSword = 25;
        private const int StaffIDWoodenStaff = 26;
        private const int DaggerIDWoodenDagger = 27;

        //<----------Spell ID's---------->
        private const int SpellIDFire = 1;

        //<----------Vendor ID's---------->
        private const int VendorIDHermitBill = 1;

        //<----------Inn ID's---------->
        private const int InnIDRustyShack = 1;

        //<----------Enemy ID's---------->
        private const int EnemyIDAnt = 1;
        private const int EnemyIDWorm = 2;
        private const int EnemyIDBoar = 3;
        private const int EnemyIDSnake = 4;
        private const int EnemyIDSpider = 5;
        private const int EnemyIDMonkey = 6; //Boss


        //<----------Quest ID's---------->
        private const int QuestIDJimmysErrand = 1;
        private const int QuestIDCleanTheBarn = 2;
        private const int QuestIDTestLocation = 3;

        //<----------Location ID's---------->
        private const int LocationIDHome = 1;
        private const int LocationIDDirtPath = 2;
        private const int LocationIDJimmysHouse = 3;
        private const int LocationIDAppleOrchard1 = 4;
        private const int LocationIDAppleOrchard2 = 5;
        private const int LocationIDAppleOrchard3 = 6;
        private const int LocationIDHermitVillage = 7;
        private const int LocationIDFarmersHut = 8;
        private const int LocationIDFarm = 9;
        private const int LocationIDWoods1 = 10;
        private const int LocationIDWoods2 = 11;
        private const int LocationIDWoods3 = 12;
        private const int LocationIDWoods4 = 13;
        private const int LocationIDWoods5 = 14;
        private const int LocationIDRiver = 15;
        private const int LocationIDBridge = 16;
        private const int LocationIDGrassyPlains = 17;

        //<----------List's which hold all things in the game world---------->
        private static readonly List<Item> items = new List<Item>();
        private static readonly List<Equipment> equipments = new List<Equipment>();
        private static readonly List<Spell> spells = new List<Spell>();
        private static readonly List<Vendor> vendors = new List<Vendor>();
        private static readonly List<Person> persons = new List<Person>();
        private static readonly List<Inn> inns = new List<Inn>();
        private static readonly List<Enemy> enemies = new List<Enemy>();
        private static readonly List<Quest> quests = new List<Quest>();
        private static readonly List<Location> locations = new List<Location>();


        static World()
        {
            PopulateItems();
            PopulateEquipments();
            PopulateSpells();

            //Vendors must be after items, equipments, and spells so that they can have those objects in their shop
            PopulateVendors();

            PopulatePeople();

            PopulateInns();
            PopulateEnemies();
            PopulateQuests();

            //Locations are last to populate because everything else must be generated before locations
            PopulateLocations();
        }


        //Finds a specific item based on ID
        public static Item FindItemByID(int ID)
        {
            foreach (Item item in items)
            {
                if (item.ID == ID)
                {
                    return item;
                }
            }
            return null;
        }

        public static Item FindItemByName(string name)
        {
            foreach (Item item in items)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }
        
        //Finds a specific equipment piece based on ID
        public static Equipment FindEquipmentByID(int ID)
        {
            foreach (Equipment equipment in equipments)
            {
                if (equipment.ID == ID)
                {
                    return equipment;
                }
            }
            return null;
        }

        public static Equipment FindEquipmentByName(string name)
        {
            foreach (Equipment equipment in equipments)
            {
                if (equipment.Name == name)
                {
                    return equipment;
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

        public static Spell FindSpellByName(string name)
        {
            foreach (Spell spell in spells)
            {
                if (spell.Name == name)
                {
                    return spell;
                }
            }
            return null;
        }

        //Finds a specific vendor based on ID
        public static Vendor FindVendorByID(int ID)
        {
            foreach (Vendor vendor in vendors)
            {
                if (vendor.ID == ID)
                {
                    return vendor;
                }
            }
            return null;
        }

        public static Vendor FindVendorByName(string name)
        {
            foreach (Vendor vendor in vendors)
            {
                if (vendor.Name == name)
                {
                    return vendor;
                }
            }
            return null;
        }

        public static Person FindPersonByName(string name)
        {
            foreach (Person person in persons)
            {
                if (person.Name == name)
                {
                    return person;
                }
            }
            return null;
        }

        //Finds a specific inn based on ID
        public static Inn FindInnByID(int ID)
        {
            foreach (Inn inn in inns)
            {
                if (inn.ID == ID)
                {
                    return inn;
                }
            }
            return null;
        }

        public static Inn FindInnByName(string name)
        {
            foreach (Inn inn in inns)
            {
                if (inn.Name == name)
                {
                    return inn;
                }
            }
            return null;
        }

        //Finds a specific enemy based on ID
        public static Enemy FindEnemyByID(int ID)
        {
            foreach (Enemy enemy in enemies)
            {
                if (enemy.ID == ID)
                {
                    return enemy;
                }
            }
            return null;
        }

        public static Enemy FindEnemyByName(string name)
        {
            foreach (Enemy enemy in enemies)
            {
                if (enemy.Name == name)
                {
                    return enemy;
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

        public static Quest FindQuestByName(string name)
        {
            foreach (Quest quest in quests)
            {
                if (quest.Name == name)
                {
                    return quest;
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

        //Finds a specific location based on (x,y) coordinates, used for displaying the map
        public static Location FindLocationByCoordinate(int x, int y)
        {
            foreach(Location location in locations)
            {
                if(location.XCoordinate == x && location.YCoordinate == y)
                {
                    return location;
                }
            }
            return null;
        }

        //Finds a specific location based on name
        public static Location FindLocationByName(string name)
        {
            foreach (Location location in locations)
            {
                if (location.Name == name)
                {
                    return location;
                }
            }
            return null;
        }

        //<----------Population Functions----------->
        private static void PopulateItems()
        {
            //Format of Item Creation:
            //(Item ID, Name, Description, GoldValue, Optional Item Affect Value)
            items.Add(new HealthReplenishingItem(ItemIDBasicPotion, "Basic Potion", "A simple potion", 5, 5));
            items.Add(new HealthReplenishingItem(ItemIDMegaPotion, "Mega Potion", "An advanced potion", 20, 15));
            items.Add(new HealthReplenishingItem(ItemIDHyperPotion, "Hyper Potion", "An elite potion", 50, 30));
            items.Add(new ManaReplenishingItem(ItemIDBasicEther, "Basic Ether", "A simple ether", 5, 4));
            items.Add(new ManaReplenishingItem(ItemIDMegaEther, "Mega Ether", "An advanced ether", 20, 16));
            items.Add(new ManaReplenishingItem(ItemIDHyperEther, "Hyper Ether", "An elite ether", 50, 36));
            items.Add(new EnemyLoot(ItemIDRatTail, "Rat Tail", "A severed tail", 10));
            items.Add(new EnemyLoot(ItemIDSnakeFang, "Snake Fang", "A fang of a snake", 30));
            items.Add(new DamageItem(ItemIDFireInJar, "Fire in Jar", "It's a fire in a jar", 20, 20));


            items.Add(new QuestItem(ItemIDApple, "Apple", "You know what they say one a day", 3));
            items.Add(new HealthReplenishingItem(ItemIDMilk, "Milk", "Good for the bones", 5, 10));
            items.Add(new DamageItem(ItemIDFireInJar, "Fire in Jar", "It is literally fire in a jar chuck it at an enemy", 10, 20));
        }

        private static void PopulateEquipments()
        {
            //Format of Equipment Creation:
            //(Equipment ID, Name, Description, Gold Value, 
            //Health Bonus, Mana Bonus, Strength Bonus, Defense Bonus, Luck Bonus, Speed Bonus, Intellect Bonus, Resistance Bonus)
            equipments.Add(new HeadEquipment(HeadEquipmentIDBronzeHelmet, "Bronze Helmet", "A crummy helmet", 10, 5, 0, 0, 5, 0, 0, 0, 0));
            equipments.Add(new ChestEquipment(ChestEquipmentIDBronzeChestPlate, "Bronze Chest Plate", "A crummy chest plate", 10, 15, 0, 0, 15, 0, 0, 0, 0));
            equipments.Add(new LegEquipment(LegEquipmentIDBronzeLeggings, "Bronze Leggings", "A crummy leggings", 10, 1000, 0, 0, 0, 0, 0, 0, 0));
            equipments.Add(new Sword(WeaponEquipmentIDBronzeSword, "Bronze Sword", "A crummy sword", 10, 0, 0, 10, 0, 0, 0, 0, 0));
            equipments.Add(new Shield(ShieldEquipmentIDBronzeShield, "Bronze Shield", "A crummy shield", 10, 0, 0, 0, 10, 0, 0, 0, 0));
            equipments.Add(new Dagger(DaggerEquipmentIDBronzeDagger, "Bronze Dagger", "A garbage dagger", 10, 10, 10, 10, 10, 10, 10, 10, 10));
            equipments.Add(new HeadEquipment(HeadEquipmentIDRuneHelmet, "Rune Helmet", "A top tier helmet", 100, 30, 0, 5, 30, 0, -5, 0, 0));

            equipments.Add(new HeadEquipment(NegativeHealthEquipmentID, "Negative Health", "", 10, -100, 0, 0, 0, 0,0,0,0));
            equipments.Add(new ChestEquipment(NegativeManaEquipmentID, "Negative Mana", "", 10, 0, -100, 0,0,0,0,0,0));
            equipments.Add(new LegEquipment(NegativeAttackEquipmentID, "Negative Attack", "", 10, 0, 0, -100, 0,0,0,0,0));
            equipments.Add(new HeadEquipment(NegativeDefenseEquipmentID, "Negative Defense", "", 10, 0, 0, 0, -50, 0,0,0,0));
            equipments.Add(new ChestEquipment(NegativeLuckEquipmentID, "Negative Luck", "", 10, 0,0,0,0, -100,0,0,0));
            equipments.Add(new LegEquipment(NegativeSpeedEquipmentID, "Negative Speed", "", 10, 0,0,0,0,0,-100,0,0));
            equipments.Add(new HeadEquipment(NegativeIntellectEquipmentID, "Negative Intellect", "", 10,0,0,0,0,0,0,-100,0));
            equipments.Add(new ChestEquipment(NegativeResistanceEquipmentID, "Negative Resistance", "", 10, 0,0,0,0,0,0,0,-50));


            //Starting Equipment
            equipments.Add(new HeadEquipment(HeadEquipmentIDLeatherCoif, "Leather Coif", "Slightly protects your precious head", 10, 2, 0, 0, 1, 0, 0, 0, 1));
            equipments.Add(new ChestEquipment(ChestEquipmentIDLeatherBody, "Leather Body", "Slightly protects your precious body", 30, 5, 0, 0, 3, 0, 0, 0, 3));
            equipments.Add(new LegEquipment(LegEquipmentIDLeatherChaps, "Leather Chaps", "Slightly protects your precious booty", 20, 3, 0, 0, 2, 0, 0, 0, 2));
            equipments.Add(new Sword(SwordIDWoodenSword, "Wooden Sword", "It can't even cut through broccoli", 20, 0, 0, 3, 0, 0, 0, 0, 0));
            equipments.Add(new Staff(StaffIDWoodenStaff, "Wooden Staff", "Kinda small to be called a staff", 20, 0, 0, 0, 0, 0, 0, 3, 0));
            equipments.Add(new Dagger(DaggerIDWoodenDagger, "Wooden Dagger", "Is this just a t-shaped branch", 20, 0, 0, 1, 0, 1, 1, 0, 0));
        }

        private static void PopulateSpells()
        {
            //Format of Spell Creation:
            //(Spell ID, Name, Description, Gold Value, Mana Cost, Spell Affect Value)
            spells.Add(new DamageSpell(SpellIDFire, "Fire", "Summons fire to burn your enemy", 10, 3, 3));
        }

        private static void PopulateVendors()
        {
            //Format of Vendor Creation:
            //(Vendor ID, Name, Description, Optional: Item Inventory, Optional: Equipment Inventory, Optional: Spell Inventory)

            List<Equipment> hermitBillInventory = new List<Equipment>()
            {
                { FindEquipmentByName("Leather Coif")},
                {FindEquipmentByName("Leather Body")},
                {FindEquipmentByName("Leather Chaps")},
                {FindEquipmentByName("Wooden Sword")},
                {FindEquipmentByName("Wooden Staff")},
                {FindEquipmentByName("Wooden Dagger")},
            };
            Vendor hermitBill = new Vendor(VendorIDHermitBill, "Hermit Bill", "This is some good stuff right here", null, hermitBillInventory);

            vendors.Add(hermitBill);
        }

        private static void PopulatePeople()
        {
            persons.Add(new Person("Jimmy", "", "My mom needs 3 apples. So you can't pass until you get me those 3 apples!"));
            persons.Add(new Person("Bobby", "", "Don't go north! Their is a crazy monkey stopping anyone from leaving the village!"));
        }

        private static void PopulateInns()
        {
            //Format of Inn Creation:
            //(Inn ID, Name, Description, Gold Cost For Admission, Inn Keeper)

            //<----------Inn Creation---------->
            Inn rustyShack = new Inn(InnIDRustyShack, "Rusty Shack", "How long ago was this built?", 10, null);

            //<----------Add inns to the inn list---------->
            inns.Add(rustyShack); 
        }

        private static void PopulateEnemies()
        {
            //Format of Enemy Creation:
            //(Enemy ID, Name, Description, 
            //Maximum Health, Maximum Mana, Strength, Defense, Luck, Speed, Intellect, Resistance, Critical Rate, Dodge Rate,
            //Reward Gold, Reward Experience Points, Rate of Casting Spell, Optional: Weapon Used For Battle, Optional: List of Spells,
            //Optional: Enemy Loot)

            //<----------Enemy Loot Creation---------->
            Dictionary<Item, int> ratLoots = new Dictionary<Item, int>();
            ratLoots.Add(FindItemByID(7), 100);

            Dictionary<Item, int> snakeLoots = new Dictionary<Item, int>();
            snakeLoots.Add(FindItemByID(9), 50);

            //<-----------Enemy Spell Creation----------->
            List<Spell> sirenSpells = new List<Spell>();
            sirenSpells.Add(FindSpellByID(2));
            sirenSpells.Add(FindSpellByID(3));

            //<----------Enemy Creation---------->
            Enemy ant = new Enemy(EnemyIDAnt, "Ant", "To many of these things", 4, 0, 1, 0, 1, 1, 1, 1, 0, 0, 1, 1, 0, null, "head");
            Enemy worm = new Enemy(EnemyIDWorm, "Worm", "Icky slimy crawlers", 6, 0, 2, 0, 1, 1, 1, 1, 0, 0, 3, 3, 0, null, "body");
            Enemy boar = new Enemy(EnemyIDBoar, "Boar", "Is that a pig", 10, 0, 3, 3, 1, 7, 1, 4, 0, 0, 7, 7, 0, null, "tusks");
            Enemy snake = new Enemy(EnemyIDSnake, "Snake", "Slippery snek", 15, 0, 6, 2, 5, 5, 1, 3, 2, 2, 8, 8, 0, null, "tail");
            Enemy spider = new Enemy(EnemyIDSpider, "Spider", "Maybe if I let it bite me...", 15, 0, 3, 7, 1, 5, 1, 3, 2, 2, 8, 8, 0, null, "web");
            Enemy monkey = new Enemy(EnemyIDMonkey, "Monkey", "Oooo Oooo Ahhh Ahhh", 30, 10, 10, 10, 0, 10, 10, 10, 5, 5, 50, 50, 25, null);

            //<-----------Making a boss monster--------------->
            monkey.IsBoss = true;

            //<----------Add enemies to the enemy list---------->
            enemies.Add(ant);
            enemies.Add(worm);
            enemies.Add(boar);
            enemies.Add(snake);
            enemies.Add(spider);
            enemies.Add(monkey);
        }

        private static void PopulateQuests()
        {
            //Format of Quest Creation:
            //(Quest ID, Name, Description, Quest Giver, Quest Requirements, Optional: Quest Gold Reward, 
            //Optional: Quest Experience Points Reward, Optional: Quest Reward Item, Optional: Quest Reward Equipment,
            //Optional: Quest Reward Spell)


            //<-----------Quest Creation---------->
            Dictionary<Item, int> jimmysErrandRequirements = new Dictionary<Item, int>()
            {
                { FindItemByName("Apple"), 3 },
            };
            Quest jimmysErrand = new GatherQuest(QuestIDJimmysErrand, "Jimmy's Errand", "Collect 3 apples from the apple orchard", null, 
                jimmysErrandRequirements, 5, 10, null, null, FindSpellByName("Fire"));


            Dictionary<Enemy, int> cleanTheBarnRequirements = new Dictionary<Enemy, int>()
            {
                { FindEnemyByName("Boar"), 3}
            };
            Quest cleanTheBarn = new KillQuest(QuestIDCleanTheBarn, "Clean the Barn", "Kill 3 boars at the farm", null,
                cleanTheBarnRequirements, 10, 20, FindItemByName("Fire in Jar"));


            Quest testLocation = new TravelQuest(QuestIDTestLocation, "Test Location", "Go to the home", null, FindLocationByName("Home"),
                10, 10);

            
            
            /*Quest antidoteConcoction = new GatherQuest(QuestIDAntidoteConcoction, "Antidote Concoction",
                "Bring me 3 snake fangs so I can make the antidote", mary, loots,
                5, 10, null, FindEquipmentByID(4));

            Quest findTheSewers = new TravelQuest(QuestIDFindTheSewers, "Find the Sewers", "Go to the sewers and come back", garry,
                FindLocationByID(8), 10, 100, null, FindEquipmentByID(5));

            Quest fuckYoBitch = new KillQuest(4, "Fuck those Bitches", "Man bitches ain't shit but hoes and tricks", null, new Dictionary<Enemy, int>
            { { FindEnemyByID(2), 4}}, 50, 26, FindItemByID(4), FindEquipmentByID(7), FindSpellByID(3));*/

            //<----------Add quests to the quest list---------->
            quests.Add(jimmysErrand);
            quests.Add(cleanTheBarn);
            quests.Add(testLocation);
        }

        private static void PopulateLocations()
        {
            //Format of Location Creation:
            //(Location ID, Name, Description, Chance of Encountering an Enemy, X Coordinate, Y Coordinate)


            //<----------Creation of Locations----------->
            Location home = new Location(LocationIDHome, "Home", "It's your home, sadly you won't be seeing much of it", 0, 0, 0);
            Location dirtPath = new Location(LocationIDDirtPath, "Dirt Path", "A winding path", 100, 1, 0);
            Location jimmysHouse = new Location(LocationIDJimmysHouse, "Jimmy's House", "It's that little shit Jimmy's house", 0, 2, 0);
            Location appleOrchard1 = new Location(LocationIDAppleOrchard1, "Apple Orchard", "Who put all these apples here", 50, 2, -1);
            Location appleOrchard2 = new Location(LocationIDAppleOrchard2, "Apple Orchard", "Who put all these apples here", 50, 1, -1);
            Location appleOrchard3 = new Location(LocationIDAppleOrchard3, "Apple Orchard", "Who put all these apples here", 50, 2, -2);
            Location hermitVillage = new Location(LocationIDHermitVillage, "Hermit Village", "So this is where all those hermits go", 0, 3, 0);
            Location farmersHut = new Location(LocationIDFarmersHut, "Farmer's Hut", "It is a hut where a farmer resides", 0, 3, 1);
            Location farm = new Location(LocationIDFarm, "Farm", "Smells like shit", 100, 4, 1);
            Location woods1 = new Location(LocationIDWoods1, "Woods", "Who put all these trees here", 0, 2, 1);
            Location woods2 = new Location(LocationIDWoods2, "Woods", "Who put all these trees here", 60, 1, 1);
            Location woods3 = new Location(LocationIDWoods3, "Woods", "Who put all these trees here", 60, 1, 2);
            Location woods4 = new Location(LocationIDWoods4, "Woods", "Who put all these trees here", 60, 0, 1);
            Location woods5 = new Location(LocationIDWoods5, "Woods", "Who put all these trees here", 60, 0, 2);
            Location river = new Location(LocationIDRiver, "River", "Whoooooooshhhhhhh", 0, -1, 2);
            Location bridge = new Location(LocationIDBridge, "Bridge", "Connects hermit village with the outside world", 100, 2, 2);
            Location grassyPlains = new Location(LocationIDGrassyPlains, "Grassy Plains", "FREEEEEEEEDOM", 0, 2, 3);

            Person bob = new Person("Bob", "", "I think there is a treasure somewhere in the woods");
            Person marley = new Person("Marley", "", "I don't know what the fuck is going on");


            //<----------Linking up the locations---------->
            home.LocationToTheEast = dirtPath;

            dirtPath.LocationToTheWest = home;
            dirtPath.LocationToTheEast = jimmysHouse;

            jimmysHouse.LocationToTheSouth = appleOrchard1;
            jimmysHouse.LocationToTheEast = hermitVillage;
            jimmysHouse.LocationToTheWest = dirtPath;

            appleOrchard1.LocationToTheNorth = jimmysHouse;
            appleOrchard1.LocationToTheWest = appleOrchard2;
            appleOrchard1.LocationToTheSouth = appleOrchard3;

            appleOrchard2.LocationToTheEast = appleOrchard1;

            appleOrchard3.LocationToTheNorth = appleOrchard1;

            hermitVillage.LocationToTheWest = jimmysHouse;
            hermitVillage.LocationToTheNorth = farmersHut;

            farmersHut.LocationToTheSouth = hermitVillage;
            farmersHut.LocationToTheEast = farm;
            farmersHut.LocationToTheWest = woods1;

            farm.LocationToTheWest = farmersHut;

            woods1.LocationToTheNorth = bridge;
            woods1.LocationToTheWest = woods2;
            woods1.LocationToTheEast = farmersHut;

            woods2.LocationToTheEast = woods1;
            woods2.LocationToTheNorth = woods3;
            woods2.LocationToTheWest = woods4;

            woods3.LocationToTheSouth = woods2;
            woods3.LocationToTheWest = woods5;

            woods4.LocationToTheEast = woods2;
            woods4.LocationToTheNorth = woods5;

            woods5.LocationToTheEast = woods3;
            woods5.LocationToTheSouth = woods4;
            woods5.LocationToTheWest = river;

            river.LocationToTheEast = woods5;

            bridge.LocationToTheSouth = woods1;
            bridge.LocationToTheNorth = grassyPlains;

            grassyPlains.LocationToTheSouth = bridge;


            //<----------Check if player is allowed to enter------------->
            hermitVillage.IsAllowedToEnter = false;
            hermitVillage.RequiredObjectToEnter = FindQuestByName("Jimmy's Errand");

            woods1.IsAllowedToEnter = false;
            woods1.RequiredObjectToEnter = FindQuestByName("Clean the Barn");


            //<----------Adding loot to locations------------->
            home.ItemInLocation = FindItemByName("Milk");
            appleOrchard1.ItemInLocation = FindItemByName("Apple");
            appleOrchard2.ItemInLocation = FindItemByName("Apple");
            appleOrchard3.ItemInLocation = FindItemByName("Apple");
            farm.ItemInLocation = FindItemByName("Milk");
            river.ItemInLocation = FindItemByName("Fire in Jar");


            //<----------Adding people to locations------------->
            jimmysHouse.PersonInLocation = FindPersonByName("Jimmy");
            woods1.PersonInLocation = FindPersonByName("Bobby");


            //<----------Add vendors to the locations---------->
            hermitVillage.VendorInLocation = FindVendorByName("Hermit Bill");


            //<----------Add inns to the locations---------->
            hermitVillage.InnInLocation = FindInnByName("Rusty Shack");


            //<----------Add enemies to the locations---------->
            //Note: Enemy weights must be ordered from least to greatest
            dirtPath.EnemiesInLocation = new Dictionary<Enemy, int>
            {
                { FindEnemyByName("Ant"), 1 },
            };
            appleOrchard1.EnemiesInLocation = new Dictionary<Enemy, int>
            {
                { FindEnemyByName("Worm"), 1},
            };
            appleOrchard2.EnemiesInLocation = new Dictionary<Enemy, int>
            {
                { FindEnemyByName("Worm"), 1},
            };
            appleOrchard3.EnemiesInLocation = new Dictionary<Enemy, int>
            {
                { FindEnemyByName("Worm"), 1},
            };
            farm.EnemiesInLocation = new Dictionary<Enemy, int>
            {
                { FindEnemyByName("Boar"), 1},
            };
            woods2.EnemiesInLocation = new Dictionary<Enemy, int>
            {
                { FindEnemyByName("Snake"), 1 },
                { FindEnemyByName("Spider"), 1},
            };
            woods3.EnemiesInLocation = new Dictionary<Enemy, int>
            {
                { FindEnemyByName("Snake"), 1 },
                { FindEnemyByName("Spider"), 1},
            };
            woods4.EnemiesInLocation = new Dictionary<Enemy, int>
            {
                { FindEnemyByName("Snake"), 1 },
                { FindEnemyByName("Spider"), 1},
            };
            woods5.EnemiesInLocation = new Dictionary<Enemy, int>
            {
                { FindEnemyByName("Snake"), 1 },
                { FindEnemyByName("Spider"), 1},
            };
            bridge.BossInLocation = FindEnemyByName("Monkey");


            //<----------Add quests to the locations---------->
            jimmysHouse.QuestInLocation = FindQuestByName("Jimmy's Errand");
            farmersHut.QuestInLocation = FindQuestByName("Clean the Barn");
            hermitVillage.QuestInLocation = FindQuestByName("Test Location");


            //<-----------Add locations to the location list---------->
            locations.Add(home);
            locations.Add(dirtPath);
            locations.Add(jimmysHouse);
            locations.Add(appleOrchard1);
            locations.Add(appleOrchard2);
            locations.Add(appleOrchard3);
            locations.Add(hermitVillage);
            locations.Add(farmersHut);
            locations.Add(farm);
            locations.Add(woods1);
            locations.Add(woods2);
            locations.Add(woods3);
            locations.Add(woods4);
            locations.Add(woods5);
            locations.Add(river);
            locations.Add(bridge);
            locations.Add(grassyPlains);


            //Link Travel Quests with their Destination Location
            UpdateTravelQuests();
            //((TravelQuest)quests[2]).RequiredLocation = FindLocationByID(8);
        }

        private static void UpdateTravelQuests()
        {
            ((TravelQuest)FindQuestByName("Test Location")).RequiredLocation = FindLocationByName("Home");
        }
    }
}