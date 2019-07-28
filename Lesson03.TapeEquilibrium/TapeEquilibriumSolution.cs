using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson03.TapeEquilibrium
{
    public class TapeEquilibriumSolution
    {
        public int Solution(int[] a)
        {
            var sums = a
                .SkipLast(1)
                .Aggregate(new List<int>(), CalculateDiffs);

            var reverseSums = a
                .Skip(1)
                .Reverse()
                .Aggregate(new List<int>(), CalculateDiffs);
            reverseSums.Reverse();

            var result = sums
                .Zip(reverseSums, (first, second) => Math.Abs(first - second))
                .Min();

            return result;

            List<int> CalculateDiffs(List<int> acc, int v)
            {
                var sum = acc.LastOrDefault() + v;

                acc.Add(sum);

                return acc;
            }
        }
    }
}
