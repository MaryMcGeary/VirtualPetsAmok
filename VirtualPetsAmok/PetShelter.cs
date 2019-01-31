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

            Console.WriteLine("\n" + pet.Name + " has joined your pet shelter!");
            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }

        public void RemovePet()
        {
            Console.WriteLine("\n\nPet Adoption Process:");
            int whichPet = PetSelectionMenu();
            switch (whichPet)
            {
                case -2:
                    foreach (VirtualPet pet in PetsList)
                    {
                        Console.WriteLine("\n" + pet.Name + " got adopted!");
                    }
                    PetsList.Clear();
                    break;
                case -1:
                    Console.WriteLine("\n\nCancelled!");
                    break;
                default:
                    Console.WriteLine("\n" + PetsList[whichPet].Name + " got adopted!");
                    PetsList.Remove(PetsList[whichPet]);
                    break;
            }

            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }

        public void DisplayAllPetsInfo()
        {
            Console.WriteLine("\n\nPet Information:");

            int whichPet = PetSelectionMenu();
            switch (whichPet)
            {
                case -2:
                    foreach (VirtualPet pet in PetsList)
                    {
                        Console.WriteLine("\n" + pet.Name + " Info: ");
                        pet.DisplayPetInfo();
                    }
                    break;
                case -1:
                    Console.WriteLine("\n\nCancelled!");
                    break;
                default:
                    PetsList[whichPet].DisplayPetInfo();
                    break;
            }

            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }

        public void DisplayAllPetsStats()
        {
            Console.WriteLine("\n\nPet Stats:");

            int whichPet = PetSelectionMenu();
            switch (whichPet)
            {
                case -2:
                    foreach (VirtualPet pet in PetsList)
                    {
                        Console.WriteLine("\n" + pet.Name + " Stats: ");
                        pet.DisplayPetStats();
                    }
                    break;
                case -1:
                    Console.WriteLine("\n\nCancelled!");
                    break;
                default:
                    PetsList[whichPet].DisplayPetStats();
                    break;
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
                        PlayWithPets();
                        break;
                    case "2":
                        FeedPets();
                        break;
                    case "3":
                        TakePetsToVet();
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
            bool redo;
            int petSelectedNum;
            string petSelection;
            do
            {
                redo = false;

                for (int i = 0; i < PetsList.Count; i++)
                {
                    int petNum = i + 1;
                    Console.WriteLine("Press " + petNum + " for " + PetsList[i].Name);
                }

                Console.WriteLine("Press A for all");
                Console.WriteLine("Press 0 to cancel\n");
                Console.WriteLine("Which pet would you like to select?");
                ConsoleKeyInfo keyPressed = Console.ReadKey();

                petSelection = "-1";

                if (char.IsDigit(keyPressed.KeyChar))
                {
                    petSelection = keyPressed.KeyChar.ToString();
                    if (Convert.ToInt32(petSelection) > PetsList.Count)
                    {
                        redo = true;
                        Console.WriteLine("\nIncorrect entry. Try again.\n");
                    }
                }
                else
                {
                    if (!keyPressed.Key.Equals(ConsoleKey.A))
                    {
                        redo = true;
                        Console.WriteLine("\nIncorrect entry. Try again.\n");
                    }
                }

                
            } while (redo);
            petSelectedNum = Convert.ToInt32(petSelection) - 1;

            return petSelectedNum;
        }

        public void PlayWithPets()
        {
            Console.WriteLine("\n\nPlay Menu:");

            int whichPet = PetSelectionMenu();
            switch (whichPet)
            {
                case -2:
                    foreach (VirtualPet pet in PetsList)
                    {
                        pet.Play();
                    }
                    break;

                case -1:
                    Console.WriteLine("\n\nCancelled!");
                    break;
                default:
                    PetsList[whichPet].Play();
                    break;
            }

            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }

        public void FeedPets()
        {
            Console.WriteLine("\n\nFeed Menu:");
            int whichPet = PetSelectionMenu();

            switch (whichPet)
            {
                case -2:
                    foreach (VirtualPet pet in PetsList)
                    {
                        pet.Feed();
                    }
                    break;
                case -1:
                    Console.WriteLine("\n\nCancelled!");
                    break;
                    
                default:
                    PetsList[whichPet].Feed();
                    break;
            }

            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }

        public void TakePetsToVet()
        {
            Console.WriteLine("\n\nVet Menu:");
            int whichPet = PetSelectionMenu();

            switch (whichPet)
            {
                case -2:
                    foreach (VirtualPet pet in PetsList)
                    {
                        pet.TakeToVet();
                    }
                    break;
                case -1:
                    Console.WriteLine("\n\nCancelled!");
                    break;
                default:
                    PetsList[whichPet].TakeToVet();
                    break;
            }

            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }

    }
}
