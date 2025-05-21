using System;

public class Kata
{
    public static bool CheckForFactor(int num, int factor)
    {
        if (num % factor == 0)
        {
            return true;
        }
        return false;
    }
}