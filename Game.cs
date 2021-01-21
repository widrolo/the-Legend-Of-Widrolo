using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleW_Engine
{
    class Game
    {

        static void Main()
        {
            //startup
            string gameName = "The Legend of Widrolo";
            string company = "Widrolo Games";
            string copyright = "Copyright (C) 2021 Widrolo Games - All Rights Reserved";

            //character
            string firstName;
            string lastName;
            string gender;
            int age;
            
            Startup(gameName, copyright);
            GameStartup(gameName, company, copyright);

            //character creation

            Console.WriteLine("Create your character");
            Console.WriteLine("");

            firstName = FirstName();
            lastName = LastName();
            gender = Gender();
            age = Age();

            ShowCharacter(firstName, lastName, gender, age);
            Thread.Sleep(5000);
            Console.Clear();

            //chapter 1

            Bedroom(gender);

            Console.WriteLine("This is the end of the demo");

            Console.ReadLine();
        }

        //startup
        public static void Startup(string gameName, string copyright)
        {
            Console.WriteLine("starting up " + gameName);
            Thread.Sleep(140);
            Console.WriteLine("");
            Console.WriteLine(copyright);
            Thread.Sleep(140);
            Console.WriteLine("");
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(700);
                Console.Write(". ");
            }
            Console.WriteLine("");
            Console.WriteLine("done");
            Console.Beep();
            Thread.Sleep(3000);
            Console.Clear();

        }

        public static void GameStartup(string gameName, string company, string copyright)
        {
            Console.WriteLine(gameName);

            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(1);
                Console.Beep();
            }

            Thread.Sleep(1500);

            Console.WriteLine("Made by " + company);

            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(1);
                Console.Beep();
            }

            Thread.Sleep(1500);

            Console.WriteLine(copyright + "    or use idk i didnt patent it");

            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(1);
                Console.Beep();
            }

            Thread.Sleep(3000);
            Console.Clear();
        }

        //character creation
        public static string FirstName()
        {
            string firstName;
            Console.Write("First name: ");
            firstName = Console.ReadLine();

            return firstName;
        }

        public static string LastName()
        {
            string lastName;
            Console.Write("Last name: ");
            lastName = Console.ReadLine();

            return lastName;
        }

        public static string Gender()
        {
            string Rgender;
            string Fgender;
            string gender;
            Console.Write("Male or Female: ");
            Rgender = (Console.ReadLine());
            Fgender = Rgender.ToLower();
            if (Fgender == "male")
            {
                gender = "Male";
            }
            else if (Fgender == "female")
            {
                gender = "Female";
            }
            else
            {
                gender = "Unknown";
            }

            return gender;
        }

        public static int Age()
        {
            int age;
            Console.Write("Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            return age;
        }

        public static void ShowCharacter(string firstName, string lastName, string gender, int age)
        {
            Console.WriteLine("");
            Console.WriteLine("This is your character:");
            Console.WriteLine("");

            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Age: " + age);
        }

        //chapter 1
        static void Bedroom(string gender)
        {
            Console.WriteLine("Chapter 1");
            Console.Beep();
            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("12.7.2019");
            Console.Beep();
            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("Home");
            Console.Beep();
            Thread.Sleep(5000);
            Console.Clear();
            Thread.Sleep(700);
            
            if ( gender == "Male" )
            {
                Console.WriteLine("You are sleeping in your bed and dreaming about pirates");
                Thread.Sleep(4000);
                Console.WriteLine("Maybe one day you will become a pirate");
                Thread.Sleep(5000);
            }
            else if ( gender == "Female" )
            {
                Console.WriteLine("You are sleeping in your bed and dreaming about princesses");
                Thread.Sleep(4000);
                Console.WriteLine("Maybe one day you will become a princess");
                Thread.Sleep(5000);
            }
            else
            {
                Console.WriteLine("You are sleeping in your bed and dreaming about genders");
                Thread.Sleep(4000);
                Console.WriteLine("Maybe one day you will get a gender");
                Thread.Sleep(5000);
            }

            Console.Clear();
            Console.WriteLine("Press enter to wake up");
            Console.ReadLine();
            Console.WriteLine("You woke up");
            Thread.Sleep(2000);
            Console.Beep();
            Console.Clear();

            //decision
            int timeout = 9999999;

            Console.WriteLine("You are hungry and you have go go to the toilet");
            Thread.Sleep(2000);
            Console.Write("Go to the toilet or to the kitchen: ");
            string decision1 = Console.ReadLine().ToLower();
            Console.Clear();
            if (decision1 == "toilet")
            {
                Console.Beep();
                Console.WriteLine("Going to the toilet was a good idea");
                Thread.Sleep(1000);
                Console.WriteLine("But you are more hungry now");
                Thread.Sleep(3000);
            }
            else if (decision1 == "kitchen")
            {
                Console.Beep();
                Console.WriteLine("Going to the kitchen was a bad idea");
                Thread.Sleep(1000);
                Console.WriteLine("You pissed yourself while making a sandwitch");
                Thread.Sleep(1000);
                Console.WriteLine("Now you have to change your clothes");
                Thread.Sleep(3000);
                Console.WriteLine("You changed your clothes");
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine("ERROR: TIMEOUT_DURING_DECISION_NOT_EXIST");

                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(1);
                    Console.Beep();
                }

                Thread.Sleep(timeout);
                Thread.Sleep(timeout);
                Thread.Sleep(timeout);
                Thread.Sleep(timeout);
                Thread.Sleep(timeout);
                Thread.Sleep(timeout);
            }


        }
    }
}
