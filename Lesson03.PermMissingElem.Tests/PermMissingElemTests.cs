using Xunit;

namespace Lesson03.PermMissingElem.Tests
{
    public class PermMissingElemTests
    {
        [Theory]
        [InlineData(new[] {2, 3, 1, 5}, 4)]
        [InlineData(new[] {7, 1, 2, 6, 3, 4}, 5)]
        void SmallDataTest(int[] a, int expected)
        {
            var solution = new PermMissingElemSolution();

            var result = solution.Solution(a);

            Assert.Equal(expected, result);
        }

        [Fact]
        void EmptyDataTest()
        {
            var a = new int[] {};

            var solution = new PermMissingElemSolution();
            var expected = 1;

            var result = solution.Solution(a);

            Assert.Equal(expected, result);
        }
    }
}
