using System;
using System.Collections.Generic;

namespace VirtualPetsAmok
{
    class Program
    {
        static void Main(string[] args)
        {
            // Quit/Start
            Console.WriteLine("Welcome to Virtual Pets Amok!");

            bool run = true;
            var myShelter = new PetShelter();

            do
            {
                run = MainMenu(myShelter);
            } while (run);
        }

        static bool MainMenu(PetShelter myShelter)
        {
            Console.Clear();

            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("Press 1 to Create a Pet");
            Console.WriteLine("Press 2 to Display Pets' Information");
            Console.WriteLine("Press 3 to Display Pets' Stats");
            Console.WriteLine("Press 4 to Interact with Pets");
            Console.WriteLine("Press 5 to Remove a Pet");
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

            myShelter.TimeEffectAll();

            switch (menuChoice)
            {
                case "0":
                    Console.WriteLine("\nSee you next time, friend.");
                    return false;
                case "1":
                    Console.WriteLine("\nPet Creation:");
                    myShelter.CreateNewPet();
                    break;
                case "2":
                    myShelter.DisplayAllPetsInfo();
                    break;
                case "3":
                    myShelter.DisplayAllPetsStats();
                    break;
                case "4":
                    myShelter.InteractionMenu();
                    break;
                case "5":
                    myShelter.RemovePet();
                    break;
                default:
                    Console.WriteLine("\nIncorrect entry. Try again.");
                    break;
            }

            return true;

        }
    }
}
