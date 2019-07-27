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

            var result = binary.Select((v, i) => (Value: ToBoolean(v), Index: i))
                .Where(e => e.Value)
                .Select(v => v.Index)
                .Aggregate((Gap: 0, Index: 0), (acc, newIndex) =>
                {
                    var (gap, oldIndex) = acc;
                    var newGap = newIndex - oldIndex - 1;
                    if (newGap > gap)
                    {
                        gap = newGap;
                    }

                    return (gap, newIndex);
                }, r => r.Gap);
            return result;

            bool ToBoolean(char value)
            {
                return Convert.ToBoolean(char.GetNumericValue(value));
            }
        }
    }
}