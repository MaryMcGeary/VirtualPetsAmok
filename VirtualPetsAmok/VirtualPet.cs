using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public abstract class VirtualPet
    {
        public string Name { get; protected set; }
        public string Type { get; protected set; } // Robotic or Organic

        public VirtualPet()
        {
            
        }

        public VirtualPet(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public abstract void DisplayPetInfo();

        public abstract void DisplayPetStats();

        public abstract void TimeEffect();


    }
}
