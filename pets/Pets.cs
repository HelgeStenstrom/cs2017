using System;

namespace PetApplication
{
    class Pet
    {
        private string name;
        private int age;
        private bool isFemale;

        private string gender()
        {
            if (isFemale) 
            return "Female";
            else return "Male";
        }

        public void start()
        {
            Console.WriteLine("Pet is started.");
            ReadAndSavePetData();
            DisplayPetInfo();
        }

        public void ReadAndSavePetData()
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
            Console.Write("What is the age of your pet? ");
            string age = Console.ReadLine();
            return int.Parse(age);
        }

        private bool askForGender()
        {
            Console.Write("Is your pet female? (y/n) ");
            char sex = char.Parse( Console.ReadLine());
            return (sex == 'y' || sex == 'Y');
        }

        public void DisplayPetInfo()
        {
            Console.WriteLine("Pet name: " + name);
            Console.WriteLine("Pet age: " + age);
            Console.WriteLine("Pet gender: " + gender());
        }
    }
}
