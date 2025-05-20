using System;
public class Cockroach
{
    public static int CockroachSpeed(double x)
    {
        return Convert.ToInt32(Math.Floor(x * 1000 / 36));
    }
}
