using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPetsAmok.Tests
{
    public class RoboticPetTests
    {

        [Fact]
        public void Pet_Class()
        {
            // Arrange
            RoboticPet pet = new RoboticPet("Rosie", "Robotic", "Liger", 2, "Titanium");
        }

        [Fact]
        public void Name_Holds_Value()
        {
            // Arrange
            RoboticPet pet = new RoboticPet("Rosie", "Robotic", "Liger", 2, "Titanium");

            // Act


            // Assert
            Assert.Equal("Rosie", pet.Name);
        }

        [Fact]
        public void Version_Holds_Value()
        {
            // Arrange
            RoboticPet pet = new RoboticPet("Rosie", "Robotic", "Liger", 2, "Titanium");

            // Act


            // Assert
            Assert.Equal(2, pet.Version);
        }

        [Fact]
        public void Hunger_Starts_At_Zero()
        {
            // Arrange
            RoboticPet pet = new RoboticPet("Rosie", "Robotic", "Liger", 2, "Titanium");

            // Act


            // Assert
            Assert.Equal(0, pet.TimeSinceLastCharge);
        }

        [Fact]
        public void Hunger_Holds_Value()
        {
            // Arrange
            RoboticPet pet = new RoboticPet("Rosie", "Robotic", "Liger", 2, "Titanium");

            // Act
            pet.Computate();

            // Assert
            Assert.Equal(10, pet.TimeSinceLastCharge);
        }

        // stats don't exceed limits
        [Fact]
        public void Stats_Dont_Exceed_Max()
        {
            RoboticPet pet = new RoboticPet("Rosie", "Robotic", "Liger", 2, "Titanium");

            for (int i = 0; i < 100; i++)
            {
                pet.Charge();
            }

            Assert.Equal(0, pet.TimeSinceLastCharge);
        }
    }
}
