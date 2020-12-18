using System;
using System.IO;
using Xunit;

namespace Lambdas.Tests
{
    public class LambdaExpressionTests
    {

        /// <summary>
        /// A function that takes two floating point numbers and returns the 
        /// bigger one. It uses lambda expressions to do so
        /// </summary>
        [Theory]
        [InlineData(4, 2)]
        [InlineData(2, 2)]
        [InlineData(2, 0)]
        [InlineData(2, -9)]
        public void Given_two_floating_point_numbers_returns_the_bigger_one(float bigger, float smaller)
        {
            //Given
            /// Doing this as:
            /// <code> Func<float, float, float> larger = (x, y) => x < y ? y : x; </code>
            /// will return an runtime error with, not all paths returns a value
            Func<float, float, float> larger = (x, y) => x < y ? y : x;

            //When
            var actual = larger(bigger, smaller);

            //Then
            Assert.Equal(bigger, actual);
        }

        [Theory]
        [InlineData(4, 2)]
        [InlineData(2, 2)]
        [InlineData(2, 0)]
        [InlineData(2, -9)]
        public void Reverse_of_Given_two_floating_point_numbers_returns_the_bigger_one(float bigger, float smaller)
        {
            //Given
            /// Doing this as:
            /// <code> Func<float, float, float> larger = (x, y) => x < y ? y : x; </code>
            /// will return an runtime error with, not all paths returns a value
            Func<float, float, float> larger = (x, y) => x < y ? y : x;

            //When
            var actual = larger(smaller, bigger);

            //Then
            Assert.Equal(bigger, actual);
        }

        /// <summary>
        /// Given a string print Hello, input string
        /// </summary>
        [Theory]
        [InlineData("A Generic Name")]
        [InlineData("Lukas")]
        [InlineData("")]
        public void Given_a_string_prints_Hello_and_input_string(string inputString)
        {
            //Given
            var writer = new StringWriter();
            Console.SetOut(writer);

            var expected = "Hello, " + inputString;

            Action<string> printHelloInput = s => Console.WriteLine("Hello, " + inputString);

            //When
            printHelloInput(inputString);

            //Then
            Assert.Equal(expected.Trim(), writer.GetStringBuilder().ToString().Trim());
        }

        [Theory]
        [InlineData(3.0)]
        [InlineData(0.1)]
        [InlineData(2.7)]
        public void Car_takes_less_than_4_seconds_to_go_to_nought_to_sixty_returns_true(decimal seconds)
        {
            //Given
            var car = new Car { NoughtToSixty = seconds };

            Predicate<Car> noughtToSixtyMoreThan4Seconds = c => c.NoughtToSixty < (decimal)4.0;

            //When
            var actual = noughtToSixtyMoreThan4Seconds(car);

            //Then
            Assert.True(actual);
        }

        [Theory]
        [InlineData(4.0)]
        [InlineData(4.1)]
        [InlineData(20.7)]
        public void Car_takes_more_than_4_seconds_to_go_to_nought_to_sixty_returns_false(decimal seconds)
        {
            //Given
            var car = new Car { NoughtToSixty = seconds };

            Predicate<Car> noughtToSixtyMoreThan4Seconds = c => c.NoughtToSixty < (decimal)4.0;

            //When
            var actual = noughtToSixtyMoreThan4Seconds(car);

            //Then
            Assert.False(actual);
        }
        

        private class Car
        {
            public decimal NoughtToSixty { get; set; }
        }
    }
}
