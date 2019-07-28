using System.Linq;

namespace Lesson02.CyclicRotation
{
    public class CyclicRotationSolution
    {
        public int[] Solution(int[] a, int k)
        {
            var length = a.Length;

            if (length == 0 || k % length == 0)
                return a;

            var amount = length - (k % length);
            var tmp = a.Skip(amount);
            var result = tmp
                .Concat(a.Take(amount))
                .ToArray();

            return result;
        }
    }
}
