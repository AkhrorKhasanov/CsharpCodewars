public class Kata
{
    public static string FakeBin(string x)
    {
        string result = "";
        foreach (char c in x)
        {
            if (c < '5')
            {
                result += '0';
            }
            else
            {
                result += '1';
            }
        }
        return result;
    }
}