using System;
using Xunit;
using static ExtensionMethods;

namespace ExtensionMethods.Tests
{
    public class StringExtensionsTests
    {
        [Fact]
        public void Given_test_adds_percentagesign_to_string()
        {
            //Given
            string text = "test";

            //When
            text.AddPercent();

            //Then
            Assert.Equal("test%", text);
        }
    }
}
