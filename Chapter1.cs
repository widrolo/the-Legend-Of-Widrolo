using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Game.Chapter.one
{
    class Chapter1
    {
        /*the managers job is to store variables
         * and put functions in the correct order,
         * not to execute code (unless its necassary)
         */

        public static void Manager(string gender)
        {
            Startup();

            Dreams(gender);

            WakeUp();

            Decision1();
        }

        public static void Startup()
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
        }

        public static void Dreams(string gender)
        {
            if (gender == "Male")
            {
                Console.WriteLine("You are sleeping in your bed and dreaming about pirates");
                Thread.Sleep(4000);
                Console.WriteLine("Maybe one day you will become a pirate");
                Thread.Sleep(5000);
            }
            else if (gender == "Female")
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
        }

        public static void WakeUp()
        {
            Console.Clear();
            Console.WriteLine("Press enter to wake up");
            Console.ReadLine();
            Console.WriteLine("You woke up");
            Thread.Sleep(2000);
            Console.Beep();
            Console.Clear();
        }

        public static void Decision1()
        {
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
                Console.WriteLine("ERROR: DECISION DOES NOT EXIST");

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
