using System;
public class Kata
{
    public static int DutyFree(int normPrice, int Discount, int hol)
    {
        return (int)(hol / (normPrice * Discount / 100.0));
    }
}