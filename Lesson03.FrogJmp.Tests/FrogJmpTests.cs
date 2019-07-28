using Xunit;

namespace Lesson03.FrogJmp.Tests
{
    public class FrogJmpTests
    {
        [Fact]
        void SampleDataTest()
        {
            var x = 10;
            var y = 85;
            var d = 30;

            var solution = new FrogJmpSolution();
            var expected = 3;

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
    }
}
