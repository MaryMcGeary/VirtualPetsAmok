using System;
using System.Collections.Generic;

namespace VirtualPets
{
    class Program
    {
        static void Main(string[] args)
        {
            var pets = new List<VirtualPet>();

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

                TimeEffectAll(pets);

                switch (menuChoice)
                {
                    case "0":
                        Console.WriteLine("\nSee you next time, friend.");
                        run = false;
                        break;

                    case "1":
                        Console.WriteLine("\nPet Creation:");
                        pets.Add(CreateNewPet());
                        break;
                    case "2":
                        DisplayAllPetsInfo(pets);
                        break;
                    case "3":
                        DisplayAllPetsStats(pets);
                        break;
                    case "4":
                        InteractionMenu(pets);
                        break;
                    default:
                        Console.WriteLine("\nIncorrect entry. Try again.");
                        break;
                }
            } while (run);
        }


        static void InteractionMenu(List<VirtualPet> pets)
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
                        PlayWithPets(pets, PetSelectionMenu(pets));
                        break;
                    case "2":
                        FeedPets(pets, PetSelectionMenu(pets));
                        break;
                    case "3":
                        TakePetsToVet(pets, PetSelectionMenu(pets));
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


        static VirtualPet CreateNewPet()
        {
            VirtualPet pet = new VirtualPet();

            pet.CreatePet();

            return pet;
        }


        static void DisplayAllPetsInfo(List<VirtualPet> pets)
        {
            foreach (VirtualPet pet in pets)
            {
                Console.WriteLine("\n" + pet.Name + " Info: ");
                pet.DisplayPetInfo();
            }

            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }


        static void DisplayAllPetsStats(List<VirtualPet> pets)
        {
            foreach (VirtualPet pet in pets)
            {
                Console.WriteLine("\n" + pet.Name + " Stats: ");
                pet.DisplayPetStats();
            }

            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }


        static void TimeEffectAll(List<VirtualPet> pets)
        {
            foreach (VirtualPet pet in pets)
            {
               pet.TimeEffect();
            }
        }


        static int PetSelectionMenu(List<VirtualPet> pets)
        {
            Console.WriteLine("\n");
            
            for (int i = 0; i < pets.Count; i++)
            {
                int petNum = i + 1;
                Console.WriteLine("Press " + petNum + " for " + pets[i].Name);
            }

            Console.WriteLine("Press 0 for all\n");
            Console.WriteLine("Which pet would you like to select?");
            ConsoleKeyInfo keyPressed = Console.ReadKey();

            string petSelection = "-1";

            if (char.IsDigit(keyPressed.KeyChar))
            {
                petSelection = keyPressed.KeyChar.ToString();
            }

            int petSelectedNum = Convert.ToInt32(petSelection) - 1;

            return petSelectedNum;
        }

        
        static void PlayWithPets(List<VirtualPet> pets, int whichPet)
        {
            if (whichPet == -1)
            {
                foreach (VirtualPet pet in pets)
                {
                    pet.Play();
                }
            }
            else
                pets[whichPet].Play();

            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }


        static void FeedPets(List<VirtualPet> pets, int whichPet)
        {
            if (whichPet == -1)
            {
                foreach (VirtualPet pet in pets)
                {
                    pet.Feed();
                }
            }
            else
                pets[whichPet].Feed();

            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }


        static void TakePetsToVet(List<VirtualPet> pets, int whichPet)
        {
            if (whichPet == -1)
            {
                foreach (VirtualPet pet in pets)
                {
                    pet.TakeToVet();
                }
            }
            else
                pets[whichPet].TakeToVet();

            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }
    }
}
