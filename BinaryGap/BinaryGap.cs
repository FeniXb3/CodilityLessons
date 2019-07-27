using System;
using System.Linq;

namespace BinaryGap
{
    public class BinaryGap
    {
        public int Solution(int N)
        {
            var binary = Convert.ToString(N, 2);
            // Func<int, int> map = (v, i) => new { Value = v, Index = i};

            var result = binary.Select((v, i) => new {Value = Convert.ToBoolean(char.GetNumericValue(v)), Index = i})
                .Where(e => e.Value)
                .Aggregate(new {Gap = 0, Index = 0}, (acc, v) =>
                {
                    var newGap = v.Index - acc.Index - 1;
                    var gap = acc.Gap;
                    if (newGap > gap)
                    {
                        gap = newGap;
                    }

                    return new {Gap = gap, v.Index};
                }, r => r.Gap);
            return result;
        }
    }
}