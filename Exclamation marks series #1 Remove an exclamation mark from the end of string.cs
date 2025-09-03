public class Kata
{
    public static string Remove(string s)
    {
        if (s[^1] == '!')
        {
            return s[..^1];
        }
        else
        {
            return s;
        }
    }
}