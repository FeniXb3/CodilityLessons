using System;
using System.Linq;
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

        [Fact]
        void RandomDataTest()
        {
            var random = new Random();
            var min = 1;
            var max = 100000000;
            var expected = random.Next(max, max*2);

            var expectedOccurances = Enumerable
                .Repeat(expected, random.Next(1, 100) * 2 + 1).ToArray();

            var n = 10000;
            var a = Enumerable
                .Repeat(0, n)
                .Select(e =>
                {
                    var i = random.Next(min, max);
                    return new[] {i, i, i, i, i, i, i, i, i, i};
                })
                .Append(expectedOccurances)
                .SelectMany(e => e)
                .ToArray();

            var solution = new OddOccurrencesInArraySolution();

            Assert.Equal(expected, solution.Solution(a));
        }
    }
}
