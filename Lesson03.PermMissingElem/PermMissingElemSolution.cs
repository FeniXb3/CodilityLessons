using System.Linq;

namespace Lesson03.PermMissingElem
{
    public class PermMissingElemSolution
    {
        public int Solution(int[] a)
        {
            var length = a.Length;

            if (length == 0)
            {
                return 1;
            }

            var result = Enumerable
                .Range(1, length + 1)
                .Except(a)
                .Single();

            return result;
        }
    }
}
