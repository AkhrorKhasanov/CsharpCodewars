public class Kata
{
    public static string Position(char alphabet)
    {
        string letters = "abcdefghijklmnopqrstuvwxyz";
        int pos = letters.IndexOf(alphabet) + 1;
        return $"Position of alphabet: {pos}";
    }
}