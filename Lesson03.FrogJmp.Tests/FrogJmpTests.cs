using Xunit;

namespace Lesson03.FrogJmp.Tests
{
    public class FrogJmpTests
    {
        [Theory]
        [InlineData(10, 85, 30, 3)]
        [InlineData(7, 53, 14, 4)]
        void SmallValuesTest(int x, int y, int d, int expected)
        {
            var solution = new FrogJmpSolution();

            var result = solution.Solution(x, y, d);

            Assert.Equal(expected, result);
        }

        [Fact]
        void StartEqualsTargetTest()
        {
            var x = 20;
            var y = 20;
            var d = 5;

            var solution = new FrogJmpSolution();
            var expected = 0;

            var result = solution.Solution(x, y, d);

            Assert.Equal(expected, result);
        }

        [Fact]
        void JumpBiggerThanDistanceTest()
        {
            var x = 10;
            var y = 85;
            var d = 10000;

            var solution = new FrogJmpSolution();
            var expected = 1;

            var result = solution.Solution(x, y, d);

            Assert.Equal(expected, result);
        }
    }
}
