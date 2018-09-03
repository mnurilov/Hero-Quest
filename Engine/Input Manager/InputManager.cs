using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class InputManager
    {
        public static void ManageTravelStateInput(Player player, string playerInput)
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
                    Console.WriteLine("You entered the shop!");
                    Player.PlayerState = Player.State.Shop;
                    break;
                default:
                    Console.WriteLine("Error invalid input for traveling!");
                    break;
            }
        }

        public static void ManageBattleStateInput(Player player, Enemy enemy, string playerInput)
        {
            playerInput = playerInput.ToLower();

            switch (playerInput)
            {
                case "attack":
                    Console.WriteLine("You attack");
                    player.AttackCommand(enemy);
                    break;
                case "spell":
                    Console.WriteLine("You cast a spell");
                    player.SpellCommand(enemy);
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

        public static Player ManageIntroductionStateInput()
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
        }

        public static void ManageShopStateInput(Player player, string playerInput)
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
                case "exit":
                    Console.WriteLine("You exit the shop");
                    Player.PlayerState = Player.State.Travel;
                    break;
                default:
                    Console.WriteLine("Invalid input for shop command!");
                    break;
            }
        }
    }
}
