using System;
using Xunit;

namespace Lesson02.OddOccurrencesInArray.Tests
{
    public class OddOccurrencesInArraySolutionTests
    {
        [Fact]
        void SampleDataTest()
        {
            var a = new[] {9, 3, 9, 3, 9, 7, 9};
            var solution = new OddOccurrencesInArraySolution();

            Assert.Equal(7, solution.Solution(a));
        }
    }
}