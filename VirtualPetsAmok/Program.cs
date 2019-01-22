using System;

namespace VirtualPets
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualPets pet = new VirtualPets();
            
            //Quit/Start
            Console.WriteLine("Welcome to Virtual Pets Amok!\n");
            bool run = true;
            do
            {
                Console.WriteLine("Main Menu:");
                Console.WriteLine("Press 1 to Create a Pet");
                Console.WriteLine("Press 0 to Quit");

                string menuChoice = Console.ReadLine();


                switch (menuChoice)
                {
                    case "0":
                        Console.WriteLine("See you next time, friend.");
                        run = false;
                        break;

                    case "1":
                        Console.WriteLine("It's time to create your first pet");
                        pet.CreatePet();
                        break;
                }
            } while (run == true);
        }
    }
}
