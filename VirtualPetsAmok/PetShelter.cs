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
            Console.WriteLine("What do you want to name your pet?");

            string name = Console.ReadLine();

            Console.WriteLine("What type of pet would you like, Organic or Robotic?");
            string temp = Console.ReadLine().ToLower().Remove(1);

            
            string type;
            bool error = false;

            do
            {
                if (temp == "o")
                {
                    type = "Organic";
                    OrganicPet newPet = new OrganicPet(name, type);
                    newPet.CreatePet();
                    pet = newPet;
                }
                else if (temp == "r")
                {
                    type = "Robotic";
                }
                else
                {
                    Console.WriteLine("Must enter Organic or Robotic.  Try again!");
                    error = true;
                }
            } while (error);

           
            
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

            List<string> interMenuItemsList = new List<string>()
            {
               "ORGANIC PETS",
               "ROBOTIC PETS",
               "RETURN TO MAIN MENU"
            };

            Menu graphicMenu = new Menu();

            int type = graphicMenu.VisualMenu(interMenuItemsList, "Type Selection Menu");

            do
            {
                interMenuItemsList = new List<string>();

                if (type == 1)
                {
                    interMenuItemsList.Add("PLAY WITH YOUR PET");
                    interMenuItemsList.Add("FEED YOUR PET");
                    interMenuItemsList.Add("TAKE PET TO VET");
                }
                else if(type == 2)
                {
                    interMenuItemsList.Add("PLAY WITH YOUR PET");
                    interMenuItemsList.Add("CHARGE YOUR PET");
                    interMenuItemsList.Add("TAKE PET TO MAINTENANCE");
                }
                else
                {
                    run = false;
                }
                interMenuItemsList.Add("RETURN TO MAIN MENU");

                PetTypeDict

                if (type == 1)
                {
                    switch (graphicMenu.VisualMenu(interMenuItemsList, "Organic Pet Interaction Menu"))
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
                }
                else if (type == 2)
                {
                    // ROBOT
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
                    foreach (OrganicPet pet in PetsList)
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
                    foreach (OrganicPet pet in PetsList)
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
                    foreach (OrganicPet pet in PetsList)
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
