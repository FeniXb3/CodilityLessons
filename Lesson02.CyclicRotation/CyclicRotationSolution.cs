using System.Linq;

namespace Lesson02.CyclicRotation
{
    public class CyclicRotationSolution
    {
        public int[] Solution(int[] a, int k)
        {
            var amount = a.Length - k;
            var tmp = a.Skip(amount);
            var result = tmp
                .Concat(a.Take(amount))
                .ToArray();

            return result;
        }
    }
}
