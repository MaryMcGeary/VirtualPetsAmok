using System;

namespace VirtualPets
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualPet pet = new VirtualPet();
            
            // Quit/Start
            Console.WriteLine("Welcome to Virtual Pets Amok!");
            bool run = true;
            do
            {
                Console.Clear();

                Console.WriteLine("\nMain Menu:");
                Console.WriteLine("Press 1 to Create a Pet");
                Console.WriteLine("Press 2 to Display Pet Information");
                Console.WriteLine("Press 3 to Display Pet Stats");
                Console.WriteLine("Press 4 to interact with pet");
                Console.WriteLine("Press 0 to Quit");

                string menuChoice;

                ConsoleKeyInfo keyPressed = Console.ReadKey();

                if (char.IsDigit(keyPressed.KeyChar))
                {
                    menuChoice = keyPressed.KeyChar.ToString();
                }
                else
                {
                    menuChoice = "default";
                }
                
                pet.TimeEffect();

                switch (menuChoice)
                {
                    case "0":
                        Console.WriteLine("\nSee you next time, friend.");
                        run = false;
                        break;

                    case "1":
                        Console.WriteLine("\nPet Creation:");
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
                    case "4":
                        InteractionMenu(pet);
                        break;
                    default:
                        Console.WriteLine("\nIncorrect entry. Try again.");
                        break;
                }
            } while (run);
        }


        static void InteractionMenu(VirtualPet pet)
        {           
            bool run = true;

            do
            {
                Console.Clear();

                Console.WriteLine("\nInteraction Menu:");
                Console.WriteLine("Press 1 to play with your pet.");
                Console.WriteLine("Press 2 to feed your pet.");
                Console.WriteLine("Press 3 to bring your pet to the vet.");
                Console.WriteLine("Press 0 to go back to the Main Menu.");

                string interMenuChoice;

                ConsoleKeyInfo interKeyPressed = Console.ReadKey();

                if (char.IsDigit(interKeyPressed.KeyChar))
                {
                    interMenuChoice = interKeyPressed.KeyChar.ToString();
                }
                else
                {
                    interMenuChoice = "default";
                }
                
                switch (interMenuChoice)
                {
                    case "1":
                        pet.Play();
                        break;
                    case "2":
                        pet.Feed();
                        break;
                    case "3":
                        pet.TakeToVet();
                        break;
                    case "0":
                        run = false;
                        break;
                    default:
                        Console.WriteLine("\nIncorrect entry. Try again.");
                        break;                                       
                }
            } while (run);
        }
    }
}
