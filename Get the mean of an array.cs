using System.Linq;
using System.Collections.Generic;
using System;

public class Kata
{
    public static int GetAverage(int[] marks)
    {
        int c = 0;
        for (int i = 0; i < marks.Length; i++)
        {
            c += marks[i];
        }
        return c / marks.Length;
    }
}