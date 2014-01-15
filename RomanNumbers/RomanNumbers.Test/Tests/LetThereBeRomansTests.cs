using System;
using Roman;
using Xunit;

namespace RomanNumbers.Test.Tests
{
    public class LetThereBeRomansTests
    {
        private readonly LetThereBeRomans _romans;

        public LetThereBeRomansTests()
        {
            _romans = new LetThereBeRomans();
        }

        [Fact]
        public void Should_return_X()
        {
            var expected = "X";
            var actual = _romans.ToRoman(10);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Shold_return_V()
        {
            var expected = "V";
            var actual = _romans.ToRoman(5);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_return_L()
        {
            var expected = "L";
            var actual = _romans.ToRoman(50);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_return_C()
        {
            var expected = "C";
            var actual = _romans.ToRoman(100);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_return_M()
        {
            var expected = "M";
            var actual = _romans.ToRoman(1000);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_return_MCCCXXXVII()
        {
            var expected = "MCCCXXXVII";
            var actual = _romans.ToRoman(1337);

            Assert.Equal(expected, actual);
        }
    }
}