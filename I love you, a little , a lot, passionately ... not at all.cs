using System;

public class Kata
{
    public static string HowMuchILoveYou(int n)
    {
        int hlp = n % 6;
        if (hlp == 0)
        {
            return "not at all";
        }
        else if (hlp == 1)
        {
            return "I love you";
        }
        else if (hlp == 2)
        {
            return "a little";
        }
        else if (hlp == 3)
        {
            return "a lot";
        }
        else if (hlp == 4)
        {
            return "passionately";
        }
        return "madly";
    }
}