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

            Shower();
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
            //int timeout = 9999999;
            bool isGood;

            Console.WriteLine("You are hungry and you have go to the toilet");
            Thread.Sleep(2000);
            do
            {
                Console.Write("Go to the toilet or to the kitchen: ");
                string decision1 = Console.ReadLine().ToLower();
                Console.Clear();
                switch (decision1)
                {
                    case "toilet":
                        isGood = true;
                        Console.Beep();
                        Console.WriteLine("Going to the toilet was a good idea");
                        Thread.Sleep(1000);
                        Console.WriteLine("But you are more hungry now");
                        Thread.Sleep(3000);
                        break;

                    case "kitchen":
                        isGood = true;
                        Console.Beep();
                        Console.WriteLine("Going to the kitchen was a bad idea");
                        Thread.Sleep(1000);
                        Console.WriteLine("You pissed yourself while making a sandwitch");
                        Thread.Sleep(1000);
                        Console.WriteLine("Now you have to change your clothes");
                        Thread.Sleep(3000);
                        Console.WriteLine("You changed your clothes");
                        Thread.Sleep(3000);
                        break;

                    default:
                        isGood = false;
                        Console.WriteLine("Invalid answer");
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(1);
                            Console.Beep();
                        }
                        Thread.Sleep(750);
                        break;
                }
            } while (isGood == false);

            Console.Clear();
        }

        public static void Shower()
        {
            bool isGood;
            do
            {
                Console.Write("Do you want to go take a shower? (Y/N)");
                string decision1 = Console.ReadLine().ToLower();
                Console.Clear();

                switch (decision1)
                {
                    case "y":
                        isGood = true;
                        Console.WriteLine("You took a shower and you feel great!");
                        Console.Beep();
                        break;

                    case "n":
                        isGood = true;
                        Console.WriteLine("I mean, it's your body sooo.");
                        Console.Beep();
                        break;

                    default:
                        isGood = false;
                        Console.WriteLine("Invalid answer");
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(1);
                            Console.Beep();
                        }
                        Thread.Sleep(750);
                        break;
                }
            } while (isGood == false);

            Thread.Sleep(3000);
            Console.Clear();
        }
    }
}
