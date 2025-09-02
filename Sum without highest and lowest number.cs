using System;
using System.Linq;

public static class Kata
{
    public static int Sum(int[] numbers)
    {
        if (numbers == null || numbers.Length < 2)
        {
            return 0;
        }
        return numbers.Sum() - numbers.Max() - numbers.Min();
    }
}