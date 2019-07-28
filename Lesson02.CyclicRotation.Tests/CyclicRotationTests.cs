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

        [Fact]
        void TheSameNumberTest()
        {
            var a = new[] {0, 0, 0};
            var k = 1;

            var solution = new CyclicRotationSolution();
            var expected = new[] {0, 0, 0};

            Assert.Equal(expected, solution.Solution(a, k));
        }

        [Fact]
        void CyclesEqualDataLengthTest()
        {
            var a = new[] {1, 2, 3, 4};
            var k = 4;

            var solution = new CyclicRotationSolution();
            var expected = new[] {1, 2, 3, 4};

            Assert.Equal(expected, solution.Solution(a, k));
        }
    }
}
