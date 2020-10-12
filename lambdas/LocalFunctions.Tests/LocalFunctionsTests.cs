using System;
using Xunit;

namespace LocalFunctions.Tests
{
    public class LocalFunctionsTests
    {
        [Theory]
        [InlineData(3, 3)]
        [InlineData(1, 42)]
        [InlineData(0, -1)]
        [InlineData(-3, -2)]
        [InlineData(3, -2)]
        public void Local_addition_function_given_x_y_returns_addition_of_them(int value1, int value2)
        {
            //Given
            int addition(int x, int y) { return x + y; };

            //When
            var actual = addition(value1, value2);

            //Then
            AssemblyLoadEventArgs.Equals(6, value1 + value2);
        }
    }
}
