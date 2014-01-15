using System;
using Roman;
using Xunit;

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
    }
}