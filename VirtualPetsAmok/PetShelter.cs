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
    }
}
