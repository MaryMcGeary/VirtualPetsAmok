using System;

namespace VirtualPetsAmok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Quit/Start
            Console.WriteLine("Welcome to Virtual Pets Amok!");
            Console.WriteLine("Press 0 to Quit");

            int menuChoice = Convert.ToInt32(Console.ReadLine());

            if (menuChoice.Equals(0))
            {
                Console.WriteLine("See you next time, friend.");
                return;
            }
            
            


            

        }
    }
}
