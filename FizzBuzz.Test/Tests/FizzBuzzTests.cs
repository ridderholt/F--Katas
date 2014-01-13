using System.Runtime.InteropServices;
using Xunit;

namespace FizzBuzz.Test.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Should_Return_One()
        {
            var fizz = new FizzBuzz();
            var actual = fizz.Calculate(1);
            var expected = "1";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Return_Fizz()
        {
            var fizz = new FizzBuzz();
            var acutal = fizz.Calculate(3);
            var expected = "Fizz";

            Assert.Equal(expected, acutal);
        }

        [Fact]
        public void Should_Return_Buzz()
        {
            var fizz = new FizzBuzz();
            var actual = fizz.Calculate(5);
            var expected = "Buzz";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Return_FizzBuzz()
        {
            var fizz = new FizzBuzz();
            var actual = fizz.Calculate(15);
            var expected = "FizzBuzz";

            Assert.Equal(expected, actual);
        }
    }
}