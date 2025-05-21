using System;

public class Kata
{
    public static char GetGrade(int s1, int s2, int s3)
    {
        double c = (s1 + s2 + s3) / 3.0;
        if (c >= 90 && c <= 100)
        {
            return 'A';
        }
        else if (c >= 80 && c < 90)
        {
            return 'B';
        }
        else if (c >= 70 && c < 80)
        {
            return 'C';
        }
        else if (c >= 60 && c < 70)
        {
            return 'D';
        }
        return 'F';
    }
}