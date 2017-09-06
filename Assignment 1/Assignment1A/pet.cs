// Author: Helge Stenström
// Date: 2016-09-06
// pet.cs, part of Assignment1A

// Known limitations:
// Crashes when non-numeric values are given for age.
// Crashes when not exactly one character is given to the y/n question.


using System;

namespace PetApplication
{
    public class Pet
    {
        public void start()
        {
            Console.Clear();
            Console.WriteLine("Greetings from a Pet project!");
            Console.WriteLine();

            ReadAndSavePetData();
            DisplayPetInfo();
        }

        private string name;
        private int age;
        private bool isFemale;

        private string gender()
        // I want gender to be public, so that I can test it.
        // I need at least some way to interface with the class
        // programmatically, without a user dialog.
        {
            if (isFemale) 
            return "girl";
            else return "boy";
        }

        private string good()
        {
            return name + " is a good " + gender() + "!";
        }

        private void ReadAndSavePetData()
        {
            name = askForPetName();
            age = askForAge();
            isFemale = askForGender();
        }

        private string askForPetName()
        {
            Console.Write("What is the name of your pet? ");
            return Console.ReadLine();
        }

        private int askForAge()
        {
            string greeting = "What is the age of " + name + "? ";
            Console.Write(greeting);
            string age = Console.ReadLine();
            return int.Parse(age);
        }

        private bool askForGender()
        {
            Console.Write("Is your pet female? (y/n) ");
            char response = char.Parse( Console.ReadLine());
            return (response == 'y' || response == 'Y');
        }

        private void DisplayPetInfo()
        {
            Console.WriteLine();
            Console.WriteLine("***********************");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Pet gender: " + gender());
            Console.WriteLine(good());
            Console.WriteLine("***********************");
            Console.WriteLine();
        }
    }
}
