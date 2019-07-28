using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lesson03.TapeEquilibrium
{
    public class TapeEquilibriumSolution
    {
        public int Solution(int[] a)
        {
            var sums = a
                .Aggregate(new List<int>(), (acc, v) =>
                {
                    if (acc.Count == a.Length)
                        return acc;

                    var sum = acc.LastOrDefault() + v;

                    acc.Add(sum);

                    return acc;
                });

            var reverseSums = a
                .Skip(1)
                .Reverse()
                .Aggregate(new List<int>(), (acc, v) =>
                {
                    var sum = acc.LastOrDefault() + v;

                    acc.Add(sum);

                    return acc;
                });
            reverseSums.Reverse();

            var result = sums
                .Zip(reverseSums, (first, second) => Math.Abs(first - second))
                .Min();

            return result;
        }
    }
}
