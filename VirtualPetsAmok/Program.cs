using System;

namespace VirtualPets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Quit/Start
            Console.WriteLine("Welcome to Virtual Pets Amok!");
            Console.WriteLine("Press 0 to Quit");

            string menuChoice = Console.ReadLine();

            if (menuChoice.Equals("0"))
            {
                Console.WriteLine("See you next time, friend.");
                return;
            }
            
        }
    }
}
