using Xunit;

namespace Lesson01.BinaryGap.Tests
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

        [Theory]
        [InlineData(138, 3)]
        [InlineData(2073, 6)]
        public void FirstBinaryGapIsLongestTest(int n, int expected)
        {
            var binaryGap = new BinaryGap();
            Assert.Equal(expected, binaryGap.Solution(n));
        }

        [Theory]
        [InlineData(1153, 6)]
        [InlineData(2003, 2)]
        public void LastBinaryGapIsLongestTest(int n, int expected)
        {
            var binaryGap = new BinaryGap();
            Assert.Equal(expected, binaryGap.Solution(n));
        }
    }
}