using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class OrganicPet : VirtualPet
    {
        // Info
        
        public string Breed { get; private set; }
        public int Age { get; private set; }
        public string Color { get; private set; }

        // Stats
        public int Sickness { get; private set; }
        public int Hunger { get; private set; }
        public int Unhappiness { get; private set; }
        public int Boredom { get; private set; }

        // Construct to set stats
        public OrganicPet()
        {

        }
        public OrganicPet(string name, string type, string breed, int age, string color) : base(name, type)
        {
            // Set Stats
            Sickness = 0;
            Hunger = 0;
            Unhappiness = 0;
            Boredom = 0;
            Breed = breed;
            Age = age;
            Color = color;
        }

        public override void DisplayPetInfo()
        {
            Console.WriteLine("\nName: " + Name);
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Breed: " + Breed);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Color: " + Color);
        }

        public override void DisplayPetStats()
        {
            Console.WriteLine("\nSickness: " + Sickness);
            Console.WriteLine("Hunger: " + Hunger);
            Console.WriteLine("Unhappiness: " + Unhappiness);
            Console.WriteLine("Boredom: " + Boredom);
        }

        public void Play()
        {
            Console.WriteLine("\nYou played with your pet!");

            // Good
            if (Boredom > 0)
            {
                Boredom -= 10;
                Console.WriteLine(Name + "'s BOREDOM dropped! :)");
            }

            // Good
            if (Unhappiness > 0)
            {
                Unhappiness -= 10;
                Console.WriteLine(Name + "'s UNHAPPINESS fell! :)");
            }

            // Bad
            if (Hunger < 100)
            {
                Hunger += 10;
                Console.WriteLine(Name + "'s HUNGER rose! :(");
            }
            else if (Hunger == 100 && Sickness < 100)
            {
                Sickness += 10; // Physical activity while starving lowers health
                Console.WriteLine(Name + "'s SICKNESS rose! :(");
            }

            if (Sickness == 100)
            {
                Console.WriteLine("\nEmergency! Take your pet to the vet immediately!");
            }
        }

        public void Feed()
        {
            Console.WriteLine("\nYou fed your pet!");

            // Good
            if (Unhappiness > 0)
            {
                Unhappiness -= 10;
                Console.WriteLine(Name + "'s UNHAPPINESS fell! :)");
            }

            // Good
            if (Hunger > 0)
            {
                Hunger -= 10;
                Console.WriteLine(Name + "'s HUNGER dropped! :)");
            }
            else if (Hunger == 0 && Sickness < 100)
            {
                Sickness += 10; // Overfeed lowers health
                Console.WriteLine(Name + "'s SICKNESS rose! :(");
            }

            if (Sickness == 100)
            {
                Console.WriteLine("\nEmergency! Take your pet to the vet immediately!");
            }
        }

        public void TakeToVet()
        {
            Console.WriteLine("\nYou took your pet to the Vet!");

            // Good
            if (Sickness > 0)
            {
                Sickness = 0;
                Console.WriteLine(Name + "'s SICKNESS has been cured! :)");
            }

            // Bad
            if (Unhappiness < 100)
            {
                Unhappiness += 10;
                Console.WriteLine(Name + "'s UNHAPPINESS rose! :(");
            }

            // Bad
            if (Hunger < 100)
            {
                Hunger += 10;
                Console.WriteLine(Name + "'s HUNGER rose! :(");
            }
        }

        public override void TimeEffect()
        {
            if (Hunger < 100)
            {
                Hunger += 10;
            }
            else if (Hunger == 100 && Sickness < 100)
            {
                Sickness += 10;
            }

            if (Unhappiness < 100)
            {
                Unhappiness += 10;
            }
            else if (Unhappiness == 100 && Sickness < 100)
            {
                Sickness += 10;
            }

            if (Boredom < 100)
            {
                Boredom += 10;
            }
            else if (Boredom == 100 && Sickness < 100)
            {
                Sickness += 10;
            }

            if (Sickness == 100)
            {
                Console.WriteLine("\nEmergency! Take your pet to the vet immediately!");
            }
        }
    }
}
