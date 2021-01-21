﻿using System;
using System.Threading;
using Game.Startup;
using Game.Character;
using Game.Chapter.one;

namespace ConsoleW_Engine
{
    class Game 
    {
        static void Main()
        {
            VCharacter character;
            //startup
            string gameName = "The Legend of Widrolo";
            string company = "Widrolo Games";
            string copyright = "Copyright (C) 2021 Widrolo Games - All Rights Reserved";

            Startup.Manager(gameName, company, copyright);

            //character creation

            Console.WriteLine("Create your character");
            Console.WriteLine("");

            character.firstName = Character.FirstName();
            character.lastName = Character.LastName();
            character.gender = Character.Gender();
            character.age = Character.Age();

            Character.Manager(character.firstName, character.lastName, character.gender, character.age);
            
            //chapter 1

            Chapter1.Manager(character.gender);

            //end

            Console.WriteLine("This is the end of the demo");

            Console.ReadLine();
        }
    }
}
