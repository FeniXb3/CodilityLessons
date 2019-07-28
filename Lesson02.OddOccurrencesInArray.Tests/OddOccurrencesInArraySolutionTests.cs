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

        [Fact]
        void PairsInARowTest()
        {
            var a = new[] {1, 1, 3, 3, 8, 8, 9};
            var solution = new OddOccurrencesInArraySolution();

            Assert.Equal(9, solution.Solution(a));
        }

        [Fact]
        void SingleValueTest()
        {
            var a = new[] {1000000000};
            var solution = new OddOccurrencesInArraySolution();

            Assert.Equal(1000000000, solution.Solution(a));
        }
    }
}