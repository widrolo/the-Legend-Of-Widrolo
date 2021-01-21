using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Game.Startup
{
    class Startup
    {
        /*the managers job is to store variables
         * and put functions in the correct order,
         * not to execute code (unless its necassary)
         */

        public static void Manager(string gameName, string company, string copyright)
        {
            VStartup(gameName, copyright);
            GameStartup(gameName, company, copyright);
        }

        public static void VStartup(string gameName, string copyright)
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
    }
}
