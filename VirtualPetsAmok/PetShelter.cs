using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class PetShelter
    {
        public List<VirtualPet> PetsList { get; set; }

        public PetShelter()
        {
            PetsList = new List<VirtualPet>();
        }

        public void CreateNewPet()
        {
            VirtualPet pet = new VirtualPet();

            pet.CreatePet();

            PetsList.Add(pet);
        }
        
        public void RemovePet()
        {
            int whichPet = PetSelectionMenu();
            PetsList.Remove(PetsList[whichPet]);
        }
        
        public void DisplayAllPetsInfo()
        {
            foreach (VirtualPet pet in PetsList)
            {
                Console.WriteLine("\n" + pet.Name + " Info: ");
                pet.DisplayPetInfo();
            }

            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }

        public void DisplayAllPetsStats()
        {
            foreach (VirtualPet pet in PetsList)
            {
                Console.WriteLine("\n" + pet.Name + " Stats: ");
                pet.DisplayPetStats();
            }

            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }

        public void TimeEffectAll()
        {
            foreach (VirtualPet pet in PetsList)
            {
                pet.TimeEffect();
            }
        }

        public void InteractionMenu()
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
                        PlayWithPets(PetSelectionMenu());
                        break;
                    case "2":
                        FeedPets(PetSelectionMenu());
                        break;
                    case "3":
                        TakePetsToVet(PetSelectionMenu());
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

        public int PetSelectionMenu()
        {
            Console.WriteLine("\n");

            for (int i = 0; i < PetsList.Count; i++)
            {
                int petNum = i + 1;
                Console.WriteLine("Press " + petNum + " for " + PetsList[i].Name);
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

        public void PlayWithPets(int whichPet)
        {
            if (whichPet == -1)
            {
                foreach (VirtualPet pet in PetsList)
                {
                    pet.Play();
                }
            }
            else
                PetsList[whichPet].Play();

            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }

        public void FeedPets(int whichPet)
        {
            if (whichPet == -1)
            {
                foreach (VirtualPet pet in PetsList)
                {
                    pet.Feed();
                }
            }
            else
                PetsList[whichPet].Feed();

            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }

        public void TakePetsToVet(int whichPet)
        {
            if (whichPet == -1)
            {
                foreach (VirtualPet pet in PetsList)
                {
                    pet.TakeToVet();
                }
            }
            else
                PetsList[whichPet].TakeToVet();

            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }

    }
}
