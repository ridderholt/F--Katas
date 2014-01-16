using System;
using Roman;
using Xunit;
using Xunit.Extensions;

namespace RomanNumbers.Test.Tests
{
    public class LetThereBeRomansTests
    {
        private readonly LetThereBeRomans _romans;

        public LetThereBeRomansTests()
        {
            _romans = new LetThereBeRomans();
        }

        [Theory, InlineData(1, "I"), InlineData(10, "X"), InlineData(5, "V"), InlineData(50, "L"),
        InlineData(100, "C"), InlineData(1000, "M"), InlineData(1337, "MCCCXXXVII")]
        public void Should_return_roman_number(int n, string expected)
        {
            var actual = _romans.ToRoman(n);

            Assert.Equal(expected, actual);
        }
    }
}