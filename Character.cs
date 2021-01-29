﻿using System;
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
            string gender = "default";
            string Fgender;
            bool isGood;
            Console.Write("Male or Female: ");
            Fgender = Console.ReadLine().ToLower();
            do
            {
                switch (Fgender)
                {
                    case "male":
                        isGood = true;
                        gender = "Male";
                        break;

                    case "female":
                        isGood = true;
                        gender = "Female";
                        break;

                    default:
                        isGood = false;
                        Console.WriteLine("Invalid answer");
                        break;
                }
            } while (isGood == false);

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