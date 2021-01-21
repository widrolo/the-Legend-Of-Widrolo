using System;
using System.Collections.Generic;
using System.Text;
using System.Threading; 

namespace Game.Character
{
    public struct VCharacter
    {
        public string firstName;
        public string lastName;
        public string gender;
        public int age;
    }

    public class Character
    {
        /*the managers job is to store variables
         * and put functions in the correct order,
         * not to execute code (unless its necassary)
         */

        public static void Manager(string firstName, string lastName, string gender, int age)
        {
            ShowCharacter(firstName, lastName, gender, age);
        }

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

            Thread.Sleep(5000);
            Console.Clear();
        }
    }
}
