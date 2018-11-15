using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
   // public delegate void MyInputEventHandler();

    public static class InputManager
    {
        public delegate void MyInputEventHandler();

        public static event MyInputEventHandler AttackCommand;

        /*public static void ManageTravelStateInput(Player player, string playerInput)
        {
            playerInput = playerInput.ToLower();

            switch (playerInput)
            {
                case "north":
                    player.MoveNorth();
                    break;
                case "south":
                    player.MoveSouth();
                    break;
                case "west":
                    player.MoveWest();
                    break;
                case "east":
                    player.MoveEast();
                    break;
                case "shop":
                    if(player.CurrentLocation.VendorInLocation != null)
                    {
                        Console.WriteLine("You entered the shop!");
                        Player.PlayerState = Player.State.Shop;
                    }
                    else
                    {
                        Console.WriteLine("There is no vendor in this location");
                    }
                    break;
                case "view stats":
                    Console.WriteLine(player.ToString());
                    break;
                case "view inventory":
                    foreach (InventoryItem ii in player.PlayerItemInventory)
                    {
                        Console.WriteLine(ii.ToString());
                    }
                    break;
                case "use potion":
                    player.UseItem(World.FindItemByID(1));
                    break;
                case "add potion":
                    player.AddItem(World.FindItemByID(1));
                    break;
                case "add fire":
                    player.AddSpell(World.FindSpellByID(1));
                    break;
                case "add thunder":
                    player.AddSpell(World.FindSpellByID(2));
                    break;
                default:
                    Console.WriteLine("Error invalid input for traveling!");
                    break;
            }
        }*/

        private static void Attack()
        {

        }

        public static void ManageBattleStateInput(Player player, Enemy enemy, string playerInput)
        {
            playerInput = playerInput.ToLower();

            //Remove later
            string test = "";
            
            switch (playerInput)
            {
                case "attack":
                    AttackCommand();
                    Console.WriteLine("You attack");
                    enemy.CurrentHealth -= player.AttackCommand(enemy, ref test);

                    break;
                case "cast fire":
                    if (player.PlayerSpells.Contains(World.FindSpellByID(1)))
                    {
                        Console.WriteLine("You cast fire");
                        enemy.CurrentHealth -= player.SpellCommand(enemy, World.FindSpellByID(1));
                    }
                    else
                    {
                        Console.WriteLine("You don't have fire!");
                    }
                    break;
                case "cast thunder":
                    if (player.PlayerSpells.Contains(World.FindSpellByID(2)))
                    {
                        Console.WriteLine("You cast thunder");
                        enemy.CurrentHealth -= player.SpellCommand(enemy, World.FindSpellByID(2));
                    }
                    else
                    {
                        Console.WriteLine("You don't have thunder!");
                    }
                    break;
                case "view stats":
                    Console.WriteLine(enemy.ToString());
                    break;
                case "run away":
                    if (player.RunCommand(enemy))
                    {
                        Console.WriteLine("You run away");
                        Player.PlayerState = Player.State.Travel;
                    }
                    else
                    {
                        Console.WriteLine("You fail to run away");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input for battle command!");
                    break;
            }
        }

        /*public static Player ManageIntroductionStateInput()
        {
            Console.WriteLine("Welcome to the World of Blarg!");
            Console.WriteLine("You are a hero on a quest, what a surprise!");
            Console.WriteLine("Every hero needs a name.");
            Console.WriteLine("What is your name unproven hero?");
            Console.Write("Name:");
            string name;
            name = Console.ReadLine();
            bool playerNameIsCorrect = false;
            string answerToNameClarification;
            while (!playerNameIsCorrect)
            {
                Console.WriteLine("Is " + name + " the correct name?");
                Console.WriteLine("yes or no");
                answerToNameClarification = Console.ReadLine();
                answerToNameClarification = answerToNameClarification.ToLower();

                if (answerToNameClarification == "yes")
                {
                    playerNameIsCorrect = true;
                }
                else if (answerToNameClarification == "no")
                {
                    Console.WriteLine("What is your name then unproven hero?");
                    Console.Write("Name:");
                    name = Console.ReadLine();
                }
                else
                {

                }
            }

            string classChoice = "";
            Console.WriteLine("Well, " + name + " that's a pretty terrible name but, we'll move on.");
            Console.WriteLine("What class would you like to be?");
            Console.WriteLine("Warrior   |   Mage   |   Thief");
            classChoice = Console.ReadLine();
            classChoice = classChoice.ToLower();
            bool classChoiceIsCorrect = false;
            string answerToClassClarification = "";
            bool classChoiceIsDone = false;

            while (!classChoiceIsDone)
            {
                if (classChoice != "warrior" && classChoice != "mage" && classChoice != "thief")
                {
                    Console.WriteLine("Invalid class name");
                    classChoice = Console.ReadLine();
                    classChoice = classChoice.ToLower();
                }
                else
                {
                    if (!classChoiceIsCorrect)
                    {
                        Console.WriteLine("Is " + classChoice + " the correct class?");
                        Console.WriteLine("yes or no");
                        answerToClassClarification = Console.ReadLine();
                        answerToClassClarification = answerToClassClarification.ToLower();

                        if (answerToClassClarification == "yes")
                        {
                            classChoiceIsDone = true;
                        }
                        else if (answerToClassClarification == "no")
                        {
                            Console.WriteLine("What class are you then unproven hero?");
                            Console.Write("Class:");
                            classChoice = Console.ReadLine();
                        }
                        else
                        {

                        }
                    }
                }
            }

            Player.Class playerClass = Player.Class.Warrior;

            switch (classChoice)
            {
                case "warrior":
                    playerClass = Player.Class.Warrior;
                    break;
                case "mage":
                    playerClass = Player.Class.Mage;
                    break;
                case "thief":
                    playerClass = Player.Class.Thief;
                    break;
            }

            return new Player(1, name, playerClass);
        }*/

        /*public static void ManageShopStateInput(Player player, string playerInput)
        {
            playerInput = playerInput.ToLower();

            switch (playerInput)
            {
                case "buy":
                    Console.WriteLine("wow you bought the item");
                    break;
                case "sell":
                    Console.WriteLine("Wow you sold the item");
                    break;
                case "view items":
                    Console.WriteLine(player.CurrentLocation.VendorInLocation.ToString());
                    break;
                case "exit":
                    Console.WriteLine("You exit the shop");
                    Player.PlayerState = Player.State.Travel;
                    break;
                default:
                    Console.WriteLine("Invalid input for shop command!");
                    break;
            }
        }*/
    }
}
