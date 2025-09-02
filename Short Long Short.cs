public class ShortLongShort
{
    public static string Solution(string a, string b)
    {
        if (a.Length > b.Length)
        {
            return b + a + b;
        }
        else
        {
            return a + b + a;
        }
    }
}