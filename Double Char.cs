public class Kata
{
    public static string DoubleChar(string s)
    {
        string res = "";
        for (int i = 0; i < s.Length; i++)
        {
            res += s[i];
            res += s[i];
        }
        return res;
    }
}