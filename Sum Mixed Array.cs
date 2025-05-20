using System;
public class Kata
{
    public static int SumMix(object[] x)
    {
        int c = 0;
        for (int i = 0; i < x.Length; i++)
        {
            c += Convert.ToInt32(x[i]);
        }
        return c;
    }
}