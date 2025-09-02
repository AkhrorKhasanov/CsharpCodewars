using System;

public static class Kata
{
    public static double DbScale(double intensity)
    {
        double res = 10 * Math.Log10(intensity) + 120;
        return Math.Round(res);
    }
}