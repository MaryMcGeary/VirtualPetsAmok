using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace VirtualPetsAmok.Tests
{
    public class PetShelterTests
    {
        [Fact]
        public void Can_Pet_List_Be_Made()
        {
            PetShelter myShelter = new PetShelter();
        }

        [Fact]
        public void Is_The_List_Empty()
        {
            PetShelter myShelter = new PetShelter();

            Assert.Empty(myShelter.PetsList);
        }

        [Fact]
        public void Is_The_List_Not_Empty()
        {
            PetShelter myShelter = new PetShelter();

            myShelter.PetsList.Add(new OrganicPet());

            Assert.NotEmpty(myShelter.PetsList);
        }

        [Fact]
        public void Remove_A_Pet()
        {
            PetShelter myShelter = new PetShelter();

            myShelter.PetsList.Add(new OrganicPet());
            myShelter.PetsList.Remove(myShelter.PetsList[0]);

            Assert.Empty(myShelter.PetsList);
        }

        [Fact]
        public void Split_List_By_Type()
        {
            PetShelter myShelter = new PetShelter();
            myShelter.PetsList.Add(new RoboticPet("Rosie", "Robotic", "latest", 1, "metal"));
            myShelter.PetsList.Add(new OrganicPet("Fido", "Organic", "Dog", 1, "Brown"));
                    
            var organicList = myShelter.PetsList.OfType<OrganicPet>().ToList();
            
            Assert.Equal("Organic", organicList[0].Type);
        }
    }
}
