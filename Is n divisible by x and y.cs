public class DivisibleNb
{
    public static bool IsDivisible(int n, int x, int y)
    {
        if (n % x == 0 && n % y == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
