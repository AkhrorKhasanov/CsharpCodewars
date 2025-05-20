using System.Numerics;

public class Kata
{
    public static BigInteger[] PowersOfTwo(int n)
    {
        BigInteger[] x = new BigInteger[n + 1];
        BigInteger p = 1;
        for (int i = 0; i <= n; i++)
        {
            x[i] = p;
            p *= 2;
        }
        return x;
    }
}