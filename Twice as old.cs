using System;
namespace Solution
{
    public class TwiceAsOldSolution
    {
        public static int TwiceAsOld(int dad, int son)
        {
            return Math.Abs(dad - 2 * son);
        }
    }
}