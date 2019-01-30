using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class VirtualPet
    {  
        // Info
        public string Name { get; private set; }
        public string Breed { get; private set; }
        public int Age { get; private set; }
        public string Color { get; private set; }

        // Stats
        public int Health { get; private set; }
        public int Hunger { get; private set; }
        public int Happiness { get; private set; }
        public int Boredom { get; private set; }

        // Construct to set stats
        public VirtualPet()
        {
            // Set Stats
            Health = 100;
            Hunger = 0;
            Happiness = 100;
            Boredom = 0;
        }

        public void CreatePet()
        {
            // Get info
            Console.WriteLine("\nWhat is your pet's name?");
            Name = Console.ReadLine();

            Console.WriteLine("What breed is your pet?");
            Breed = Console.ReadLine();

            Console.WriteLine("How old is your pet");
            Age = Convert.ToInt32(Console.ReadLine());  

            Console.WriteLine("What color is your pet");
            Color = Console.ReadLine();   
        }

        public void DisplayPetInfo()
        {
            Console.WriteLine("\nName: " + Name);
            Console.WriteLine("Breed: " + Breed);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Color: " + Color);
        }

        public void DisplayPetStats()
        {
            Console.WriteLine("\nHealth: " + Health);
            Console.WriteLine("Hunger: " + Hunger);
            Console.WriteLine("Happiness: " + Happiness);
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
            if (Happiness < 100)
            {
                Happiness += 10;
                Console.WriteLine(Name + "'s HAPPINESS rose! :)");
            }

            // Bad
            if (Hunger < 100)
            {
                Hunger += 10;
                Console.WriteLine(Name + "'s HUNGER rose! :(");
            }
            else if (Hunger == 100 && Health > 0)
            {
                Health -= 10; // Physical activity while starving lowers health
                Console.WriteLine(Name + "'s HEALTH dropped! :(");
            }

            if (Health == 0)
                Console.WriteLine("\nEmergency! Take your pet to the vet immediately!");
        }

        public void Feed()
        {
            Console.WriteLine("\nYou fed your pet!");

            // Good
            if (Happiness < 100)
            {
                Happiness += 10;
                Console.WriteLine(Name + "'s HAPPINESS rose! :)");
            }

            // Good
            if (Hunger > 0)
            {
                Hunger -= 10;
                Console.WriteLine(Name + "'s HUNGER dropped! :)");
            }
            else if (Hunger == 0 && Health > 0)
            {
                Health -= 10; // Overfeed lowers health
                Console.WriteLine(Name + "'s HEALTH dropped! :(");
            }

            if (Health == 0)
                Console.WriteLine("\nEmergency! Take your pet to the vet immediately!");
        }

        public void TakeToVet()
        {
            Console.WriteLine("\nYou took your pet to the Vet!");

            // Good
            if (Health < 100)
            {
                Health = 100;
                Console.WriteLine(Name + "'s HEALTH has been restored! :)");
            }

            // Bad
            if (Happiness > 0)
            {
                Happiness -= 10;
                Console.WriteLine(Name + "'s HAPPINESS dropped! :(");
            }

            // Bad
            if (Hunger < 100)
            {
                Hunger += 10;
                Console.WriteLine(Name + "'s HUNGER rose! :(");
            }
        }

        public void TimeEffect()
        {
            if (Hunger < 100)
                Hunger += 10;
            else if (Hunger == 100 && Health > 0)
                Health -= 10;

            if (Happiness > 0)
                Happiness -= 10;
            else if (Happiness == 0 && Health > 0)
                Health -= 10;

            if (Boredom < 100)
                Boredom += 10;
            else if (Boredom == 100 && Health > 0)
                Health -= 10;

            if (Health == 0)
                Console.WriteLine("\nEmergency! Take your pet to the vet immediately!");
        }
    }
}
