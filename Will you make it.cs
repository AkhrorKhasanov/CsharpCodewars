using System;

public static class Kata
{
    public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
    {
        if (mpg * fuelLeft >= distanceToPump)
        {
            return true;
        }
        return false;
    }
}