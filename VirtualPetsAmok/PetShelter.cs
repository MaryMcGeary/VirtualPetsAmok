using System;
using System.Collections.Generic;
using System.Linq;

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
                temp = (Console.ReadLine()+ "  ").ToLower().Remove(1);

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
                    string species = "";
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
                                Console.WriteLine("What species is your pet?");
                                errorCheck = Console.ReadLine();
                                if (errorCheck.Length > 0 && !int.TryParse(errorCheck, out number))
                                {
                                    species = errorCheck;
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
                    newPet = new OrganicPet(name, type, species, age, color);
                    PetsList.Add(newPet);
                }
                else if (temp == "r")
                {
                    type = "Robotic";
                    int proceedOkay;
                    string model = "";
                    int version = 0;
                    string material = "";
                    for (int questionNum = 0; questionNum < 3; questionNum += proceedOkay)
                    {
                        proceedOkay = 0;
                        string errorCheck;
                        int number;
                        switch (questionNum)
                        {
                            case 0:
                                Console.WriteLine("What model is your pet?");
                                errorCheck = Console.ReadLine();
                                if (errorCheck.Length > 0 && !int.TryParse(errorCheck, out number))
                                {
                                    model = errorCheck;
                                    proceedOkay = 1;
                                }
                                break;

                            case 1:
                                Console.WriteLine("What version is your pet");
                                errorCheck = Console.ReadLine();
                                if (errorCheck.Length > 0 && int.TryParse(errorCheck, out number))
                                {
                                    version = Convert.ToInt32(errorCheck);
                                    proceedOkay = 1;
                                }
                                break;

                            case 2:
                                Console.WriteLine("What material is your pet made out of?");
                                errorCheck = Console.ReadLine();
                                if (errorCheck.Length > 0)
                                {
                                   material = errorCheck;
                                    proceedOkay = 1;
                                }
                                break;
                        }
                    }
                    newPet = new RoboticPet(name, type, model, version, material);
                    PetsList.Add(newPet);
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
            int whichPet = PetSelectionMenu("Pet Adoption", 0);
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
            int whichPet = PetSelectionMenu("Display Info", 0);
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
            int whichPet = PetSelectionMenu("Display Stats", 0);
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
                    "HAVE PET PERFORM COMPUTATIONS",
                    "CHARGE YOUR PET",
                    "TAKE PET TO REPAIR SHOP",
                    "RETURN TO MAIN MENU"
                };

                var roboticList = PetsList.OfType<RoboticPet>().ToList();

                switch (graphicMenu.VisualMenu(interMenuItemsList, "Robotic Pet Interaction Menu"))
                {
                    case 1:
                        HavePetsComputate(roboticList);
                        break;
                    case 2:
                        ChargePets(roboticList);
                        break;
                    case 3:
                        TakePetsToRepair(roboticList);
                        break;
                    default:
                        run = false;
                        break;
                }

            } while (run);
        }

        public int PetSelectionMenu(string callingMenu, int type)
        {
            List<string> petSelMenuItemsList = new List<string>()
            {
                "ALL",
                "Cancel"
            };

            int petSelectedNum;
            int listMax = 0;
            
            if (type == 1)
            {
                var listOfNames = PetsList.OfType<OrganicPet>().ToList();

                for (int i = 0; i < listOfNames.Count; i++)
                {
                    int petNum = i + 1;
                    petSelMenuItemsList.Insert(petSelMenuItemsList.Count - 1, listOfNames[i].Name.ToString());
                }
                listMax = listOfNames.Count - 1;
            }
            else if (type == 2)
            {
                var listOfNames = PetsList.OfType<RoboticPet>().ToList();
                for (int i = 0; i < listOfNames.Count; i++)
                {
                    int petNum = i + 1;
                    petSelMenuItemsList.Insert(petSelMenuItemsList.Count - 1, listOfNames[i].Name.ToString());
                }
                listMax = listOfNames.Count - 1;
            }
            else
            {
                for (int i = 0; i < PetsList.Count; i++)
                {
                    int petNum = i + 1;
                    petSelMenuItemsList.Insert(petSelMenuItemsList.Count - 1, PetsList[i].Name.ToString());
                }
                listMax = PetsList.Count - 1;
            }
            

            Menu petVisualMenu = new Menu();

            petSelectedNum = petVisualMenu.VisualMenu(petSelMenuItemsList,callingMenu + " | Pet Selection Menu")-2;

            if(petSelectedNum > listMax)
            {
                petSelectedNum = -2;
            }

            return petSelectedNum;
        }

        public void PlayWithPets(List<OrganicPet> organicList)
        {
            int whichPet = PetSelectionMenu("Play", 1);
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
            int whichPet = PetSelectionMenu("Feed", 1);

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
            int whichPet = PetSelectionMenu("Vet", 1);

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

        public void HavePetsComputate(List<RoboticPet> roboticList)
        {
            int whichPet = PetSelectionMenu("Computation", 2);
            switch (whichPet)
            {
                case -1:
                    foreach (RoboticPet pet in roboticList)
                    {
                        pet.Computate();
                    }
                    break;

                case -2:
                    Console.WriteLine("\n\nCanceled!");
                    break;
                default:
                    roboticList[whichPet].Computate();
                    break;
            }

            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }

        public void ChargePets(List<RoboticPet> roboticList)
        {
            int whichPet = PetSelectionMenu("Battery Charge", 2);

            switch (whichPet)
            {
                case -1:
                    foreach (RoboticPet pet in roboticList)
                    {
                        pet.Charge();
                    }
                    break;
                case -2:
                    Console.WriteLine("\n\nCanceled!");
                    break;

                default:
                    roboticList[whichPet].Charge();
                    break;
            }

            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }

        public void TakePetsToRepair(List<RoboticPet> roboticList)
        {
            int whichPet = PetSelectionMenu("Repair Shop", 2);

            switch (whichPet)
            {
                case -1:
                    foreach (RoboticPet pet in roboticList)
                    {
                        pet.TakeToRepair();
                    }
                    break;
                case -2:
                    Console.WriteLine("\n\nCanceled!");
                    break;
                default:
                    roboticList[whichPet].TakeToRepair();
                    break;
            }

            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }

    }
}
