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
    }
}