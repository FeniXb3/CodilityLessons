using Xunit;

namespace Lesson02.CyclicRotation.Tests
{
    public class CyclicRotationTests
    {
        [Fact]
        void SampleDataTest()
        {
            var a = new[] {3, 8, 9, 7, 6};
            var k = 3;

            var solution = new CyclicRotationSolution();
            var expected = new[] {9, 7, 6, 3, 8};

            Assert.Equal(expected, solution.Solution(a, k));
        }
    }
}
