﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPets
{
    public class VirtualPets
    {
        // Info
        public string Name { get; set; }

        public string Breed { get; set; }

        public int Age { get; set; }

        public string Color { get; set; }

        // Stats

        public void CreatePet()
        {
            Console.WriteLine("\nWhat is your pet's name?");
            Name = Console.ReadLine();

            Console.WriteLine("What breed is your pet?");
            Breed = Console.ReadLine();

            Console.WriteLine("How old is your pet");
            Age = Convert.ToInt32(Console.ReadLine());  

            Console.WriteLine("What color is your pet");
            Color = Console.ReadLine();


        }



    }

}
