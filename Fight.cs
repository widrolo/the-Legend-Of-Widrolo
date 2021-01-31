using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Fight
{
    public static class Fight
    {
        public static void Manager(string enemyName, double enemyHealth, int enemySpeed, int enemyShield, int enemyStrength, int enemyCharisma, int playerCharisma, int playerSpeed, int playerHealth, int playerStrength)
        {
            string choice;
            bool isGood;
            bool triedToRun = false;
            bool triedToTalk = false;
            Console.WriteLine(enemyName + " wants  to fight you!");
            do
            {
                Console.WriteLine("Possible choices: fight, info, talk, run");
                Console.Write("What do you do:");
                choice = Console.ReadLine().ToLower();

                switch (choice)
                {
                    case "fight":
                        isGood = true;
                        Console.WriteLine("");
                        break;

                    case "info":
                        isGood = false;
                        Info(enemyName, enemyHealth, enemySpeed, enemyShield, enemyStrength, enemyCharisma);
                        break;

                    case "talk":
                        isGood = Talk(enemyCharisma, playerCharisma, triedToTalk);
                        triedToTalk = true;
                        break;

                    case "run":
                        isGood = Run(enemySpeed, playerSpeed, triedToRun); ;
                        triedToRun = true;
                        break;

                    default:
                        isGood = false;
                        Console.WriteLine("Invalid answer");
                        break;
                }

            } while (isGood == false);
        }

        public static void Info(string enemyName, double enemyHealth, int enemySpeed, int enemyShield, int enemyStrength, int enemyCharisma)
        {
            Console.WriteLine("");
            Console.WriteLine(enemyName + ":");
            Console.WriteLine("");
            Console.WriteLine("Health: " + enemyHealth);
            Console.WriteLine("Strength: " + enemyStrength);
            Console.WriteLine("Speed: " + enemySpeed);
            Console.WriteLine("Shield: " + enemyShield);
            Console.WriteLine("Charisma: " + enemyCharisma);
            Console.WriteLine("");
        }

        public static bool Run(int enemySpeed, int playerSpeed, bool triedRun)
        {
            bool isGood = false;

            Console.WriteLine("");

            if (triedRun == false)
            {
                if (enemySpeed < playerSpeed)
                {
                    isGood = true;
                    Console.WriteLine("You ran away");
                }
                else
                {
                    isGood = false;
                    Console.WriteLine("You cant run away");
                }
            }
            else if (triedRun == true)
            {
                isGood = false;
                Console.WriteLine("You already tried to run away");
            }

            Console.WriteLine("");

            return isGood;
        }

        public static bool Talk(int enemyCharisma, int playerCharisma, bool triedTalk)
        {
            bool isGood = false;

            Console.WriteLine("");

            if (triedTalk == false)
            {
                if (enemyCharisma < playerCharisma)
                {
                    isGood = true;
                    Console.WriteLine("You talked your way out");
                }
                else
                {
                    isGood = false;
                    Console.WriteLine("He doesnt even listen");
                }
            }
            else if (triedTalk == true)
            {
                isGood = false;
                Console.WriteLine("You already tried to talk");
            }

            Console.WriteLine("");

            return isGood;
        }

        public static bool Fighting(double enemyHealth, int enemyShield, int enemyStrength)
        {
            bool didWin = false;



            return didWin;
        }
    }
}
