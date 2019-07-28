using System.Linq;

namespace Lesson02.OddOccurrencesInArray
{
    public class OddOccurrencesInArraySolution
    {
        public int Solution(int[] a)
        {
            var result = a.GroupBy(e => e)
                .Where(e => e.Count() % 2 == 1)
                .Select(e => e.Key)
                .FirstOrDefault();
            return result;
        }
    }
}
