using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetsAmok
{
    public class VirtualPet
    {
        public string Name { get; protected set; }
        public string Type { get; protected set; } // Robotic or Organic

       
        public virtual void DisplayPetInfo()
        {
        }

        public virtual void DisplayPetStats()
        {
        }

        public virtual void TimeEffect()
        {
        }


    }
}
