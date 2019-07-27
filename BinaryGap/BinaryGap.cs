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
            (int Gap, int Index) seed = (0, 0);

            var result = binary.Select((v, i) => new {Value = Convert.ToBoolean(char.GetNumericValue(v)), Index = i})
                .Where(e => e.Value)
                .Aggregate(seed, (acc, v) =>
                {
                    var newIndex = v.Index;
                    var (gap, oldIndex) = acc;
                    var newGap = newIndex - oldIndex - 1;
                    if (newGap > gap)
                    {
                        gap = newGap;
                    }

                    return (gap, newIndex);
                }, r => r.Gap);
            return result;
        }
    }
}