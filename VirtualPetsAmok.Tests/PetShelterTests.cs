using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPetsAmok.Tests
{
    public class PetShelterTests
    {
        [Fact]
        public void Can_Pet_List_Be_Made()
        {
            PetShelter pets = new PetShelter();
        }

        [Fact]
        public void Is_The_List_Empty()
        {
            PetShelter pets = new PetShelter();

            Assert.Empty(pets.OrganicPetsList);
        }

        [Fact]
        public void Is_The_List_Not_Empty()
        {
            PetShelter pets = new PetShelter();

            pets.OrganicPetsList.Add(new OrganicPet());

            Assert.NotEmpty(pets.OrganicPetsList);
        }
    }
}
