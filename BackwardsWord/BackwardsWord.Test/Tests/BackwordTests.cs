using StringUtil;
using Xunit;

namespace BackwardsWord.Test.Tests
{
    public class BackwordTests
    {
        [Fact]
        public void Should_Return_Green()
        {
            var backwords = new Backwords();
            var expected = "Green";
            var actual = backwords.Parse("neerG");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Return_neerG()
        {
            var backwords = new Backwords();
            var expected = "neerG";
            var actual = backwords.Parse("Green");

            Assert.Equal(expected, actual);
        }
    }
}