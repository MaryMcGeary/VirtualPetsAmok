using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class PetShelter
    {
        public List<OrganicPet> OrganicPetsList { get; set; }

        public PetShelter()
        {
            OrganicPetsList = new List<OrganicPet>();
        }

        public void CreateNewPet()
        {
            OrganicPet pet = new OrganicPet();

            pet.CreatePet();

            OrganicPetsList.Add(pet);
        }

        public void DisplayAllPetsInfo()
        {
            foreach (OrganicPet pet in OrganicPetsList)
            {
                Console.WriteLine("\n" + pet.Name + " Info: ");
                pet.DisplayPetInfo();
            }

            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }

        public void DisplayAllPetsStats()
        {
            foreach (OrganicPet pet in OrganicPetsList)
            {
                Console.WriteLine("\n" + pet.Name + " Stats: ");
                pet.DisplayPetStats();
            }

            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }

        public void TimeEffectAll()
        {
            foreach (OrganicPet pet in OrganicPetsList)
            {
                pet.TimeEffect();
            }
        }

        public int PetSelectionMenu()
        {
            Console.WriteLine("\n");

            for (int i = 0; i < OrganicPetsList.Count; i++)
            {
                int petNum = i + 1;
                Console.WriteLine("Press " + petNum + " for " + OrganicPetsList[i].Name);
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
                foreach (OrganicPet pet in OrganicPetsList)
                {
                    pet.Play();
                }
            }
            else
                OrganicPetsList[whichPet].Play();

            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }

        public void FeedPets(int whichPet)
        {
            if (whichPet == -1)
            {
                foreach (OrganicPet pet in OrganicPetsList)
                {
                    pet.Feed();
                }
            }
            else
                OrganicPetsList[whichPet].Feed();

            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }

        public void TakePetsToVet(int whichPet)
        {
            if (whichPet == -1)
            {
                foreach (OrganicPet pet in OrganicPetsList)
                {
                    pet.TakeToVet();
                }
            }
            else
                OrganicPetsList[whichPet].TakeToVet();

            Console.WriteLine("\nPress ANY KEY to continue");
            Console.ReadKey();
        }

    }
}
