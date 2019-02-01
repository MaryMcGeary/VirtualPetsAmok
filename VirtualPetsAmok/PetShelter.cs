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
            int whichPet = PetSelectionMenu("Pet Adoption");
            switch (whichPet)
            {
                case -1:
                    foreach (VirtualPet pet in PetsList)
                    {
                        Console.WriteLine("\n" + pet.Name + " got adopted!");
                    }
                    PetsList.Clear();
                    break;
                case -2:
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
            int whichPet = PetSelectionMenu("Display Info");
            switch (whichPet)
            {
                case -1:
                    foreach (VirtualPet pet in PetsList)
                    {
                        Console.WriteLine("\n" + pet.Name + " Info: ");
                        pet.DisplayPetInfo();
                    }
                    break;
                case -2:
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
            int whichPet = PetSelectionMenu("Display Stats");
            switch (whichPet)
            {
                case -1:
                    foreach (VirtualPet pet in PetsList)
                    {
                        Console.WriteLine("\n" + pet.Name + " Stats: ");
                        pet.DisplayPetStats();
                    }
                    break;
                case -2:
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
                List<string> interMenuItemsList = new List<string>()
                {
                    "PLAY WITH YOUR PET",
                    "FEED YOUR PET",
                    "TAKE PET TO VET",
                    "RETURN TO MAIN MENU"
                };

                Menu graphicMenu = new Menu();

                switch (graphicMenu.VisualMenu(interMenuItemsList, "Interaction Menu"))
                {
                    case 1:
                        PlayWithPets();
                        break;
                    case 2:
                        FeedPets();
                        break;
                    case 3:
                        TakePetsToVet();
                        break;
                    default:
                        run = false;
                        break;
                }
            } while (run);
        }

        public int PetSelectionMenu(string callingMenu)
        {
            int petSelectedNum;
            
            List<string> petSelMenuItemsList = new List<string>()
            {
                "ALL",
                "Cancel"
            };
            
            for (int i = 0; i < PetsList.Count; i++)
            {
                int petNum = i + 1;
                petSelMenuItemsList.Insert(petSelMenuItemsList.Count-1, PetsList[i].Name.ToString());
            }

            Menu petVisualMenu = new Menu();

            petSelectedNum = petVisualMenu.VisualMenu(petSelMenuItemsList,callingMenu + " | Pet Selection Menu")-2;

            if(petSelectedNum > PetsList.Count - 1)
            {
                petSelectedNum = -2;
            }

            return petSelectedNum;
        }

        public void PlayWithPets()
        {
            int whichPet = PetSelectionMenu("Play");
            switch (whichPet)
            {
                case -1:
                    foreach (VirtualPet pet in PetsList)
                    {
                        pet.Play();
                    }
                    break;

                case -2:
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
            int whichPet = PetSelectionMenu("Feed");

            switch (whichPet)
            {
                case -1:
                    foreach (VirtualPet pet in PetsList)
                    {
                        pet.Feed();
                    }
                    break;
                case -2:
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
            int whichPet = PetSelectionMenu("Vet");

            switch (whichPet)
            {
                case -1:
                    foreach (VirtualPet pet in PetsList)
                    {
                        pet.TakeToVet();
                    }
                    break;
                case -2:
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
