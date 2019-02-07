using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualPetsAmok
{
    public class PetShelter
    {
        public List<VirtualPet> PetsList { get; set; }

        VirtualPet newPet;

        public PetShelter()
        {
            PetsList = new List<VirtualPet>();
        }

        public void CreateNewPet()
        {
            
            Console.WriteLine("What do you want to name your pet?");

            string name = Console.ReadLine();
            bool error = false;
            string temp = "";

            do
            {
                Console.WriteLine("What type of pet would you like, Organic or Robotic?");
                temp = Console.ReadLine().ToLower().Remove(1);

                if (temp != "o" && temp != "r")
                {
                    error = true;
                }
                else
                {
                    error = false;
                }

            } while (error);


            string type;

            do
            {
                if (temp == "o")
                {
                    type = "Organic";
                    int proceedOkay;
                    string breed = "";
                    int age = 0;
                    string color = "";
                    for (int questionNum = 0; questionNum < 3; questionNum += proceedOkay)
                    {
                        proceedOkay = 0;
                        string errorCheck;
                        int number;
                        switch (questionNum)
                        {
                            case 0:
                                Console.WriteLine("What breed is your pet?");
                                errorCheck = Console.ReadLine();
                                if (errorCheck.Length > 0 && !int.TryParse(errorCheck, out number))
                                {
                                    breed = errorCheck;
                                    proceedOkay = 1;
                                }
                                break;

                            case 1:
                                Console.WriteLine("How old is your pet");
                                errorCheck = Console.ReadLine();
                                if (errorCheck.Length > 0 && int.TryParse(errorCheck, out number))
                                {
                                    age = Convert.ToInt32(errorCheck);
                                    proceedOkay = 1;
                                }
                                break;

                            case 2:
                                Console.WriteLine("What color is your pet");
                                errorCheck = Console.ReadLine();
                                if (errorCheck.Length > 0)
                                {
                                    color = errorCheck;
                                    proceedOkay = 1;
                                }
                                break;
                        }
                    }
                    newPet = new OrganicPet(name, type, breed, age, color);
                    PetsList.Add(newPet);
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
            
            

            Console.WriteLine("\n" + newPet.Name + " has joined your pet shelter!");
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
                    Console.WriteLine("\n\nCanceled!");
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
                    Console.WriteLine("\n\nCanceled!");
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
                    Console.WriteLine("\n\nCanceled!");
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

        public void TypeSelectionMenu()
        {
            List<string> interMenuItemsList = new List<string>()
            {
               "ORGANIC PETS",
               "ROBOTIC PETS",
               "RETURN TO MAIN MENU"
            };

            Menu graphicMenu = new Menu();

            int type = graphicMenu.VisualMenu(interMenuItemsList, "Type Selection Menu");

            if(type == 1)
            {
                OrganicInteractionMenu();
            }
            else if (type == 2)
            {
                RoboticInteractionMenu();
            }
            
        }

        public void OrganicInteractionMenu()
        {
            bool run = true;
            
            Menu graphicMenu = new Menu();
            
            do
            {
                List<string> interMenuItemsList = new List<string>()
                {
                    "PLAY WITH YOUR PET",
                    "FEED YOUR PET",
                    "TAKE PET TO VET",
                    "RETURN TO MAIN MENU"
                };


                var organicList = PetsList.OfType<OrganicPet>().ToList();

                switch (graphicMenu.VisualMenu(interMenuItemsList, "Organic Pet Interaction Menu"))
                {
                    case 1:
                        PlayWithPets(organicList);
                        break;
                    case 2:
                        FeedPets(organicList);
                        break;
                    case 3:
                        TakePetsToVet(organicList);
                        break;
                    default:
                        run = false;
                        break;
                }
                
            } while (run);
        }

        public void RoboticInteractionMenu()
        {
            bool run = true;

            Menu graphicMenu = new Menu();

            do
            {
                List<string> interMenuItemsList = new List<string>()
                {
                    "PLAY WITH YOUR PET",
                    "CHARGE YOUR PET",
                    "TAKE PET TO REPAIR SHOP",
                    "RETURN TO MAIN MENU"
                };


                switch (graphicMenu.VisualMenu(interMenuItemsList, "Organic Pet Interaction Menu"))
                {
                    case 1:
                        //PlayWithPets();
                        break;
                    case 2:
                        //FeedPets();
                        break;
                    case 3:
                        //TakePetsToVet();
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

        public void PlayWithPets(List<OrganicPet> organicList)
        {
            int whichPet = PetSelectionMenu("Play");
            switch (whichPet)
            {
                case -1:
                    foreach (OrganicPet pet in organicList)
                    {
                        pet.Play();
                    }
                    break;

                case -2:
                    Console.WriteLine("\n\nCanceled!");
                    break;
                default:
                    organicList[whichPet].Play();
                    break;
            }

            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }

        public void FeedPets(List<OrganicPet> organicList)
        {
            int whichPet = PetSelectionMenu("Feed");

            switch (whichPet)
            {
                case -1:
                    foreach (OrganicPet pet in organicList)
                    {
                        pet.Feed();
                    }
                    break;
                case -2:
                    Console.WriteLine("\n\nCanceled!");
                    break;
                    
                default:
                    organicList[whichPet].Feed();
                    break;
            }

            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }

        public void TakePetsToVet(List<OrganicPet> organicList)
        {
            int whichPet = PetSelectionMenu("Vet");

            switch (whichPet)
            {
                case -1:
                    foreach (OrganicPet pet in organicList)
                    {
                        pet.TakeToVet();
                    }
                    break;
                case -2:
                    Console.WriteLine("\n\nCanceled!");
                    break;
                default:
                    organicList[whichPet].TakeToVet();
                    break;
            }

            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }

    }
}
