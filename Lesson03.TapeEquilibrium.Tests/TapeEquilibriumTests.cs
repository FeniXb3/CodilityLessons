using System.Linq;
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

        [Fact]
        void ExtremeNegativeTest()
        {
            var a = Enumerable
                .Repeat(-1000, 100000)
                .ToArray();
            var solution = new TapeEquilibriumSolution();
            var expected = 0;
            var result = solution.Solution(a);

            Assert.Equal(expected, result);
        }

        [Fact]
        void ExtremePositiveTest()
        {
            var a = Enumerable
                .Repeat(1000, 100000)
                .ToArray();
            var solution = new TapeEquilibriumSolution();
            var expected = 0;
            var result = solution.Solution(a);

            Assert.Equal(expected, result);
        }

        [Fact]
        void ExtremeDifferenceTest()
        {
            var a = Enumerable
                .Repeat(1000, 100000/2)
                .Concat(Enumerable.Repeat<int>(-1000, 100000/2))
                .ToArray();
            var solution = new TapeEquilibriumSolution();
            var expected = 2000;
            var result = solution.Solution(a);

            Assert.Equal(expected, result);
        }

        [Fact]
        void MixedSignsTest()
        {
            var a = new[] {-5, 7, 9, -79, 127};
            var solution = new TapeEquilibriumSolution();
            var expected = 37;
            var result = solution.Solution(a);

            Assert.Equal(expected, result);
        }
    }
}
