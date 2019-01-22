using System;
using Xunit;

namespace VirtualPets.Tests
{
    public class VirtualPetsAmokTests
    {

        [Fact]
        public void Pet_Class()
        {
            // Arrange
            VirtualPets pet = new VirtualPets();
            
        }

        [Fact]
        public void Name_Holds_Value()
        {
            // Arrange
            VirtualPets pet = new VirtualPets();

            // Act
            pet.Name = "Fido";
            
            // Assert
            Assert.Equal("Fido", pet.Name);

        }

        [Fact]
        public void Age_Holds_Value()
        {
            // Arrange
            VirtualPets pet = new VirtualPets();

            // Act
            pet.Age = 2;

            // Assert
            Assert.Equal(2, pet.Age);
        }

        [Fact]
        public void Hunger_Holds_Value()
        {
            // Arrange
            VirtualPets pet = new VirtualPets();

            // Act
            pet.Hunger = 50;

            // Assert
            Assert.Equal(50, pet.Hunger);
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
    }
}
