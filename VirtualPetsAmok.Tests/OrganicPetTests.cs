using System;
using Xunit;

namespace VirtualPetsAmok.Tests
{
    public class OrganicPetTests
    {

        [Fact]
        public void Pet_Class()
        {
            // Arrange
            OrganicPet pet = new OrganicPet("Fido", "Organic", "Dog", 2, "Brown");
        }

        [Fact]
        public void Name_Holds_Value()
        {
            // Arrange
            OrganicPet pet = new OrganicPet("Fido", "Organic", "Dog", 2, "Brown");

            // Act


            // Assert
            Assert.Equal("Fido", pet.Name);
        }

        [Fact]
        public void Age_Holds_Value()
        {
            // Arrange
            OrganicPet pet = new OrganicPet("Fido", "Organic", "Dog", 2, "Brown");

            // Act
            

            // Assert
            Assert.Equal(2, pet.Age);
        }

        [Fact]
        public void Hunger_Starts_At_Zero()
        {
            // Arrange
            OrganicPet pet = new OrganicPet("Fido", "Organic", "Dog", 2, "Brown");

            // Act
            

            // Assert
            Assert.Equal(0, pet.Hunger);
        }

        [Fact]
        public void Hunger_Holds_Value()
        {
            // Arrange
            OrganicPet pet = new OrganicPet("Fido", "Organic", "Dog", 2, "Brown");

            // Act
            pet.Play();

            // Assert
            Assert.Equal(10, pet.Hunger);
        }

        [Fact]
        public void Loop_Performs_Once()
        {
            // Arrange
            bool run = false;
            int num = 0;

            // Act
            do
            {
                num++;

            } while (run == true);

            // Assert
            Assert.Equal(1, num);
        }

        [Fact]
        public void Switch_Chooses_Correct_Case()
        {
            // Arrange
            string menuChoice = "0";
            int num = 0;

            // Act
            switch (menuChoice)
            {
                case "0":
                    num = 1;
                    break;
                case "1":
                    num = 2;
                    break;
            }

            // Assert
            Assert.Equal(1, num);
        }

        // stats don't exceed limits
        [Fact]
        public void Stats_Dont_Exceed_Max()
        {
            OrganicPet pet = new OrganicPet("Fido", "Organic", "Dog", 2, "Brown");

            for(int i = 0; i < 100; i++)
            {
                pet.Feed();
            }

            Assert.Equal(0, pet.Hunger);
        }
    }
}
