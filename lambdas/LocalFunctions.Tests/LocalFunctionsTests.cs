using System;
using Xunit;

namespace LocalFunctions.Tests
{
    public class LocalFunctionsTests
    {
        [Fact]
        public void Local_addition_function_given_3_3_return_6()
        {
            //Given
            int addition(int x, int y) { return x + y; };

            //When
            var actual = addition(3, 3);

            //Then
            AssemblyLoadEventArgs.Equals(6, actual);
        }
    }
}
