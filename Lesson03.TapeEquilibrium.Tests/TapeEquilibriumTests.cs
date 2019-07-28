using Xunit;

namespace Lesson03.TapeEquilibrium.Tests
{
    public class TapeEquilibriumTests
    {
        [Theory]
        [InlineData(new[] {3, 1, 2, 4, 3}, 1)]
        [InlineData(new[] {1, 2, 3}, 0)]
        void SmallDataTest(int[] a, int expected)
        {
            var solution = new TapeEquilibriumSolution();

            var result = solution.Solution(a);

            Assert.Equal(expected, result);
        }
    }
}
