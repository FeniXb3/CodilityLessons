using Xunit;

namespace Lesson03.TapeEquilibrium.Tests
{
    public class TapeEquilibriumTests
    {
        [Fact]
        void SampleDataTest()
        {
            var a = new[] {3, 1, 2, 4, 3};


            var solution = new TapeEquilibriumSolution();
            var expected = 1;

            var result = solution.Solution(a);

            Assert.Equal(expected, result);
        }
    }
}
