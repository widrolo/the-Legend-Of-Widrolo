using System;
using System.Threading;
using Game.Startup;
using Game.Character;
using Game.Chapter.one;
using Game.Fight;

namespace ConsoleW_Engine
{
    class Game 
    {
        static void Main()
        {
            
            //startup
            string gameName = "Game";
            string company = "Widrolo Games";
            string copyright = "Copyright (C) 2021 Widrolo Games - All Rights Reserved";

            //Startup.Manager(gameName, company, copyright);

            //character creation

            Console.WriteLine("Create your character");
            Console.WriteLine("");

            string firstName = Character.FirstName();
            string lastName = Character.LastName();
            string gender = Character.Gender();
            int age = Character.Age();

            //player stats

            int playerHealth = 100;
            int playerStrength = 15;
            int playerCharisma = 4;
            int playerSpeed = 6;

            Character.Manager(firstName, lastName, gender, age);

            //chapter 1

            //Chapter1.Manager(gender);

            //end

            Fight.Manager("John", 100, 10, 15, 8, 5, playerCharisma, playerSpeed);

            Console.WriteLine("This is the end of the demo");

            Console.ReadLine();
        }
    }
}
