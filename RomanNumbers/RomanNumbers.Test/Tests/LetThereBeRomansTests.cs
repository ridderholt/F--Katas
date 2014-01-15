using System;
using Roman;
using Xunit;
using Xunit.Extensions;

namespace RomanNumbers.Test.Tests
{
    public class LetThereBeRomansTests
    {
        [Fact]
        public void Shold_return_V()
        {
            var romans = new LetThereBeRomans();
            var expected = "V";
            var actual = romans.ToRoman(5);

            Assert.Equal(expected, actual);
        }

        [Theory, InlineData(1), InlineData(2), InlineData(3)]
        public void Should_return_a_string(int n)
        {
            var romans = new LetThereBeRomans();
            var result = romans.ToRoman(n);

            Assert.IsType<string>(result);
        }
    }
}