using Xunit;

namespace BinaryGap.Tests
{
    public class BinaryGapTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(4)]
        [InlineData(1024)]
        public void NoBinaryGapTest(int n)
        {
            var binaryGap = new BinaryGap();
            Assert.Equal(0, binaryGap.Solution(n));
        }

        [Theory]
        [InlineData(5, 1)]
        [InlineData(1025, 9)]
        public void SingleBinaryGapTest(int n, int expected)
        {
            var binaryGap = new BinaryGap();
            Assert.Equal(expected, binaryGap.Solution(n));
        }
    }
}