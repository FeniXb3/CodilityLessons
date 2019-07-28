﻿namespace Lesson03.FrogJmp
{
    public class FrogJmpSolution
    {
        public int Solution(int x, int y, int d)
        {
            if (x == y)
            {
                return 0;
            }

            var distance = y - x;

            if (distance < d)
            {
                return 1;
            }

            return 3;
        }
    }
}
