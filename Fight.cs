using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Fight
{
    public static class Fight
    {
        public static void Manager(string enemyName, double enemyHealth, int enemySpeed, int enemyShield)
        {
            Startup(enemyName, enemyHealth, enemySpeed, enemyShield);
        }

        public static string Startup(string enemyName, double enemyHealth, int enemySpeed, int enemyShield)
        {
            string choice;
            bool isGood;
            Console.WriteLine(enemyName + "wants  to fight you!");
            Console.WriteLine("Possible choices: fight, info, talk, run");
            Console.Write("What do you do:");
            choice = Console.ReadLine().ToLower();
            do
            {
                switch (choice)
                {
                    case "fight":
                        isGood = true;
                        Console.WriteLine("");
                        break;

                    case "info":
                        isGood = false;
                        Info(enemyName, enemyHealth, enemySpeed, enemyShield);
                        break;

                    case "talk":
                        isGood = true;
                        Console.WriteLine("You talked");
                        break;

                    case "run":
                        isGood = true;
                        Console.WriteLine("You ran away");
                        break;

                    default:
                        isGood = false;
                        Console.WriteLine("Invalid answer");
                        break;
                }

            } while (isGood == false);

            return choice;
        }

        public static void Info(string enemyName, double enemyHealth, int enemySpeed, int enemyShield)
        {
            Console.WriteLine("");
            Console.WriteLine(enemyName + ":");
            Console.WriteLine("");
            Console.WriteLine("Health: " + enemyHealth);
            Console.WriteLine("Speed: " + enemySpeed);
            Console.WriteLine("Shield: " + enemyShield);
        }
    }
}
