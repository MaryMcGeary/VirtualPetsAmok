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
            // Arrange
            PetShelter pets = new PetShelter();

        }
        [Fact]
        public void Is_The_List_Empty()
        {
            // Arrange
            PetShelter pets = new PetShelter();

            // Assert
            Assert.Empty(pets.OrganicPetsList);
        }
    }
}
