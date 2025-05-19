public class Kata
{
    public static int Grow(int[] x)
    {
        int p = 1;
        for (int i = 0; i < x.Length; i++)
        {
            p *= x[i];
        }
        return p;
    }
}