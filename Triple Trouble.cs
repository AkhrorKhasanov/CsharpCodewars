public class Kata
{
    public static string TripleTrouble(string one, string two, string three)
    {
        string res = "";
        for (int i = 0; i < one.Length; i++)
        {
            res += one[i];
            res += two[i];
            res += three[i];
        }
        return res;
    }
}