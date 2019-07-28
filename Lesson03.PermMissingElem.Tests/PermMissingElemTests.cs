using Xunit;

namespace Lesson03.PermMissingElem.Tests
{
    public class PermMissingElemTests
    {
        [Fact]
        void SampleDataTest()
        {
            var a = new[] {2, 3, 1, 5};

            var solution = new PermMissingElemSolution();
            var expected = 4;

            var result = solution.Solution(a);

            Assert.Equal(expected, result);
        }
    }
}
