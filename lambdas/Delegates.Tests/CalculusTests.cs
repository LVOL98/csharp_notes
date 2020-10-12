using System;
using Xunit;
using static Delegates.Calculus;

namespace Delegates.Tests
{
    public class CalculusTests
    {
        [Fact]
        public void BinaryOperation_addition_1_1_equals_2()
        {
            //Given
            var operation = new BinaryOperation(
                delegate (int x, int y)
                {
                    return x + y;
                }
            );

            //When
            var result = operation(1, 1);

            //Then
            Assert.Equal(2, result);
        }

        [Fact]
        public void BinaryOperation_subtraction_2_1_equals_1()
        {
            //Given
            var operation = new BinaryOperation(
                delegate (int x, int y)
                {
                    return x - y;
                }
            );

            //When
            var result = operation(2, 1);

            //Then
            AssemblyLoadEventArgs.Equals(1, result);
        }
    }
}
