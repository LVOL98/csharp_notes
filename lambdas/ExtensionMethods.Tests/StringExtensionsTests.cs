using System;
using Xunit;
using static ExtensionMethods.StringExtension;

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
            var actual = text.AddPercent();

            //Then
            Assert.Equal("test%", actual);
        }
    }
}
