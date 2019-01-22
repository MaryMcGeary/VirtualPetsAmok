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
                Console.WriteLine("\nMain Menu:");
                Console.WriteLine("Press 1 to Create a Pet");
                Console.WriteLine("Press 2 to Display Pet Information");
                Console.WriteLine("Press 3 to Display Pet Stats");
                Console.WriteLine("Press 0 to Quit");

                string menuChoice = Console.ReadLine();


                switch (menuChoice)
                {
                    case "0":
                        Console.WriteLine("\nSee you next time, friend.");
                        run = false;
                        break;

                    case "1":
                        Console.WriteLine("\nIt's time to create your first pet");
                        pet.CreatePet();
                        break;
                    case "2":
                        Console.WriteLine("\nPet Information:");
                        pet.DisplayPetInfo();
                        break;
                    case "3":
                        Console.WriteLine("\nPet Stats:");
                        pet.DisplayPetStats();
                        break;

                    default:
                        Console.WriteLine("\nIncorrect entry. Try again.");
                        break;
                }
            } while (run == true);
        }
    }
}
