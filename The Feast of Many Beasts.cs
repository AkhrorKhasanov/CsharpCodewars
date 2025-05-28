public class Kata
{
    public static bool Feast(string beast, string dish)
    {
        if (beast[0] == dish[0] && beast[beast.Length - 1] == dish[dish.Length - 1])
        {
            return true;
        }
        return false;
    }
}