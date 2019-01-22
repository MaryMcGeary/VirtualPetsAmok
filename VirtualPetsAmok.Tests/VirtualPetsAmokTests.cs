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


            // Assert
            Assert.Equal(2, pet.Age);
        }
    }
}
