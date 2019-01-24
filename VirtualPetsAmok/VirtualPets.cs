using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPets
{
    public class VirtualPet
    {  
        // Info
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        // Stats
        public int Health { get; set; }
        public int Hunger { get; set; }
        public int Happiness { get; set; }
        public int Boredom { get; set; }

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
            Console.WriteLine("Color: " + Color + "\n");
        }

        public void DisplayPetStats()
        {
            Console.WriteLine("\nHealth: " + Health);
            Console.WriteLine("Hunger: " + Hunger);
            Console.WriteLine("Happiness: " + Happiness);
            Console.WriteLine("Boredom: " + Boredom + "\n");
        }

        public void Play()
        {
            Console.WriteLine("You played with your pet!");

            // Good
            if (Boredom > 0)
                Boredom -= 10;

            // Bad
            if (Happiness < 100)
                Happiness += 10;

            // Bad
            if (Hunger < 100)
                Hunger += 10;
            else if (Hunger == 100)
                Health -= 10; // Physical activity while starving lowers health
        }

        public void Feed()
        {
            Console.WriteLine("You fed your pet!");

            // Good
            if (Happiness < 100)
                Happiness += 10;

            // Good
            if (Hunger > 0)
                Hunger -= 10;
            else if (Hunger == 0)
                Health -= 10; // Overfeed lowers health
        }

        public void TakeToVet()
        {
            Console.WriteLine("You took your pet to the Vet!");

            // Good
            if (Health < 100)
                Health = 100;

            // Bad
            if (Happiness > 0)
                Happiness -= 10;

            // Bad
            if (Hunger < 100)
                Hunger += 10;
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
                Console.WriteLine("\nEmergency! Take your pet to the vet immediately!\n");
        }
    }

}
