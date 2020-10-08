using System;
using Xunit;
using Inheritance;

namespace Inheritance.Tests
{
    public class AnimalTests : IDisposable
    {
        [Fact]
        public void Creating_2_Animals_returns_population_of_two()
        {
            //Given
            Animal dog = new Dog();
            Animal cat = new Cat();

            //Then
            Assert.Equal(2, dog.GetCurrentPopulation());
            Assert.Equal(2, cat.GetCurrentPopulation());
        }


        [Fact]
        public void Given_dog_produces_sound_of_Woof()
        {
            //Given
            var expected = "Woof";
            var dog = new Dog();

            //Then
            Assert.Equal(expected, dog.Sound());
        }

        [Fact]
        public void Given_cat_produces_sound_of_Miaw()
        {
            //Given
            var expected = "Miaw";
            var cat = new Cat();

            //Then
            Assert.Equal(expected, cat.Sound());
        }

        [Fact]
        public void Given_dog_ToString_return_Im_a_Dog()
        {
            //Given
            var dog = new Dog();

            //Then
            Assert.Equal("I'm a: Dog", dog.ToString());
        }

        [Fact]
        public void Given_cat_ToString_returns_Im_a_Cat()
        {
            //Given
            var cat = new Cat();

            //Then
            // As Cat does not handle the inherited field of name, it
            // it inherits the default name given in Animal
            Assert.Equal("I'm a: Animal", cat.ToString());
        }

        // Needed because of the static variable
        // This is an example of horrible code, which is intentional as the
        // meaning of it is to better understand static
        public void Dispose()
        {
            var resetDog = new Dog();
            resetDog.ResetCurrentPopulation();
        }
    }
}
