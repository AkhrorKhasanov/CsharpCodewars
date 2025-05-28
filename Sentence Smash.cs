public class Kata
{
    public static string Smash(string[] words)
    {
        if (words.Length == 0)
        {
            return "";
        }
        return string.Join(" ", words);
    }
}