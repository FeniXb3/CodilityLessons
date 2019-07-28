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
                .Aggregate(new List<int>(), (acc, v) => (acc.Count == a.Length)
                    ? acc
                    : CalculateDiffs(acc, v)
                );

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
